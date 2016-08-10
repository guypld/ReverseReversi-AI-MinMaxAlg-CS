namespace ReverseReversi
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCVsPlayerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.playerStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCStartsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pCVsPCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BoardContainer = new System.Windows.Forms.PictureBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblWhiteCount = new System.Windows.Forms.Label();
            this.lblBlackCount = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.PC1W6Text = new System.Windows.Forms.NumericUpDown();
            this.label18 = new System.Windows.Forms.Label();
            this.PC1W5Text = new System.Windows.Forms.NumericUpDown();
            this.PC1DepthText = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PC1W4Text = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.PC1W3Text = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.PC1W2Text = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PC1W1Text = new System.Windows.Forms.NumericUpDown();
            this.PC1AlgoCombo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.PC2W6Text = new System.Windows.Forms.NumericUpDown();
            this.label20 = new System.Windows.Forms.Label();
            this.PC2W5Text = new System.Windows.Forms.NumericUpDown();
            this.PC2DepthText = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.PC2W4Text = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.PC2W3Text = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.PC2W2Text = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PC2W1Text = new System.Windows.Forms.NumericUpDown();
            this.PC2AlgoCombo = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.picLetters = new System.Windows.Forms.PictureBox();
            this.picDigits = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardContainer)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W6Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W5Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1DepthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W4Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W3Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W2Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W1Text)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W6Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W5Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2DepthText)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W4Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W3Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W2Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W1Text)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLetters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDigits)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "board.png");
            this.imageList.Images.SetKeyName(1, "white.png");
            this.imageList.Images.SetKeyName(2, "black.png");
            this.imageList.Images.SetKeyName(3, "move.png");
            this.imageList.Images.SetKeyName(4, "pc_move.png");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(711, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameToolStripMenuItem
            // 
            this.gameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exityToolStripMenuItem});
            this.gameToolStripMenuItem.Name = "gameToolStripMenuItem";
            this.gameToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameToolStripMenuItem.Text = "Game";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerVsPlayerToolStripMenuItem,
            this.pCVsPlayerToolStripMenuItem,
            this.pCVsPCToolStripMenuItem});
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            // 
            // playerVsPlayerToolStripMenuItem
            // 
            this.playerVsPlayerToolStripMenuItem.Name = "playerVsPlayerToolStripMenuItem";
            this.playerVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.playerVsPlayerToolStripMenuItem.Text = "Player vs Player";
            this.playerVsPlayerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // pCVsPlayerToolStripMenuItem
            // 
            this.pCVsPlayerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.playerStartsToolStripMenuItem,
            this.pCStartsToolStripMenuItem});
            this.pCVsPlayerToolStripMenuItem.Name = "pCVsPlayerToolStripMenuItem";
            this.pCVsPlayerToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pCVsPlayerToolStripMenuItem.Text = "PC vs Player";
            // 
            // playerStartsToolStripMenuItem
            // 
            this.playerStartsToolStripMenuItem.Name = "playerStartsToolStripMenuItem";
            this.playerStartsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.playerStartsToolStripMenuItem.Text = "Player Starts";
            this.playerStartsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // pCStartsToolStripMenuItem
            // 
            this.pCStartsToolStripMenuItem.Name = "pCStartsToolStripMenuItem";
            this.pCStartsToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.pCStartsToolStripMenuItem.Text = "PC Starts";
            this.pCStartsToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // pCVsPCToolStripMenuItem
            // 
            this.pCVsPCToolStripMenuItem.Name = "pCVsPCToolStripMenuItem";
            this.pCVsPCToolStripMenuItem.Size = new System.Drawing.Size(155, 22);
            this.pCVsPCToolStripMenuItem.Text = "PC vs PC";
            this.pCVsPCToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(129, 6);
            // 
            // exityToolStripMenuItem
            // 
            this.exityToolStripMenuItem.Name = "exityToolStripMenuItem";
            this.exityToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.exityToolStripMenuItem.Text = "Exit";
            this.exityToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuItem_Click);
            // 
            // BoardContainer
            // 
            this.BoardContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BoardContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.BoardContainer.Location = new System.Drawing.Point(21, 43);
            this.BoardContainer.Name = "BoardContainer";
            this.BoardContainer.Size = new System.Drawing.Size(404, 404);
            this.BoardContainer.TabIndex = 1;
            this.BoardContainer.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 458);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(711, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(42, 17);
            this.toolStripStatusLabel1.Text = "Status:";
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(41, 17);
            this.lblStatus.Text = "offline";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(431, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "White:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(431, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 31);
            this.label2.TabIndex = 4;
            this.label2.Text = "Black:";
            // 
            // lblWhiteCount
            // 
            this.lblWhiteCount.AutoSize = true;
            this.lblWhiteCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblWhiteCount.Location = new System.Drawing.Point(521, 43);
            this.lblWhiteCount.Name = "lblWhiteCount";
            this.lblWhiteCount.Size = new System.Drawing.Size(29, 31);
            this.lblWhiteCount.TabIndex = 5;
            this.lblWhiteCount.Text = "0";
            // 
            // lblBlackCount
            // 
            this.lblBlackCount.AutoSize = true;
            this.lblBlackCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.lblBlackCount.Location = new System.Drawing.Point(521, 82);
            this.lblBlackCount.Name = "lblBlackCount";
            this.lblBlackCount.Size = new System.Drawing.Size(29, 31);
            this.lblBlackCount.TabIndex = 6;
            this.lblBlackCount.Text = "0";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.PC1W6Text);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.PC1W5Text);
            this.groupBox1.Controls.Add(this.PC1DepthText);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PC1W4Text);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PC1W3Text);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PC1W2Text);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.PC1W1Text);
            this.groupBox1.Controls.Add(this.PC1AlgoCombo);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(437, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 163);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "PC-1 Settings";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(157, 127);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(43, 13);
            this.label17.TabIndex = 23;
            this.label17.Text = "Corners";
            // 
            // PC1W6Text
            // 
            this.PC1W6Text.Location = new System.Drawing.Point(219, 125);
            this.PC1W6Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC1W6Text.Name = "PC1W6Text";
            this.PC1W6Text.ReadOnly = true;
            this.PC1W6Text.Size = new System.Drawing.Size(35, 20);
            this.PC1W6Text.TabIndex = 22;
            this.PC1W6Text.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(25, 127);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 13);
            this.label18.TabIndex = 21;
            this.label18.Text = "Stability";
            // 
            // PC1W5Text
            // 
            this.PC1W5Text.Location = new System.Drawing.Point(87, 125);
            this.PC1W5Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC1W5Text.Name = "PC1W5Text";
            this.PC1W5Text.ReadOnly = true;
            this.PC1W5Text.Size = new System.Drawing.Size(35, 20);
            this.PC1W5Text.TabIndex = 20;
            this.PC1W5Text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PC1DepthText
            // 
            this.PC1DepthText.Location = new System.Drawing.Point(216, 23);
            this.PC1DepthText.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.PC1DepthText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PC1DepthText.Name = "PC1DepthText";
            this.PC1DepthText.ReadOnly = true;
            this.PC1DepthText.Size = new System.Drawing.Size(35, 20);
            this.PC1DepthText.TabIndex = 19;
            this.PC1DepthText.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Depth:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(157, 101);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "AvailMoves";
            // 
            // PC1W4Text
            // 
            this.PC1W4Text.Location = new System.Drawing.Point(219, 99);
            this.PC1W4Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC1W4Text.Name = "PC1W4Text";
            this.PC1W4Text.ReadOnly = true;
            this.PC1W4Text.Size = new System.Drawing.Size(35, 20);
            this.PC1W4Text.TabIndex = 16;
            this.PC1W4Text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(157, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Weights";
            // 
            // PC1W3Text
            // 
            this.PC1W3Text.Location = new System.Drawing.Point(219, 76);
            this.PC1W3Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC1W3Text.Name = "PC1W3Text";
            this.PC1W3Text.ReadOnly = true;
            this.PC1W3Text.Size = new System.Drawing.Size(35, 20);
            this.PC1W3Text.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Mobility";
            // 
            // PC1W2Text
            // 
            this.PC1W2Text.Location = new System.Drawing.Point(87, 101);
            this.PC1W2Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC1W2Text.Name = "PC1W2Text";
            this.PC1W2Text.ReadOnly = true;
            this.PC1W2Text.Size = new System.Drawing.Size(35, 20);
            this.PC1W2Text.TabIndex = 12;
            this.PC1W2Text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "ColorRatio";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Weights:";
            // 
            // PC1W1Text
            // 
            this.PC1W1Text.Location = new System.Drawing.Point(87, 78);
            this.PC1W1Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC1W1Text.Name = "PC1W1Text";
            this.PC1W1Text.ReadOnly = true;
            this.PC1W1Text.Size = new System.Drawing.Size(35, 20);
            this.PC1W1Text.TabIndex = 9;
            this.PC1W1Text.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // PC1AlgoCombo
            // 
            this.PC1AlgoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PC1AlgoCombo.FormattingEnabled = true;
            this.PC1AlgoCombo.Location = new System.Drawing.Point(69, 23);
            this.PC1AlgoCombo.Name = "PC1AlgoCombo";
            this.PC1AlgoCombo.Size = new System.Drawing.Size(106, 21);
            this.PC1AlgoCombo.TabIndex = 1;
            this.PC1AlgoCombo.SelectedValueChanged += new System.EventHandler(this.PC1AlgoCombo_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Algorithm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.PC2W6Text);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.PC2W5Text);
            this.groupBox2.Controls.Add(this.PC2DepthText);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.PC2W4Text);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.PC2W3Text);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.PC2W2Text);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.PC2W1Text);
            this.groupBox2.Controls.Add(this.PC2AlgoCombo);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Location = new System.Drawing.Point(437, 292);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(264, 163);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "PC-2 Settings";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(157, 133);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Corners";
            // 
            // PC2W6Text
            // 
            this.PC2W6Text.Location = new System.Drawing.Point(216, 131);
            this.PC2W6Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC2W6Text.Name = "PC2W6Text";
            this.PC2W6Text.ReadOnly = true;
            this.PC2W6Text.Size = new System.Drawing.Size(35, 20);
            this.PC2W6Text.TabIndex = 22;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(25, 131);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 13);
            this.label20.TabIndex = 21;
            this.label20.Text = "Stability";
            // 
            // PC2W5Text
            // 
            this.PC2W5Text.Location = new System.Drawing.Point(87, 129);
            this.PC2W5Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC2W5Text.Name = "PC2W5Text";
            this.PC2W5Text.ReadOnly = true;
            this.PC2W5Text.Size = new System.Drawing.Size(35, 20);
            this.PC2W5Text.TabIndex = 20;
            // 
            // PC2DepthText
            // 
            this.PC2DepthText.Location = new System.Drawing.Point(216, 28);
            this.PC2DepthText.Maximum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.PC2DepthText.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.PC2DepthText.Name = "PC2DepthText";
            this.PC2DepthText.ReadOnly = true;
            this.PC2DepthText.Size = new System.Drawing.Size(35, 20);
            this.PC2DepthText.TabIndex = 19;
            this.PC2DepthText.Value = new decimal(new int[] {
            7,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(180, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 13);
            this.label10.TabIndex = 18;
            this.label10.Text = "Depth:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(154, 107);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(62, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "AvailMoves";
            // 
            // PC2W4Text
            // 
            this.PC2W4Text.Location = new System.Drawing.Point(216, 105);
            this.PC2W4Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC2W4Text.Name = "PC2W4Text";
            this.PC2W4Text.ReadOnly = true;
            this.PC2W4Text.Size = new System.Drawing.Size(35, 20);
            this.PC2W4Text.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(154, 84);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Weights";
            // 
            // PC2W3Text
            // 
            this.PC2W3Text.Location = new System.Drawing.Point(216, 82);
            this.PC2W3Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC2W3Text.Name = "PC2W3Text";
            this.PC2W3Text.ReadOnly = true;
            this.PC2W3Text.Size = new System.Drawing.Size(35, 20);
            this.PC2W3Text.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(25, 105);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Mobility";
            // 
            // PC2W2Text
            // 
            this.PC2W2Text.Location = new System.Drawing.Point(87, 105);
            this.PC2W2Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC2W2Text.Name = "PC2W2Text";
            this.PC2W2Text.ReadOnly = true;
            this.PC2W2Text.Size = new System.Drawing.Size(35, 20);
            this.PC2W2Text.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(25, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "ColorRatio";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(10, 60);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(49, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Weights:";
            // 
            // PC2W1Text
            // 
            this.PC2W1Text.Location = new System.Drawing.Point(87, 82);
            this.PC2W1Text.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.PC2W1Text.Name = "PC2W1Text";
            this.PC2W1Text.ReadOnly = true;
            this.PC2W1Text.Size = new System.Drawing.Size(35, 20);
            this.PC2W1Text.TabIndex = 9;
            // 
            // PC2AlgoCombo
            // 
            this.PC2AlgoCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PC2AlgoCombo.FormattingEnabled = true;
            this.PC2AlgoCombo.Location = new System.Drawing.Point(69, 28);
            this.PC2AlgoCombo.Name = "PC2AlgoCombo";
            this.PC2AlgoCombo.Size = new System.Drawing.Size(106, 21);
            this.PC2AlgoCombo.TabIndex = 1;
            this.PC2AlgoCombo.SelectedValueChanged += new System.EventHandler(this.PC2AlgoCombo_SelectedValueChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(10, 31);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(53, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Algorithm:";
            // 
            // picLetters
            // 
            this.picLetters.Location = new System.Drawing.Point(21, 27);
            this.picLetters.Name = "picLetters";
            this.picLetters.Size = new System.Drawing.Size(404, 16);
            this.picLetters.TabIndex = 9;
            this.picLetters.TabStop = false;
            // 
            // picDigits
            // 
            this.picDigits.Location = new System.Drawing.Point(5, 43);
            this.picDigits.Name = "picDigits";
            this.picDigits.Size = new System.Drawing.Size(15, 404);
            this.picDigits.TabIndex = 10;
            this.picDigits.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 480);
            this.Controls.Add(this.picDigits);
            this.Controls.Add(this.picLetters);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBlackCount);
            this.Controls.Add(this.lblWhiteCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.BoardContainer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Reverse Reversi - A.I";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BoardContainer)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W6Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W5Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1DepthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W4Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W3Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W2Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC1W1Text)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W6Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W5Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2DepthText)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W4Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W3Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W2Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PC2W1Text)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLetters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDigits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem playerVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCVsPlayerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCVsPCToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.PictureBox BoardContainer;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
        private System.Windows.Forms.ToolStripMenuItem playerStartsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pCStartsToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblWhiteCount;
        private System.Windows.Forms.Label lblBlackCount;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PC1AlgoCombo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown PC1W1Text;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown PC1W4Text;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown PC1W3Text;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown PC1W2Text;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown PC1DepthText;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown PC2DepthText;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown PC2W4Text;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.NumericUpDown PC2W3Text;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown PC2W2Text;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown PC2W1Text;
        private System.Windows.Forms.ComboBox PC2AlgoCombo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown PC1W6Text;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.NumericUpDown PC1W5Text;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.NumericUpDown PC2W6Text;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.NumericUpDown PC2W5Text;
        private System.Windows.Forms.PictureBox picLetters;
        private System.Windows.Forms.PictureBox picDigits;
    }
}

