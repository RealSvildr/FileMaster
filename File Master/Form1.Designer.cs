namespace File_Master {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.tEndWith = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tStartWith = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cCase = new System.Windows.Forms.ComboBox();
            this.bRenamerS = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tReplace2 = new System.Windows.Forms.TextBox();
            this.lReplace = new System.Windows.Forms.ListBox();
            this.bReplace = new System.Windows.Forms.Button();
            this.tReplace1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lRemove = new System.Windows.Forms.ListBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.tRemove = new System.Windows.Forms.TextBox();
            this.bRenamer = new System.Windows.Forms.Button();
            this.tRenamer = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cMusicName = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tMusicArtists = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tMusicYear = new System.Windows.Forms.TextBox();
            this.cMusicComment = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tMusicGenres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tMusicAlbum = new System.Windows.Forms.TextBox();
            this.cMusicNumber = new System.Windows.Forms.CheckBox();
            this.bMusicE = new System.Windows.Forms.Button();
            this.bMusic = new System.Windows.Forms.Button();
            this.tMusic = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cImageRemoveOrigin = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lImageFrom = new System.Windows.Forms.ListBox();
            this.bImageFrom = new System.Windows.Forms.Button();
            this.tImageFrom = new System.Windows.Forms.TextBox();
            this.cImageConvertTo = new System.Windows.Forms.ComboBox();
            this.cImageConvert = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cImageResize = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tImageMaxHeight = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tImageMaxWidth = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tImageMaxResize = new System.Windows.Forms.TextBox();
            this.bImageE = new System.Windows.Forms.Button();
            this.bImage = new System.Windows.Forms.Button();
            this.tImage = new System.Windows.Forms.TextBox();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.cKeepAll = new System.Windows.Forms.CheckBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 11);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(480, 331);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.tEndWith);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.tStartWith);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.cCase);
            this.tabPage1.Controls.Add(this.bRenamerS);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.bRenamer);
            this.tabPage1.Controls.Add(this.tRenamer);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(472, 302);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "File Renamer";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 17);
            this.label13.TabIndex = 20;
            this.label13.Text = "Case Type";
            // 
            // tEndWith
            // 
            this.tEndWith.Location = new System.Drawing.Point(312, 70);
            this.tEndWith.Margin = new System.Windows.Forms.Padding(2);
            this.tEndWith.Multiline = true;
            this.tEndWith.Name = "tEndWith";
            this.tEndWith.Size = new System.Drawing.Size(145, 21);
            this.tEndWith.TabIndex = 19;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(309, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 17);
            this.label12.TabIndex = 18;
            this.label12.Text = "End With";
            // 
            // tStartWith
            // 
            this.tStartWith.Location = new System.Drawing.Point(163, 70);
            this.tStartWith.Margin = new System.Windows.Forms.Padding(2);
            this.tStartWith.Multiline = true;
            this.tStartWith.Name = "tStartWith";
            this.tStartWith.Size = new System.Drawing.Size(145, 21);
            this.tStartWith.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(160, 51);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 17);
            this.label11.TabIndex = 16;
            this.label11.Text = "Start With";
            // 
            // cCase
            // 
            this.cCase.FormattingEnabled = true;
            this.cCase.Items.AddRange(new object[] {
            "Don\'t change",
            "lowercase",
            "UPPERCASE",
            "Propercase",
            "Title Case"});
            this.cCase.Location = new System.Drawing.Point(13, 70);
            this.cCase.Name = "cCase";
            this.cCase.Size = new System.Drawing.Size(145, 24);
            this.cCase.TabIndex = 15;
            // 
            // bRenamerS
            // 
            this.bRenamerS.Location = new System.Drawing.Point(387, 16);
            this.bRenamerS.Margin = new System.Windows.Forms.Padding(2);
            this.bRenamerS.Name = "bRenamerS";
            this.bRenamerS.Size = new System.Drawing.Size(74, 22);
            this.bRenamerS.TabIndex = 14;
            this.bRenamerS.Text = "Execute";
            this.bRenamerS.UseVisualStyleBackColor = true;
            this.bRenamerS.Click += new System.EventHandler(this.bRenamerS_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tReplace2);
            this.groupBox2.Controls.Add(this.lReplace);
            this.groupBox2.Controls.Add(this.bReplace);
            this.groupBox2.Controls.Add(this.tReplace1);
            this.groupBox2.Location = new System.Drawing.Point(242, 119);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(219, 179);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Replace from title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "to";
            // 
            // tReplace2
            // 
            this.tReplace2.Location = new System.Drawing.Point(100, 22);
            this.tReplace2.Margin = new System.Windows.Forms.Padding(2);
            this.tReplace2.Name = "tReplace2";
            this.tReplace2.Size = new System.Drawing.Size(55, 22);
            this.tReplace2.TabIndex = 11;
            // 
            // lReplace
            // 
            this.lReplace.FormattingEnabled = true;
            this.lReplace.ItemHeight = 16;
            this.lReplace.Location = new System.Drawing.Point(17, 45);
            this.lReplace.Margin = new System.Windows.Forms.Padding(2);
            this.lReplace.Name = "lReplace";
            this.lReplace.Size = new System.Drawing.Size(187, 132);
            this.lReplace.TabIndex = 13;
            // 
            // bReplace
            // 
            this.bReplace.Location = new System.Drawing.Point(159, 21);
            this.bReplace.Margin = new System.Windows.Forms.Padding(2);
            this.bReplace.Name = "bReplace";
            this.bReplace.Size = new System.Drawing.Size(45, 22);
            this.bReplace.TabIndex = 12;
            this.bReplace.Text = "Add";
            this.bReplace.UseVisualStyleBackColor = true;
            this.bReplace.Click += new System.EventHandler(this.bReplace_Click);
            // 
            // tReplace1
            // 
            this.tReplace1.Location = new System.Drawing.Point(17, 22);
            this.tReplace1.Margin = new System.Windows.Forms.Padding(2);
            this.tReplace1.Name = "tReplace1";
            this.tReplace1.Size = new System.Drawing.Size(55, 22);
            this.tReplace1.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lRemove);
            this.groupBox1.Controls.Add(this.bRemove);
            this.groupBox1.Controls.Add(this.tRemove);
            this.groupBox1.Location = new System.Drawing.Point(13, 119);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(219, 179);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Remove from title";
            // 
            // lRemove
            // 
            this.lRemove.FormattingEnabled = true;
            this.lRemove.ItemHeight = 16;
            this.lRemove.Location = new System.Drawing.Point(17, 48);
            this.lRemove.Margin = new System.Windows.Forms.Padding(2);
            this.lRemove.Name = "lRemove";
            this.lRemove.Size = new System.Drawing.Size(187, 132);
            this.lRemove.TabIndex = 9;
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(159, 21);
            this.bRemove.Margin = new System.Windows.Forms.Padding(2);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(45, 22);
            this.bRemove.TabIndex = 8;
            this.bRemove.Text = "Add";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // tRemove
            // 
            this.tRemove.Location = new System.Drawing.Point(17, 22);
            this.tRemove.Margin = new System.Windows.Forms.Padding(2);
            this.tRemove.Name = "tRemove";
            this.tRemove.Size = new System.Drawing.Size(137, 22);
            this.tRemove.TabIndex = 7;
            // 
            // bRenamer
            // 
            this.bRenamer.Location = new System.Drawing.Point(270, 19);
            this.bRenamer.Margin = new System.Windows.Forms.Padding(2);
            this.bRenamer.Name = "bRenamer";
            this.bRenamer.Size = new System.Drawing.Size(67, 22);
            this.bRenamer.TabIndex = 1;
            this.bRenamer.Text = "Folder";
            this.bRenamer.UseVisualStyleBackColor = true;
            this.bRenamer.Click += new System.EventHandler(this.bRenamer_Click);
            // 
            // tRenamer
            // 
            this.tRenamer.Location = new System.Drawing.Point(13, 20);
            this.tRenamer.Margin = new System.Windows.Forms.Padding(2);
            this.tRenamer.Name = "tRenamer";
            this.tRenamer.Size = new System.Drawing.Size(255, 22);
            this.tRenamer.TabIndex = 0;
            this.tRenamer.Click += new System.EventHandler(this.tRenamer_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cMusicName);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tMusicArtists);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Controls.Add(this.tMusicYear);
            this.tabPage3.Controls.Add(this.cMusicComment);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.tMusicGenres);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Controls.Add(this.tMusicAlbum);
            this.tabPage3.Controls.Add(this.cMusicNumber);
            this.tabPage3.Controls.Add(this.bMusicE);
            this.tabPage3.Controls.Add(this.bMusic);
            this.tabPage3.Controls.Add(this.tMusic);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage3.Size = new System.Drawing.Size(472, 302);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Music Organizer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cMusicName
            // 
            this.cMusicName.AutoSize = true;
            this.cMusicName.Checked = true;
            this.cMusicName.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMusicName.Location = new System.Drawing.Point(287, 99);
            this.cMusicName.Margin = new System.Windows.Forms.Padding(2);
            this.cMusicName.Name = "cMusicName";
            this.cMusicName.Size = new System.Drawing.Size(160, 21);
            this.cMusicName.TabIndex = 7;
            this.cMusicName.Text = "Name from file name";
            this.cMusicName.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(174, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Artists (Sep. w/ semicolon)";
            // 
            // tMusicArtists
            // 
            this.tMusicArtists.Location = new System.Drawing.Point(22, 164);
            this.tMusicArtists.Margin = new System.Windows.Forms.Padding(2);
            this.tMusicArtists.Name = "tMusicArtists";
            this.tMusicArtists.Size = new System.Drawing.Size(244, 22);
            this.tMusicArtists.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(193, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 18;
            this.label4.Text = "Year";
            // 
            // tMusicYear
            // 
            this.tMusicYear.Location = new System.Drawing.Point(189, 101);
            this.tMusicYear.Margin = new System.Windows.Forms.Padding(2);
            this.tMusicYear.MaxLength = 4;
            this.tMusicYear.Name = "tMusicYear";
            this.tMusicYear.Size = new System.Drawing.Size(77, 22);
            this.tMusicYear.TabIndex = 4;
            this.tMusicYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tMusicYear_KeyPress);
            // 
            // cMusicComment
            // 
            this.cMusicComment.AutoSize = true;
            this.cMusicComment.Checked = true;
            this.cMusicComment.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMusicComment.Location = new System.Drawing.Point(287, 171);
            this.cMusicComment.Margin = new System.Windows.Forms.Padding(2);
            this.cMusicComment.Name = "cMusicComment";
            this.cMusicComment.Size = new System.Drawing.Size(133, 21);
            this.cMusicComment.TabIndex = 9;
            this.cMusicComment.Text = "Clear Comments";
            this.cMusicComment.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 210);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Genres (Sep. w/ semicolon)";
            // 
            // tMusicGenres
            // 
            this.tMusicGenres.Location = new System.Drawing.Point(22, 228);
            this.tMusicGenres.Margin = new System.Windows.Forms.Padding(2);
            this.tMusicGenres.Name = "tMusicGenres";
            this.tMusicGenres.Size = new System.Drawing.Size(244, 22);
            this.tMusicGenres.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Album";
            // 
            // tMusicAlbum
            // 
            this.tMusicAlbum.Location = new System.Drawing.Point(22, 101);
            this.tMusicAlbum.Margin = new System.Windows.Forms.Padding(2);
            this.tMusicAlbum.Name = "tMusicAlbum";
            this.tMusicAlbum.Size = new System.Drawing.Size(155, 22);
            this.tMusicAlbum.TabIndex = 3;
            // 
            // cMusicNumber
            // 
            this.cMusicNumber.AutoSize = true;
            this.cMusicNumber.Checked = true;
            this.cMusicNumber.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cMusicNumber.Location = new System.Drawing.Point(287, 136);
            this.cMusicNumber.Margin = new System.Windows.Forms.Padding(2);
            this.cMusicNumber.Name = "cMusicNumber";
            this.cMusicNumber.Size = new System.Drawing.Size(173, 21);
            this.cMusicNumber.TabIndex = 8;
            this.cMusicNumber.Text = "Number from file name";
            this.cMusicNumber.UseVisualStyleBackColor = true;
            // 
            // bMusicE
            // 
            this.bMusicE.Location = new System.Drawing.Point(387, 16);
            this.bMusicE.Margin = new System.Windows.Forms.Padding(2);
            this.bMusicE.Name = "bMusicE";
            this.bMusicE.Size = new System.Drawing.Size(74, 24);
            this.bMusicE.TabIndex = 10;
            this.bMusicE.Text = "Execute";
            this.bMusicE.UseVisualStyleBackColor = true;
            this.bMusicE.Click += new System.EventHandler(this.bMusicE_Click);
            // 
            // bMusic
            // 
            this.bMusic.Location = new System.Drawing.Point(270, 19);
            this.bMusic.Margin = new System.Windows.Forms.Padding(2);
            this.bMusic.Name = "bMusic";
            this.bMusic.Size = new System.Drawing.Size(67, 24);
            this.bMusic.TabIndex = 2;
            this.bMusic.Text = "Folder";
            this.bMusic.UseVisualStyleBackColor = true;
            this.bMusic.Click += new System.EventHandler(this.bMusic_Click);
            // 
            // tMusic
            // 
            this.tMusic.Location = new System.Drawing.Point(13, 20);
            this.tMusic.Margin = new System.Windows.Forms.Padding(2);
            this.tMusic.Name = "tMusic";
            this.tMusic.Size = new System.Drawing.Size(255, 22);
            this.tMusic.TabIndex = 1;
            this.tMusic.Click += new System.EventHandler(this.tMusic_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.bImageE);
            this.tabPage2.Controls.Add(this.bImage);
            this.tabPage2.Controls.Add(this.tImage);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(472, 302);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Image Converter";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cImageRemoveOrigin);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.lImageFrom);
            this.groupBox4.Controls.Add(this.bImageFrom);
            this.groupBox4.Controls.Add(this.tImageFrom);
            this.groupBox4.Controls.Add(this.cImageConvertTo);
            this.groupBox4.Controls.Add(this.cImageConvert);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(242, 47);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(219, 244);
            this.groupBox4.TabIndex = 20;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Image Converter";
            // 
            // cImageRemoveOrigin
            // 
            this.cImageRemoveOrigin.AutoSize = true;
            this.cImageRemoveOrigin.Enabled = false;
            this.cImageRemoveOrigin.Location = new System.Drawing.Point(30, 54);
            this.cImageRemoveOrigin.Name = "cImageRemoveOrigin";
            this.cImageRemoveOrigin.Size = new System.Drawing.Size(161, 21);
            this.cImageRemoveOrigin.TabIndex = 20;
            this.cImageRemoveOrigin.Text = "Remove Original File";
            this.cImageRemoveOrigin.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 17);
            this.label10.TabIndex = 13;
            this.label10.Text = "From";
            // 
            // lImageFrom
            // 
            this.lImageFrom.Enabled = false;
            this.lImageFrom.FormattingEnabled = true;
            this.lImageFrom.ItemHeight = 16;
            this.lImageFrom.Location = new System.Drawing.Point(80, 109);
            this.lImageFrom.Margin = new System.Windows.Forms.Padding(2);
            this.lImageFrom.Name = "lImageFrom";
            this.lImageFrom.Size = new System.Drawing.Size(124, 100);
            this.lImageFrom.TabIndex = 12;
            // 
            // bImageFrom
            // 
            this.bImageFrom.Enabled = false;
            this.bImageFrom.Location = new System.Drawing.Point(31, 186);
            this.bImageFrom.Margin = new System.Windows.Forms.Padding(2);
            this.bImageFrom.Name = "bImageFrom";
            this.bImageFrom.Size = new System.Drawing.Size(45, 24);
            this.bImageFrom.TabIndex = 11;
            this.bImageFrom.Text = "Add";
            this.bImageFrom.UseVisualStyleBackColor = true;
            this.bImageFrom.Click += new System.EventHandler(this.bImageFrom_Click);
            // 
            // tImageFrom
            // 
            this.tImageFrom.Enabled = false;
            this.tImageFrom.Location = new System.Drawing.Point(8, 160);
            this.tImageFrom.Margin = new System.Windows.Forms.Padding(2);
            this.tImageFrom.MaxLength = 5;
            this.tImageFrom.Name = "tImageFrom";
            this.tImageFrom.Size = new System.Drawing.Size(67, 22);
            this.tImageFrom.TabIndex = 10;
            // 
            // cImageConvertTo
            // 
            this.cImageConvertTo.Enabled = false;
            this.cImageConvertTo.FormattingEnabled = true;
            this.cImageConvertTo.Items.AddRange(new object[] {
            "GIF",
            "JPG",
            "JPEG",
            "PNG",
            "BMP"});
            this.cImageConvertTo.Location = new System.Drawing.Point(5, 114);
            this.cImageConvertTo.Name = "cImageConvertTo";
            this.cImageConvertTo.Size = new System.Drawing.Size(70, 24);
            this.cImageConvertTo.TabIndex = 2;
            // 
            // cImageConvert
            // 
            this.cImageConvert.AutoSize = true;
            this.cImageConvert.Location = new System.Drawing.Point(30, 27);
            this.cImageConvert.Name = "cImageConvert";
            this.cImageConvert.Size = new System.Drawing.Size(79, 21);
            this.cImageConvert.TabIndex = 1;
            this.cImageConvert.Text = "Convert";
            this.cImageConvert.UseVisualStyleBackColor = true;
            this.cImageConvert.CheckedChanged += new System.EventHandler(this.cImageConvert_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 92);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(25, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "To";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cImageResize);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.tImageMaxHeight);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.tImageMaxWidth);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.tImageMaxResize);
            this.groupBox3.Location = new System.Drawing.Point(13, 46);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(219, 245);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Image Resize";
            // 
            // cImageResize
            // 
            this.cImageResize.AutoSize = true;
            this.cImageResize.Location = new System.Drawing.Point(37, 24);
            this.cImageResize.Name = "cImageResize";
            this.cImageResize.Size = new System.Drawing.Size(73, 21);
            this.cImageResize.TabIndex = 19;
            this.cImageResize.Text = "Resize";
            this.cImageResize.UseVisualStyleBackColor = true;
            this.cImageResize.CheckedChanged += new System.EventHandler(this.cImageResize_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 168);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 17);
            this.label8.TabIndex = 17;
            this.label8.Text = "Max. Height (px)";
            // 
            // tImageMaxHeight
            // 
            this.tImageMaxHeight.Enabled = false;
            this.tImageMaxHeight.Location = new System.Drawing.Point(28, 188);
            this.tImageMaxHeight.MaxLength = 6;
            this.tImageMaxHeight.Name = "tImageMaxHeight";
            this.tImageMaxHeight.Size = new System.Drawing.Size(70, 22);
            this.tImageMaxHeight.TabIndex = 18;
            this.tImageMaxHeight.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tImageMaxHeight_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max. Width (px)";
            // 
            // tImageMaxWidth
            // 
            this.tImageMaxWidth.Enabled = false;
            this.tImageMaxWidth.Location = new System.Drawing.Point(28, 134);
            this.tImageMaxWidth.MaxLength = 6;
            this.tImageMaxWidth.Name = "tImageMaxWidth";
            this.tImageMaxWidth.Size = new System.Drawing.Size(70, 22);
            this.tImageMaxWidth.TabIndex = 16;
            this.tImageMaxWidth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tImageMaxWidth_KeyPress);
            // 
            // label6
            // 
            this.label6.AccessibleDescription = "";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 17);
            this.label6.TabIndex = 14;
            this.label6.Text = "Max. ReSize (%)";
            // 
            // tImageMaxResize
            // 
            this.tImageMaxResize.AccessibleDescription = "";
            this.tImageMaxResize.AccessibleName = "";
            this.tImageMaxResize.Enabled = false;
            this.tImageMaxResize.Location = new System.Drawing.Point(28, 79);
            this.tImageMaxResize.MaxLength = 3;
            this.tImageMaxResize.Name = "tImageMaxResize";
            this.tImageMaxResize.Size = new System.Drawing.Size(70, 22);
            this.tImageMaxResize.TabIndex = 14;
            this.tImageMaxResize.Tag = "";
            this.tImageMaxResize.Text = "20";
            this.tImageMaxResize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tImageMaxResize_KeyPress);
            // 
            // bImageE
            // 
            this.bImageE.Location = new System.Drawing.Point(387, 16);
            this.bImageE.Margin = new System.Windows.Forms.Padding(2);
            this.bImageE.Name = "bImageE";
            this.bImageE.Size = new System.Drawing.Size(74, 24);
            this.bImageE.TabIndex = 12;
            this.bImageE.Text = "Execute";
            this.bImageE.UseVisualStyleBackColor = true;
            this.bImageE.Click += new System.EventHandler(this.bImageE_Click);
            // 
            // bImage
            // 
            this.bImage.Location = new System.Drawing.Point(270, 19);
            this.bImage.Margin = new System.Windows.Forms.Padding(2);
            this.bImage.Name = "bImage";
            this.bImage.Size = new System.Drawing.Size(67, 24);
            this.bImage.TabIndex = 11;
            this.bImage.Text = "Folder";
            this.bImage.UseVisualStyleBackColor = true;
            this.bImage.Click += new System.EventHandler(this.bImage_Click);
            // 
            // tImage
            // 
            this.tImage.Location = new System.Drawing.Point(13, 20);
            this.tImage.Margin = new System.Windows.Forms.Padding(2);
            this.tImage.Name = "tImage";
            this.tImage.Size = new System.Drawing.Size(255, 22);
            this.tImage.TabIndex = 10;
            this.tImage.Click += new System.EventHandler(this.tImage_Click);
            // 
            // cKeepAll
            // 
            this.cKeepAll.AutoSize = true;
            this.cKeepAll.Location = new System.Drawing.Point(469, 13);
            this.cKeepAll.Name = "cKeepAll";
            this.cKeepAll.Size = new System.Drawing.Size(18, 17);
            this.cKeepAll.TabIndex = 15;
            this.cKeepAll.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 353);
            this.Controls.Add(this.cKeepAll);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 400);
            this.MinimumSize = new System.Drawing.Size(520, 400);
            this.Name = "Form1";
            this.Text = "File Master";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button bRenamer;
        private System.Windows.Forms.TextBox tRenamer;
        private System.Windows.Forms.Button bRemove;
        private System.Windows.Forms.TextBox tRemove;
        private System.Windows.Forms.ListBox lRemove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox lReplace;
        private System.Windows.Forms.Button bReplace;
        private System.Windows.Forms.TextBox tReplace1;
        private System.Windows.Forms.Button bRenamerS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tReplace2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button bMusicE;
        private System.Windows.Forms.Button bMusic;
        private System.Windows.Forms.TextBox tMusic;
        private System.Windows.Forms.CheckBox cMusicNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tMusicGenres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tMusicAlbum;
        private System.Windows.Forms.CheckBox cMusicComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tMusicYear;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tMusicArtists;
        private System.Windows.Forms.CheckBox cMusicName;
        private System.Windows.Forms.Button bImageE;
        private System.Windows.Forms.Button bImage;
        private System.Windows.Forms.TextBox tImage;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tImageMaxResize;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tImageMaxHeight;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tImageMaxWidth;
        private System.Windows.Forms.CheckBox cImageResize;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox cImageConvert;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cImageConvertTo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListBox lImageFrom;
        private System.Windows.Forms.Button bImageFrom;
        private System.Windows.Forms.TextBox tImageFrom;
        private System.Windows.Forms.CheckBox cImageRemoveOrigin;
        private System.Windows.Forms.CheckBox cKeepAll;
        private System.Windows.Forms.ComboBox cCase;
        private System.Windows.Forms.TextBox tStartWith;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tEndWith;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}

