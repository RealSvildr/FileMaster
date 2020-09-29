using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Linq;
using System.Drawing;
using System.Drawing.Imaging;
using Shell32;
using System.Security.Cryptography;

namespace File_Master
{
    //TODO: Use Multi-Thread to process
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.Font = new System.Drawing.Font(Font.Name, 8.25f * 96f / CreateGraphics().DpiX, Font.Style, Font.Unit, Font.GdiCharSet, Font.GdiVerticalFont);
            this.AutoScaleMode = AutoScaleMode.None;

            InitializeComponent();
        }

        #region Renamer
        List<string> listRemove = new List<string>();
        Dictionary<string, string> listReplace = new Dictionary<string, string>();

        private void RenamerText_Click(object sender, EventArgs e)
        {
            //folderBrowser.ShowDialog();
            //tRenamer.Text = folderBrowser.SelectedPath;
        }
        private void RenamerButton_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            tRenamer.Text = folderBrowser.SelectedPath;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (tRemove.Text != "" && !listRemove.Contains(tRemove.Text))
            {
                lRemove.Items.Add(tRemove.Text);
                listRemove.Add(tRemove.Text);
            }

            tRemove.Text = "";
        }
        private void ReplaceButton_Click(object sender, EventArgs e)
        {
            if (tReplace1.Text != "" && tReplace1.Text != tReplace2.Text &&
                !listReplace.ContainsKey(tReplace1.Text) && !listReplace.ContainsValue(tReplace1.Text))
            {

                lReplace.Items.Add(tReplace1.Text + " => " + tReplace2.Text);
                listReplace.Add(tReplace1.Text, tReplace2.Text);
                tReplace1.Text = "";
                tReplace2.Text = "";

                tReplace1.Focus();
            }
        }

        private void RenamerSButton_Click(object sender, EventArgs e)
        {
            string directory = tRenamer.Text;
            if (directory == "")
            {
                MessageBox.Show("Select a folder.");
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(directory);

            if (!dir.Exists)
            {
                MessageBox.Show("Folder does not exists.");
                return;
            }

            FileTextFormat fTFormat = FileTextFormat.none;

            switch ((string)cCase.SelectedItem)
            {
                case "lowercase":
                    fTFormat = FileTextFormat.lower;
                    break;
                case "UPPERCASE":
                    fTFormat = FileTextFormat.capital;
                    break;
                case "Propercase":
                    fTFormat = FileTextFormat.firstletter;
                    break;
                case "Title Case":
                    fTFormat = FileTextFormat.allfirstletter;
                    break;
            }

            List<FileInfo> listFiles = dir.GetFiles().ToList();
            List<string> listOldName = listFiles.Select(p => p.Name.ToLower()).ToList();

            string ret = "";
            foreach (var file in listFiles)
            {
                string oldName = file.Name;//.Substring(0, file.Name.Length - file.Extension.Length);
                string name = oldName;
                //string extension = file.Extension.ToLower();

                foreach (var rem in listRemove)
                {
                    name = name.Replace(rem, "");
                }

                foreach (var rep in listReplace)
                {
                    name = name.Replace(rep.Key, rep.Value);
                }

                switch (fTFormat)
                {
                    case FileTextFormat.lower:
                        name = name.ToLower();
                        break;
                    case FileTextFormat.capital:
                        name = name.ToUpper();
                        break;
                    case FileTextFormat.firstletter:
                        name = name[0].ToString().ToUpper() + name.Substring(1, name.Length - 1).ToLower();
                        break;
                    case FileTextFormat.allfirstletter:
                        name = string.Join(" ", name.Split(' ').ToList().Select(p => p[0].ToString().ToUpper() + p.Substring(1, p.Length - 1).ToLower()));
                        break;
                }

                name = tStartWith.Text + name + tEndWith.Text;

                if (name.ToLower() != oldName.ToLower() && listOldName.Contains(name.ToLower() /*+ extension*/))
                {
                    ret += "It was not possible to change the title of '" + file.Name + "', to '" + name + "', because there is already one file with this name.\n";
                }
                else if (name != oldName)
                {
                    file.MoveTo(directory + "\\" + name /*+ extension*/);
                } // else --> nothing was done
            }
            foreach (var dir2 in dir.GetDirectories())
            {
                var name = dir2.Name;
                foreach (var rep in listReplace)
                {
                    name = name.Replace(rep.Key, rep.Value);
                }

                if (name != dir2.Name)
                {
                    dir2.MoveTo(directory + "\\" + name);
                }
            }

            if (!cKeepAll.Checked)
            {
                listRemove = new List<string>();
                listReplace = new Dictionary<string, string>();
                tStartWith.Text = tEndWith.Text = tRemove.Text = tReplace1.Text = tReplace2.Text = "";
                lRemove.Items.Clear();
                lReplace.Items.Clear();
            }

            if (ret != "")
            {
                MessageBox.Show(ret);
            }
        }

        private enum FileTextFormat
        {
            none = 0,
            lower = 1,
            capital = 2,
            firstletter = 3,
            allfirstletter = 4
        }
        #endregion

        #region Music
        private void MusicText_Click(object sender, EventArgs e)
        {
            //folderBrowser.ShowDialog();
            //tMusic.Text = folderBrowser.SelectedPath;
        }
        private void MusicButton_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            tMusic.Text = folderBrowser.SelectedPath;
        }

        private void MusicEButton_Click(object sender, EventArgs e)
        {
            string directory = tMusic.Text;
            if (directory == "")
            {
                MessageBox.Show("Select a folder.");
                return;
            }

            DirectoryInfo dir = new DirectoryInfo(directory);

            if (!dir.Exists)
            {
                MessageBox.Show("Folder does not exists.");
                return;
            }

            int number = 0;
            foreach (FileInfo file in dir.GetFiles())
            {
                if (file.Extension == ".mp3")
                {
                    TagLib.File tagLib = TagLib.File.Create(file.FullName);

                    if (cMusicName.Checked)
                    {
                        string name = file.Name.Substring(file.Name.IndexOf('-') + 1, file.Name.Length - file.Name.IndexOf('-') - 1);
                        name = name.Substring(0, name.Length - file.Extension.Length);
                        name = name.Trim();

                        tagLib.Tag.Title = name;
                    }

                    if (cMusicNumber.Checked)
                    {
                        number = 0;
                        int.TryParse(file.Name.Substring(0, 3), out number);

                        if (number == 0)
                        {
                            int.TryParse(file.Name.Substring(0, 2), out number);
                        }

                        if (number == 0)
                        {
                            int.TryParse(file.Name.Substring(0, 1), out number);
                        }

                        tagLib.Tag.Track = (uint)number;
                    }

                    if (cMusicComment.Checked)
                    {
                        tagLib.Tag.Comment = "";
                    }

                    tagLib.Tag.Album = tMusicAlbum.Text;

                    if (tMusicYear.Text != "")
                    {
                        tagLib.Tag.Year = Convert.ToUInt32(tMusicYear.Text);
                    }

                    tagLib.Tag.AlbumArtists = tMusicArtists.Text.Split(';');
                    tagLib.Tag.Performers = tMusicArtists.Text.Split(';');
                    tagLib.Tag.Genres = tMusicGenres.Text.Split(';');

                    tagLib.Save();
                    tagLib.Dispose();
                }
            }
        }

        private void MusicTextYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!OnlyNumbers(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar > 32 && Convert.ToInt32(tMusicYear.Text + e.KeyChar.ToString()) > DateTime.Now.Year + 1)
            {
                e.Handled = true;
                return;
            }
        }
        #endregion

        #region Image
        List<string> listImageConvert = new List<string>();

        private void ImageText_Click(object sender, EventArgs e)
        {
            //folderBrowser.ShowDialog();
            //tImage.Text = folderBrowser.SelectedPath;
        }
        private void ImageButton_Click(object sender, EventArgs e)
        {
            folderBrowser.ShowDialog();
            tImage.Text = folderBrowser.SelectedPath;
        }

        private void ImageExecute_Click(object sender, EventArgs e)
        {
            if (ImageValidate())
                return;

            string directory = tImage.Text;
            DirectoryInfo dir = new DirectoryInfo(directory);
            List<string> imageTypes = new List<string>();
            List<Img> listImage = new List<Img>();
            string newFormat = cImageConvertTo.SelectedItem == null ? "" : cImageConvertTo.SelectedItem.ToString().ToLower();


            if (cImageConvert.Checked)
                imageTypes.AddRange(listImageConvert);
            else
                imageTypes.AddRange(new List<string> { "jpg", "png", "gif", "jpeg", "bmp", "jpe", "ico", "tif", "tiff", "jfif" });

            foreach (var file in dir.GetFiles())
                if (imageTypes.Contains(file.Extension.ToLower().Trim('.')))
                    listImage.Add(new Img()
                    {
                        Name = file.Name,
                        Extension = file.Extension.ToLower().Trim('.'),
                        FullDir = file.FullName
                    });

            string strError = string.Empty;
            MemoryStream memStream;
            Image i, img;
            foreach (Img im in listImage)
            {
                using (memStream = new MemoryStream())
                {
                    // Load Image
                    if (im.Extension == "webp")
                    {
                        var sE = new Imazen.WebP.SimpleDecoder();

                        using (var fS = new FileStream(im.FullDir, FileMode.Open))
                        {
                            byte[] buffer = new byte[fS.Length];
                            fS.Read(buffer, 0, (int)fS.Length);

                            img = sE.DecodeFromBytes(buffer, fS.Length);
                        }

                        im.Width = img.Width;
                        im.Height = img.Height;
                    }
                    else
                    {
                        using (i = Image.FromFile(im.FullDir))
                        {
                            im.Width = i.Width;
                            im.Height = i.Height;

                            i.Save(memStream, im.Format);
                        }
                        img = Image.FromStream(memStream);
                    }


                    //Resize
                    img = ResizeImage(img, im);


                    // Convert
                    if (cImageConvert.Checked)
                    {
                        FileInfo fI = new FileInfo(im.FullDir.Substring(0, im.FullDir.Length - im.Extension.Length) + newFormat);

                        if (fI.Exists)
                        {
                            strError += " File already exists: " + im.Name.Substring(0, im.FullDir.Length - im.Extension.Length) + newFormat + Environment.NewLine;
                        }
                        else
                        {
                            var newFile = im.FullDir;
                            if (!cImageOldExtension.Checked)
                                newFile = im.FullDir.Substring(0, im.FullDir.Length - im.Extension.Length) + newFormat;

                            im.Extension = newFormat;
                            RemoveFile(newFile);

                            if (newFormat == "webp")
                            {
                                using (var stream = new FileStream(newFile, FileMode.CreateNew))
                                {
                                    var sE = new Imazen.WebP.SimpleEncoder();
                                    sE.Encode((Bitmap)img, stream, 96.6f);
                                }
                            }
                            else
                                img.Save(newFile, im.Format);

                            if (cImageRemoveOrigin.Checked && !cImageOldExtension.Checked)
                                RemoveFile(im.FullDir);
                        }
                    }
                    else
                    {
                        img.Save(im.FullDir, im.Format);
                    }

                    img.Dispose();
                }
            }

            if (strError != "")
            {
                MessageBox.Show(strError);
            }

            if (!cKeepAll.Checked)
            {
                listImageConvert.Clear();
                lImageFrom.Items.Clear();
            }

            MessageBox.Show("Finished.");
        }
        private void bImageFrom_Click(object sender, EventArgs e)
        {
            tImageFrom.Text = tImageFrom.Text.ToLower();
            if (tImageFrom.Text != "" && !listImageConvert.Contains(tImageFrom.Text))
            {
                listImageConvert.Add(tImageFrom.Text);
                lImageFrom.Items.Add(tImageFrom.Text);
                tImageFrom.Text = "";
            }
        }

        private Rectangle destRect;
        private Bitmap destBitmap;
        private Graphics graph;
        private ImageAttributes wrap;
        private Image ResizeImage(Image img, Img im)
        {
            if (cImageResize.Checked)
            {
                decimal maxHeight = Convert.ToInt32(tImageMaxHeight.Text);
                decimal maxWidth = Convert.ToInt32(tImageMaxWidth.Text);
                decimal minSize = 1 - Convert.ToDecimal(tImageMaxResize.Text) / 100;

                decimal resizeP = 1;
                if (maxWidth > 0 && maxHeight > 0 &&
                    maxWidth < im.Width && maxHeight < im.Height)
                    if (maxWidth / im.Width < maxHeight / im.Height)
                        resizeP = maxWidth / im.Width;
                    else
                        resizeP = maxHeight / im.Height;
                else if (maxWidth > 0 && maxWidth < im.Width)
                    resizeP = maxWidth / im.Width;
                else if (maxHeight > 0 && maxHeight < im.Height)
                    resizeP = maxHeight / im.Height;


                if (resizeP < minSize)
                    resizeP = minSize;

                var width = (int)(im.Width * resizeP);
                var height = (int)(im.Height * resizeP);

                destRect = new Rectangle(0, 0, width, height);
                destBitmap = new Bitmap(width, height);

                destBitmap.SetResolution(img.HorizontalResolution, img.VerticalResolution);

                using (graph = Graphics.FromImage(destBitmap))
                {
                    graph.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceCopy;
                    graph.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                    graph.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                    graph.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                    graph.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                    using (wrap = new ImageAttributes())
                    {
                        wrap.SetWrapMode(System.Drawing.Drawing2D.WrapMode.TileFlipXY);
                        graph.DrawImage(img, destRect, 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, wrap);
                    }
                }

                return destBitmap;
            }

            return img;
        }
        private bool ImageValidate()
        {
            string directory = tImage.Text;
            if (directory == "")
            {
                MessageBox.Show("Select a folder.");
                return true;
            }

            if (!Directory.Exists(directory))
            {
                MessageBox.Show("Folder does not exists.");
                return true;
            }

            //if (!cImageResize.Checked && !cImageConvert.Checked) {
            //    MessageBox.Show("Select an option.");
            //    return true;
            //}

            return false;
        }

        private void ImageCheckboxResize_CheckedChanged(object sender, EventArgs e)
        {
            tImageMaxResize.Enabled = cImageResize.Checked;
            tImageMaxHeight.Enabled = cImageResize.Checked;
            tImageMaxWidth.Enabled = cImageResize.Checked;
        }
        private void ImageCheckboxConvert_CheckedChanged(object sender, EventArgs e)
        {
            cImageRemoveOrigin.Enabled = cImageConvert.Checked;
            cImageConvertTo.Enabled = cImageConvert.Checked;
            cImageOldExtension.Enabled = cImageConvert.Checked;
            tImageFrom.Enabled = cImageConvert.Checked;
            bImageFrom.Enabled = cImageConvert.Checked;
            lImageFrom.Enabled = cImageConvert.Checked;
        }
        private void ImageTextMaxResize_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!OnlyNumbers(e.KeyChar))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar > 32 && Convert.ToInt32(tImageMaxResize.Text + e.KeyChar.ToString()) > 100)
            {
                e.Handled = true;
                return;
            }
        }
        private void ImageTextMaxWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!OnlyNumbers(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void ImageTextMaxHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!OnlyNumbers(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void RemoveFile(string filePath)
        {
            if (File.Exists(filePath))
            {
                Shell shell = new Shell();
                Folder recyclingBin = shell.NameSpace(ShellSpecialFolderConstants.ssfBITBUCKET);
                recyclingBin.MoveHere(filePath);
            }
        }

        private class Img
        {
            public string Name { get; set; }
            public string Extension { get; set; }
            public ImageFormat Format { get { return getFormat(Extension); } }
            public string FullDir { get; set; }

            public decimal Width { get; set; }
            public decimal Height { get; set; }

            private ImageFormat getFormat(string ext)
            {
                ImageFormat imgFormat;

                switch (ext)
                {
                    case "gif":
                        imgFormat = ImageFormat.Gif;
                        break;
                    case "bmp":
                        imgFormat = ImageFormat.Bmp;
                        break;
                    case "ico":
                        imgFormat = ImageFormat.Icon;
                        break;
                    case "tif":
                    case "tiff":
                        imgFormat = ImageFormat.Tiff;
                        break;
                    case "png":
                        imgFormat = ImageFormat.Png;
                        break;
                    default:
                        imgFormat = ImageFormat.Jpeg;
                        break;
                }

                return imgFormat;
            }
        }
        #endregion

        private bool OnlyNumbers(char x)
        {
            while (x > 256)
            { x = (char)((int)x - 256); }

            if ((x >= 48 && x <= 57) || (x < 32))
            {
                return true;
            }

            return false;
        }

        #region Folder
        private void FolderExecute_Click(object sender, EventArgs e)
        {
            string directory = tFolder.Text;
            DirectoryInfo dir = new DirectoryInfo(directory);

            // Delete Duplicate
            if (cFolderDuplicate.Checked)
            {
                /* Special Cases */
                foreach (var file in dir.GetFiles())
                {
                    if (file.Name.Contains("thumbnail"))
                        RemoveFile(file.FullName);
                }
                /*********************/

                var listFiles = new List<FFiles>();
                int id = 0;
                foreach (var file in dir.GetFiles().OrderBy(o => o.Name.Replace(o.Extension, "")))
                {
                    id++;
                    listFiles.Add(new FFiles
                    {
                        Id = id,
                        Dir = file.FullName,
                        Hash = GetFileHash(file.FullName)
                    });
                }

                var filesToDelete = listFiles.Where(o => listFiles.Exists(p => p.Id < o.Id && p.Hash == o.Hash));

                foreach (var file in filesToDelete)
                    RemoveFile(file.Dir);
            }

            //Remove Files By Name
            if (cFolderFileByName.Checked)
            {
                foreach (var file in dir.GetFiles())
                {
                    string name = !string.IsNullOrEmpty(file.Extension) ? file.Name.Replace(file.Extension, "") : file.Name;

                    if (listFolderRemove.Contains(name))
                        file.Delete();
                }

                foreach (var dir2 in dir.GetDirectories())
                {
                    listFolderRemove.ForEach(d =>
                    {
                        try { dir2.MoveTo(dir2.FullName.Replace(d, "")); }
                        catch (Exception) { }
                    });
                    dir2.GetFiles().ToList().ForEach(o =>
                    {
                        string name = !string.IsNullOrEmpty(o.Extension) ? o.Name.Replace(o.Extension, "") : o.Name;

                        if (listFolderRemove.Contains(name))
                        {
                            o.Delete();
                        }
                    });

                    //if (listFolderRemove.Contains(dir2.Name)) {
                    //    dir2.Delete(true);
                    //}
                }
            }

            if (!cKeepAll.Checked)
            {
                cFolderDuplicate.Checked = false;
                cFolderFileByName.Checked = false;
                listFolderRemove = new List<string>();
                lFolderRemove.Items.Clear();
            }
        }

        private List<string> listFolderRemove = new List<string>();
        private void FolderRemove_Click(object sender, EventArgs e)
        {
            if (tFolderRemove.Text != "" && !listFolderRemove.Contains(tFolderRemove.Text))
            {
                lFolderRemove.Items.Add(tFolderRemove.Text);
                listFolderRemove.Add(tFolderRemove.Text);
            }

            tFolderRemove.Text = "";
            tFolderRemove.Focus();
        }
        private string GetFileHash(string path)
        {
            HashAlgorithm sha1 = HashAlgorithm.Create();
            byte[] ret;

            try
            {
                using (Stream st = new FileStream(path, FileMode.Open, FileAccess.Read))
                    ret = sha1.ComputeHash(st);

                return ByteArrayToString(ret);
            }
            catch (Exception) { }

            return null;
        }
        private string ByteArrayToString(byte[] byteArray)
        {
            string str = "";

            foreach (byte b in byteArray)
                str += b.ToString("X2");

            return str;
        }

        private class FFiles
        {
            public int Id { get; set; }
            public string Dir { get; set; }
            public string Hash { get; set; }
        }
        #endregion
    }
}
