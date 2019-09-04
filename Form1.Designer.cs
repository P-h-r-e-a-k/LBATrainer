﻿namespace LBATrainer
{
    partial class frmTrainer
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
            this.tcLBAVersion = new System.Windows.Forms.TabControl();
            this.tpLBA1 = new System.Windows.Forms.TabPage();
            this.tcLBA1Inner = new System.Windows.Forms.TabControl();
            this.tpLBA1Twinsen = new System.Windows.Forms.TabPage();
            this.chkLBA1InventoryValue = new System.Windows.Forms.CheckBox();
            this.btnLBA1Set = new System.Windows.Forms.Button();
            this.lblLBA1MagicLevel = new System.Windows.Forms.Label();
            this.txtLBA1MagicLevel = new System.Windows.Forms.TextBox();
            this.txtLBA1Keys = new System.Windows.Forms.TextBox();
            this.lblKeys = new System.Windows.Forms.Label();
            this.txtLBA1Gas = new System.Windows.Forms.TextBox();
            this.txtLBA1Kashers = new System.Windows.Forms.TextBox();
            this.txtLBA1MagicPoints = new System.Windows.Forms.TextBox();
            this.btnLBA1MinAll = new System.Windows.Forms.Button();
            this.btnLBA1Scan = new System.Windows.Forms.Button();
            this.lblLBA1Gas = new System.Windows.Forms.Label();
            this.txtLBA1Health = new System.Windows.Forms.TextBox();
            this.cboLBA1Inventory = new System.Windows.Forms.ComboBox();
            this.lblLBA1Inventory = new System.Windows.Forms.Label();
            this.lblLBA1Kashers = new System.Windows.Forms.Label();
            this.lblLBA1MagicPoints = new System.Windows.Forms.Label();
            this.lblLBA1Health = new System.Windows.Forms.Label();
            this.lblLBA1CloverBoxes = new System.Windows.Forms.Label();
            this.txtLBA1CloverBoxes = new System.Windows.Forms.TextBox();
            this.btnLBA1MaxAll = new System.Windows.Forms.Button();
            this.lblLBA1Clovers = new System.Windows.Forms.Label();
            this.txtLBA1Clovers = new System.Windows.Forms.TextBox();
            this.tpLBA1Other = new System.Windows.Forms.TabPage();
            this.chkLBA1MoviesValue = new System.Windows.Forms.CheckBox();
            this.cboLBA1Movies = new System.Windows.Forms.ComboBox();
            this.lblLBA1Movies = new System.Windows.Forms.Label();
            this.chkLBA1QuestValue = new System.Windows.Forms.CheckBox();
            this.cboLBA1Quest = new System.Windows.Forms.ComboBox();
            this.lblLBA1Quest = new System.Windows.Forms.Label();
            this.tbLBA2 = new System.Windows.Forms.TabPage();
            this.tcLBA2Twinsen = new System.Windows.Forms.TabControl();
            this.tpLBA2Twinsen = new System.Windows.Forms.TabPage();
            this.cboLBA2Inventory = new System.Windows.Forms.ComboBox();
            this.lblLBA2Inventory = new System.Windows.Forms.Label();
            this.txtLBA2Zilitos = new System.Windows.Forms.TextBox();
            this.lblLBA2Zilitos = new System.Windows.Forms.Label();
            this.txtLBA2Keys = new System.Windows.Forms.TextBox();
            this.lblLBA2Keys = new System.Windows.Forms.Label();
            this.lblLBA2MagicLevel = new System.Windows.Forms.Label();
            this.txtLBA2MagicLevel = new System.Windows.Forms.TextBox();
            this.btnLBA2TwinsenSet = new System.Windows.Forms.Button();
            this.txtLBA2Kashers = new System.Windows.Forms.TextBox();
            this.txtLBA2MagicPoints = new System.Windows.Forms.TextBox();
            this.btnLBA2MinAll = new System.Windows.Forms.Button();
            this.btnLBA2Scan = new System.Windows.Forms.Button();
            this.txtLBA2Health = new System.Windows.Forms.TextBox();
            this.lblLBA2Kashers = new System.Windows.Forms.Label();
            this.lblLBA2MagicPoints = new System.Windows.Forms.Label();
            this.lblLBA2Health = new System.Windows.Forms.Label();
            this.lblLBA2CloverBoxes = new System.Windows.Forms.Label();
            this.txtLBA2CloverBoxes = new System.Windows.Forms.TextBox();
            this.btnLBA2MaxAll = new System.Windows.Forms.Button();
            this.lblLBA2Clovers = new System.Windows.Forms.Label();
            this.txtLBA2Clovers = new System.Windows.Forms.TextBox();
            this.tcLBAVersion.SuspendLayout();
            this.tpLBA1.SuspendLayout();
            this.tcLBA1Inner.SuspendLayout();
            this.tpLBA1Twinsen.SuspendLayout();
            this.tpLBA1Other.SuspendLayout();
            this.tbLBA2.SuspendLayout();
            this.tcLBA2Twinsen.SuspendLayout();
            this.tpLBA2Twinsen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcLBAVersion
            // 
            this.tcLBAVersion.Controls.Add(this.tpLBA1);
            this.tcLBAVersion.Controls.Add(this.tbLBA2);
            this.tcLBAVersion.Location = new System.Drawing.Point(5, 2);
            this.tcLBAVersion.Name = "tcLBAVersion";
            this.tcLBAVersion.SelectedIndex = 0;
            this.tcLBAVersion.Size = new System.Drawing.Size(357, 235);
            this.tcLBAVersion.TabIndex = 7;
            this.tcLBAVersion.SelectedIndexChanged += new System.EventHandler(this.TcLBAVersion_SelectedIndexChanged);
            // 
            // tpLBA1
            // 
            this.tpLBA1.BackColor = System.Drawing.SystemColors.Control;
            this.tpLBA1.Controls.Add(this.tcLBA1Inner);
            this.tpLBA1.Location = new System.Drawing.Point(4, 22);
            this.tpLBA1.Name = "tpLBA1";
            this.tpLBA1.Padding = new System.Windows.Forms.Padding(3);
            this.tpLBA1.Size = new System.Drawing.Size(349, 209);
            this.tpLBA1.TabIndex = 0;
            this.tpLBA1.Text = "LBA1";
            // 
            // tcLBA1Inner
            // 
            this.tcLBA1Inner.Controls.Add(this.tpLBA1Twinsen);
            this.tcLBA1Inner.Controls.Add(this.tpLBA1Other);
            this.tcLBA1Inner.Location = new System.Drawing.Point(6, 6);
            this.tcLBA1Inner.Name = "tcLBA1Inner";
            this.tcLBA1Inner.SelectedIndex = 0;
            this.tcLBA1Inner.Size = new System.Drawing.Size(342, 204);
            this.tcLBA1Inner.TabIndex = 21;
            this.tcLBA1Inner.SelectedIndexChanged += new System.EventHandler(this.TcLBA1Inner_SelectedIndexChanged);
            // 
            // tpLBA1Twinsen
            // 
            this.tpLBA1Twinsen.BackColor = System.Drawing.Color.MistyRose;
            this.tpLBA1Twinsen.Controls.Add(this.chkLBA1InventoryValue);
            this.tpLBA1Twinsen.Controls.Add(this.btnLBA1Set);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1MagicLevel);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1MagicLevel);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1Keys);
            this.tpLBA1Twinsen.Controls.Add(this.lblKeys);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1Gas);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1Kashers);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1MagicPoints);
            this.tpLBA1Twinsen.Controls.Add(this.btnLBA1MinAll);
            this.tpLBA1Twinsen.Controls.Add(this.btnLBA1Scan);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1Gas);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1Health);
            this.tpLBA1Twinsen.Controls.Add(this.cboLBA1Inventory);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1Inventory);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1Kashers);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1MagicPoints);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1Health);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1CloverBoxes);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1CloverBoxes);
            this.tpLBA1Twinsen.Controls.Add(this.btnLBA1MaxAll);
            this.tpLBA1Twinsen.Controls.Add(this.lblLBA1Clovers);
            this.tpLBA1Twinsen.Controls.Add(this.txtLBA1Clovers);
            this.tpLBA1Twinsen.Location = new System.Drawing.Point(4, 22);
            this.tpLBA1Twinsen.Name = "tpLBA1Twinsen";
            this.tpLBA1Twinsen.Padding = new System.Windows.Forms.Padding(3);
            this.tpLBA1Twinsen.Size = new System.Drawing.Size(334, 178);
            this.tpLBA1Twinsen.TabIndex = 0;
            this.tpLBA1Twinsen.Text = "Twinsen";
            // 
            // chkLBA1InventoryValue
            // 
            this.chkLBA1InventoryValue.AutoSize = true;
            this.chkLBA1InventoryValue.Location = new System.Drawing.Point(284, 116);
            this.chkLBA1InventoryValue.Name = "chkLBA1InventoryValue";
            this.chkLBA1InventoryValue.Size = new System.Drawing.Size(15, 14);
            this.chkLBA1InventoryValue.TabIndex = 38;
            this.chkLBA1InventoryValue.UseVisualStyleBackColor = true;
            this.chkLBA1InventoryValue.CheckedChanged += new System.EventHandler(this.ChkLBA1InventoryValue_CheckedChanged);
            // 
            // btnLBA1Set
            // 
            this.btnLBA1Set.Location = new System.Drawing.Point(24, 144);
            this.btnLBA1Set.Name = "btnLBA1Set";
            this.btnLBA1Set.Size = new System.Drawing.Size(63, 23);
            this.btnLBA1Set.TabIndex = 11;
            this.btnLBA1Set.Text = "Set";
            this.btnLBA1Set.UseVisualStyleBackColor = true;
            this.btnLBA1Set.Click += new System.EventHandler(this.BtnLBA1Set_Click);
            // 
            // lblLBA1MagicLevel
            // 
            this.lblLBA1MagicLevel.AutoSize = true;
            this.lblLBA1MagicLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1MagicLevel.Location = new System.Drawing.Point(6, 38);
            this.lblLBA1MagicLevel.Name = "lblLBA1MagicLevel";
            this.lblLBA1MagicLevel.Size = new System.Drawing.Size(76, 13);
            this.lblLBA1MagicLevel.TabIndex = 27;
            this.lblLBA1MagicLevel.Text = "Magic Level";
            // 
            // txtLBA1MagicLevel
            // 
            this.txtLBA1MagicLevel.Location = new System.Drawing.Point(106, 35);
            this.txtLBA1MagicLevel.Name = "txtLBA1MagicLevel";
            this.txtLBA1MagicLevel.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1MagicLevel.TabIndex = 3;
            // 
            // txtLBA1Keys
            // 
            this.txtLBA1Keys.Location = new System.Drawing.Point(284, 61);
            this.txtLBA1Keys.Name = "txtLBA1Keys";
            this.txtLBA1Keys.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1Keys.TabIndex = 6;
            // 
            // lblKeys
            // 
            this.lblKeys.AutoSize = true;
            this.lblKeys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKeys.Location = new System.Drawing.Point(197, 64);
            this.lblKeys.Name = "lblKeys";
            this.lblKeys.Size = new System.Drawing.Size(34, 13);
            this.lblKeys.TabIndex = 37;
            this.lblKeys.Text = "Keys";
            // 
            // txtLBA1Gas
            // 
            this.txtLBA1Gas.Location = new System.Drawing.Point(284, 88);
            this.txtLBA1Gas.Name = "txtLBA1Gas";
            this.txtLBA1Gas.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1Gas.TabIndex = 8;
            // 
            // txtLBA1Kashers
            // 
            this.txtLBA1Kashers.Location = new System.Drawing.Point(106, 88);
            this.txtLBA1Kashers.Name = "txtLBA1Kashers";
            this.txtLBA1Kashers.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1Kashers.TabIndex = 7;
            // 
            // txtLBA1MagicPoints
            // 
            this.txtLBA1MagicPoints.Location = new System.Drawing.Point(284, 35);
            this.txtLBA1MagicPoints.Name = "txtLBA1MagicPoints";
            this.txtLBA1MagicPoints.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1MagicPoints.TabIndex = 4;
            // 
            // btnLBA1MinAll
            // 
            this.btnLBA1MinAll.Location = new System.Drawing.Point(231, 144);
            this.btnLBA1MinAll.Name = "btnLBA1MinAll";
            this.btnLBA1MinAll.Size = new System.Drawing.Size(63, 23);
            this.btnLBA1MinAll.TabIndex = 14;
            this.btnLBA1MinAll.Text = "Min All";
            this.btnLBA1MinAll.UseVisualStyleBackColor = true;
            this.btnLBA1MinAll.Click += new System.EventHandler(this.BtnLBA1MinAll_Click);
            // 
            // btnLBA1Scan
            // 
            this.btnLBA1Scan.Location = new System.Drawing.Point(93, 144);
            this.btnLBA1Scan.Name = "btnLBA1Scan";
            this.btnLBA1Scan.Size = new System.Drawing.Size(63, 23);
            this.btnLBA1Scan.TabIndex = 12;
            this.btnLBA1Scan.Text = "Scan";
            this.btnLBA1Scan.UseVisualStyleBackColor = true;
            this.btnLBA1Scan.Click += new System.EventHandler(this.BtnLBA1Scan_Click);
            // 
            // lblLBA1Gas
            // 
            this.lblLBA1Gas.AutoSize = true;
            this.lblLBA1Gas.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Gas.Location = new System.Drawing.Point(197, 91);
            this.lblLBA1Gas.Name = "lblLBA1Gas";
            this.lblLBA1Gas.Size = new System.Drawing.Size(29, 13);
            this.lblLBA1Gas.TabIndex = 30;
            this.lblLBA1Gas.Text = "Gas";
            // 
            // txtLBA1Health
            // 
            this.txtLBA1Health.Location = new System.Drawing.Point(106, 61);
            this.txtLBA1Health.Name = "txtLBA1Health";
            this.txtLBA1Health.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1Health.TabIndex = 5;
            // 
            // cboLBA1Inventory
            // 
            this.cboLBA1Inventory.FormattingEnabled = true;
            this.cboLBA1Inventory.Location = new System.Drawing.Point(106, 114);
            this.cboLBA1Inventory.Name = "cboLBA1Inventory";
            this.cboLBA1Inventory.Size = new System.Drawing.Size(171, 21);
            this.cboLBA1Inventory.TabIndex = 9;
            this.cboLBA1Inventory.SelectedIndexChanged += new System.EventHandler(this.CboLBA1Inventory_SelectedIndexChanged);
            // 
            // lblLBA1Inventory
            // 
            this.lblLBA1Inventory.AutoSize = true;
            this.lblLBA1Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Inventory.Location = new System.Drawing.Point(6, 117);
            this.lblLBA1Inventory.Name = "lblLBA1Inventory";
            this.lblLBA1Inventory.Size = new System.Drawing.Size(60, 13);
            this.lblLBA1Inventory.TabIndex = 24;
            this.lblLBA1Inventory.Text = "Inventory";
            // 
            // lblLBA1Kashers
            // 
            this.lblLBA1Kashers.AutoSize = true;
            this.lblLBA1Kashers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Kashers.Location = new System.Drawing.Point(6, 91);
            this.lblLBA1Kashers.Name = "lblLBA1Kashers";
            this.lblLBA1Kashers.Size = new System.Drawing.Size(52, 13);
            this.lblLBA1Kashers.TabIndex = 23;
            this.lblLBA1Kashers.Text = "Kashers";
            // 
            // lblLBA1MagicPoints
            // 
            this.lblLBA1MagicPoints.AutoSize = true;
            this.lblLBA1MagicPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1MagicPoints.Location = new System.Drawing.Point(197, 38);
            this.lblLBA1MagicPoints.Name = "lblLBA1MagicPoints";
            this.lblLBA1MagicPoints.Size = new System.Drawing.Size(80, 13);
            this.lblLBA1MagicPoints.TabIndex = 22;
            this.lblLBA1MagicPoints.Text = "Magic Points";
            // 
            // lblLBA1Health
            // 
            this.lblLBA1Health.AutoSize = true;
            this.lblLBA1Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Health.Location = new System.Drawing.Point(6, 64);
            this.lblLBA1Health.Name = "lblLBA1Health";
            this.lblLBA1Health.Size = new System.Drawing.Size(44, 13);
            this.lblLBA1Health.TabIndex = 21;
            this.lblLBA1Health.Text = "Health";
            // 
            // lblLBA1CloverBoxes
            // 
            this.lblLBA1CloverBoxes.AutoSize = true;
            this.lblLBA1CloverBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1CloverBoxes.Location = new System.Drawing.Point(6, 12);
            this.lblLBA1CloverBoxes.Name = "lblLBA1CloverBoxes";
            this.lblLBA1CloverBoxes.Size = new System.Drawing.Size(81, 13);
            this.lblLBA1CloverBoxes.TabIndex = 14;
            this.lblLBA1CloverBoxes.Text = "Clover Boxes";
            // 
            // txtLBA1CloverBoxes
            // 
            this.txtLBA1CloverBoxes.BackColor = System.Drawing.SystemColors.Window;
            this.txtLBA1CloverBoxes.Location = new System.Drawing.Point(106, 9);
            this.txtLBA1CloverBoxes.Name = "txtLBA1CloverBoxes";
            this.txtLBA1CloverBoxes.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1CloverBoxes.TabIndex = 1;
            // 
            // btnLBA1MaxAll
            // 
            this.btnLBA1MaxAll.Location = new System.Drawing.Point(162, 144);
            this.btnLBA1MaxAll.Name = "btnLBA1MaxAll";
            this.btnLBA1MaxAll.Size = new System.Drawing.Size(63, 23);
            this.btnLBA1MaxAll.TabIndex = 13;
            this.btnLBA1MaxAll.Text = "Max All";
            this.btnLBA1MaxAll.UseVisualStyleBackColor = true;
            this.btnLBA1MaxAll.Click += new System.EventHandler(this.BtnLBA1MaxAll_Click);
            // 
            // lblLBA1Clovers
            // 
            this.lblLBA1Clovers.AutoSize = true;
            this.lblLBA1Clovers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Clovers.Location = new System.Drawing.Point(197, 12);
            this.lblLBA1Clovers.Name = "lblLBA1Clovers";
            this.lblLBA1Clovers.Size = new System.Drawing.Size(49, 13);
            this.lblLBA1Clovers.TabIndex = 17;
            this.lblLBA1Clovers.Text = "Clovers";
            // 
            // txtLBA1Clovers
            // 
            this.txtLBA1Clovers.Location = new System.Drawing.Point(284, 9);
            this.txtLBA1Clovers.Name = "txtLBA1Clovers";
            this.txtLBA1Clovers.Size = new System.Drawing.Size(44, 20);
            this.txtLBA1Clovers.TabIndex = 2;
            // 
            // tpLBA1Other
            // 
            this.tpLBA1Other.BackColor = System.Drawing.Color.MistyRose;
            this.tpLBA1Other.Controls.Add(this.chkLBA1MoviesValue);
            this.tpLBA1Other.Controls.Add(this.cboLBA1Movies);
            this.tpLBA1Other.Controls.Add(this.lblLBA1Movies);
            this.tpLBA1Other.Controls.Add(this.chkLBA1QuestValue);
            this.tpLBA1Other.Controls.Add(this.cboLBA1Quest);
            this.tpLBA1Other.Controls.Add(this.lblLBA1Quest);
            this.tpLBA1Other.Location = new System.Drawing.Point(4, 22);
            this.tpLBA1Other.Name = "tpLBA1Other";
            this.tpLBA1Other.Padding = new System.Windows.Forms.Padding(3);
            this.tpLBA1Other.Size = new System.Drawing.Size(334, 178);
            this.tpLBA1Other.TabIndex = 1;
            this.tpLBA1Other.Text = "Other";
            // 
            // chkLBA1MoviesValue
            // 
            this.chkLBA1MoviesValue.AutoSize = true;
            this.chkLBA1MoviesValue.Location = new System.Drawing.Point(301, 61);
            this.chkLBA1MoviesValue.Name = "chkLBA1MoviesValue";
            this.chkLBA1MoviesValue.Size = new System.Drawing.Size(15, 14);
            this.chkLBA1MoviesValue.TabIndex = 5;
            this.chkLBA1MoviesValue.UseVisualStyleBackColor = true;
            this.chkLBA1MoviesValue.CheckedChanged += new System.EventHandler(this.ChkLBA1MoviesValue_CheckedChanged);
            // 
            // cboLBA1Movies
            // 
            this.cboLBA1Movies.FormattingEnabled = true;
            this.cboLBA1Movies.Location = new System.Drawing.Point(64, 58);
            this.cboLBA1Movies.Name = "cboLBA1Movies";
            this.cboLBA1Movies.Size = new System.Drawing.Size(231, 21);
            this.cboLBA1Movies.TabIndex = 4;
            this.cboLBA1Movies.SelectedIndexChanged += new System.EventHandler(this.cboLBA1Movies_SelectedIndexChanged);
            // 
            // lblLBA1Movies
            // 
            this.lblLBA1Movies.AutoSize = true;
            this.lblLBA1Movies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Movies.Location = new System.Drawing.Point(6, 61);
            this.lblLBA1Movies.Name = "lblLBA1Movies";
            this.lblLBA1Movies.Size = new System.Drawing.Size(47, 13);
            this.lblLBA1Movies.TabIndex = 3;
            this.lblLBA1Movies.Text = "Movies";
            // 
            // chkLBA1QuestValue
            // 
            this.chkLBA1QuestValue.AutoSize = true;
            this.chkLBA1QuestValue.Location = new System.Drawing.Point(301, 24);
            this.chkLBA1QuestValue.Name = "chkLBA1QuestValue";
            this.chkLBA1QuestValue.Size = new System.Drawing.Size(15, 14);
            this.chkLBA1QuestValue.TabIndex = 2;
            this.chkLBA1QuestValue.UseVisualStyleBackColor = true;
            this.chkLBA1QuestValue.CheckedChanged += new System.EventHandler(this.ChkLBA1QuestValue_CheckedChanged);
            // 
            // cboLBA1Quest
            // 
            this.cboLBA1Quest.FormattingEnabled = true;
            this.cboLBA1Quest.Location = new System.Drawing.Point(64, 21);
            this.cboLBA1Quest.Name = "cboLBA1Quest";
            this.cboLBA1Quest.Size = new System.Drawing.Size(231, 21);
            this.cboLBA1Quest.TabIndex = 1;
            this.cboLBA1Quest.SelectedIndexChanged += new System.EventHandler(this.CboLBA1Quest_SelectedIndexChanged);
            // 
            // lblLBA1Quest
            // 
            this.lblLBA1Quest.AutoSize = true;
            this.lblLBA1Quest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA1Quest.Location = new System.Drawing.Point(6, 24);
            this.lblLBA1Quest.Name = "lblLBA1Quest";
            this.lblLBA1Quest.Size = new System.Drawing.Size(40, 13);
            this.lblLBA1Quest.TabIndex = 0;
            this.lblLBA1Quest.Text = "Quest";
            // 
            // tbLBA2
            // 
            this.tbLBA2.BackColor = System.Drawing.SystemColors.Control;
            this.tbLBA2.Controls.Add(this.tcLBA2Twinsen);
            this.tbLBA2.Location = new System.Drawing.Point(4, 22);
            this.tbLBA2.Name = "tbLBA2";
            this.tbLBA2.Padding = new System.Windows.Forms.Padding(3);
            this.tbLBA2.Size = new System.Drawing.Size(349, 209);
            this.tbLBA2.TabIndex = 1;
            this.tbLBA2.Text = "LBA2";
            // 
            // tcLBA2Twinsen
            // 
            this.tcLBA2Twinsen.Controls.Add(this.tpLBA2Twinsen);
            this.tcLBA2Twinsen.Location = new System.Drawing.Point(6, 6);
            this.tcLBA2Twinsen.Name = "tcLBA2Twinsen";
            this.tcLBA2Twinsen.SelectedIndex = 0;
            this.tcLBA2Twinsen.Size = new System.Drawing.Size(342, 204);
            this.tcLBA2Twinsen.TabIndex = 0;
            // 
            // tpLBA2Twinsen
            // 
            this.tpLBA2Twinsen.BackColor = System.Drawing.Color.MistyRose;
            this.tpLBA2Twinsen.Controls.Add(this.cboLBA2Inventory);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2Inventory);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2Zilitos);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2Zilitos);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2Keys);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2Keys);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2MagicLevel);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2MagicLevel);
            this.tpLBA2Twinsen.Controls.Add(this.btnLBA2TwinsenSet);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2Kashers);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2MagicPoints);
            this.tpLBA2Twinsen.Controls.Add(this.btnLBA2MinAll);
            this.tpLBA2Twinsen.Controls.Add(this.btnLBA2Scan);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2Health);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2Kashers);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2MagicPoints);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2Health);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2CloverBoxes);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2CloverBoxes);
            this.tpLBA2Twinsen.Controls.Add(this.btnLBA2MaxAll);
            this.tpLBA2Twinsen.Controls.Add(this.lblLBA2Clovers);
            this.tpLBA2Twinsen.Controls.Add(this.txtLBA2Clovers);
            this.tpLBA2Twinsen.Location = new System.Drawing.Point(4, 22);
            this.tpLBA2Twinsen.Name = "tpLBA2Twinsen";
            this.tpLBA2Twinsen.Padding = new System.Windows.Forms.Padding(3);
            this.tpLBA2Twinsen.Size = new System.Drawing.Size(334, 178);
            this.tpLBA2Twinsen.TabIndex = 0;
            this.tpLBA2Twinsen.Text = "Twinsen";
            // 
            // cboLBA2Inventory
            // 
            this.cboLBA2Inventory.FormattingEnabled = true;
            this.cboLBA2Inventory.Location = new System.Drawing.Point(106, 114);
            this.cboLBA2Inventory.Name = "cboLBA2Inventory";
            this.cboLBA2Inventory.Size = new System.Drawing.Size(171, 21);
            this.cboLBA2Inventory.TabIndex = 76;
            this.cboLBA2Inventory.SelectedIndexChanged += new System.EventHandler(this.CboLBA2Inventory_SelectedIndexChanged);
            // 
            // lblLBA2Inventory
            // 
            this.lblLBA2Inventory.AutoSize = true;
            this.lblLBA2Inventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2Inventory.Location = new System.Drawing.Point(6, 117);
            this.lblLBA2Inventory.Name = "lblLBA2Inventory";
            this.lblLBA2Inventory.Size = new System.Drawing.Size(60, 13);
            this.lblLBA2Inventory.TabIndex = 78;
            this.lblLBA2Inventory.Text = "Inventory";
            // 
            // txtLBA2Zilitos
            // 
            this.txtLBA2Zilitos.Location = new System.Drawing.Point(284, 88);
            this.txtLBA2Zilitos.Name = "txtLBA2Zilitos";
            this.txtLBA2Zilitos.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2Zilitos.TabIndex = 75;
            // 
            // lblLBA2Zilitos
            // 
            this.lblLBA2Zilitos.AutoSize = true;
            this.lblLBA2Zilitos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2Zilitos.Location = new System.Drawing.Point(197, 91);
            this.lblLBA2Zilitos.Name = "lblLBA2Zilitos";
            this.lblLBA2Zilitos.Size = new System.Drawing.Size(41, 13);
            this.lblLBA2Zilitos.TabIndex = 74;
            this.lblLBA2Zilitos.Text = "Zilitos";
            // 
            // txtLBA2Keys
            // 
            this.txtLBA2Keys.Location = new System.Drawing.Point(284, 61);
            this.txtLBA2Keys.Name = "txtLBA2Keys";
            this.txtLBA2Keys.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2Keys.TabIndex = 72;
            // 
            // lblLBA2Keys
            // 
            this.lblLBA2Keys.AutoSize = true;
            this.lblLBA2Keys.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2Keys.Location = new System.Drawing.Point(197, 64);
            this.lblLBA2Keys.Name = "lblLBA2Keys";
            this.lblLBA2Keys.Size = new System.Drawing.Size(34, 13);
            this.lblLBA2Keys.TabIndex = 73;
            this.lblLBA2Keys.Text = "Keys";
            // 
            // lblLBA2MagicLevel
            // 
            this.lblLBA2MagicLevel.AutoSize = true;
            this.lblLBA2MagicLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2MagicLevel.Location = new System.Drawing.Point(6, 38);
            this.lblLBA2MagicLevel.Name = "lblLBA2MagicLevel";
            this.lblLBA2MagicLevel.Size = new System.Drawing.Size(76, 13);
            this.lblLBA2MagicLevel.TabIndex = 58;
            this.lblLBA2MagicLevel.Text = "Magic Level";
            // 
            // txtLBA2MagicLevel
            // 
            this.txtLBA2MagicLevel.Location = new System.Drawing.Point(106, 35);
            this.txtLBA2MagicLevel.Name = "txtLBA2MagicLevel";
            this.txtLBA2MagicLevel.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2MagicLevel.TabIndex = 3;
            // 
            // btnLBA2TwinsenSet
            // 
            this.btnLBA2TwinsenSet.Location = new System.Drawing.Point(24, 144);
            this.btnLBA2TwinsenSet.Name = "btnLBA2TwinsenSet";
            this.btnLBA2TwinsenSet.Size = new System.Drawing.Size(63, 23);
            this.btnLBA2TwinsenSet.TabIndex = 12;
            this.btnLBA2TwinsenSet.Text = "Set";
            this.btnLBA2TwinsenSet.UseVisualStyleBackColor = true;
            this.btnLBA2TwinsenSet.Click += new System.EventHandler(this.BtnLBA2TwinsenSet_Click);
            // 
            // txtLBA2Kashers
            // 
            this.txtLBA2Kashers.Location = new System.Drawing.Point(106, 88);
            this.txtLBA2Kashers.Name = "txtLBA2Kashers";
            this.txtLBA2Kashers.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2Kashers.TabIndex = 7;
            // 
            // txtLBA2MagicPoints
            // 
            this.txtLBA2MagicPoints.Location = new System.Drawing.Point(284, 35);
            this.txtLBA2MagicPoints.Name = "txtLBA2MagicPoints";
            this.txtLBA2MagicPoints.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2MagicPoints.TabIndex = 4;
            // 
            // btnLBA2MinAll
            // 
            this.btnLBA2MinAll.Location = new System.Drawing.Point(231, 144);
            this.btnLBA2MinAll.Name = "btnLBA2MinAll";
            this.btnLBA2MinAll.Size = new System.Drawing.Size(63, 23);
            this.btnLBA2MinAll.TabIndex = 15;
            this.btnLBA2MinAll.Text = "Min All";
            this.btnLBA2MinAll.UseVisualStyleBackColor = true;
            this.btnLBA2MinAll.Click += new System.EventHandler(this.BtnLBA2MinAll_Click);
            // 
            // btnLBA2Scan
            // 
            this.btnLBA2Scan.Location = new System.Drawing.Point(93, 144);
            this.btnLBA2Scan.Name = "btnLBA2Scan";
            this.btnLBA2Scan.Size = new System.Drawing.Size(63, 23);
            this.btnLBA2Scan.TabIndex = 13;
            this.btnLBA2Scan.Text = "Scan";
            this.btnLBA2Scan.UseVisualStyleBackColor = true;
            this.btnLBA2Scan.Click += new System.EventHandler(this.BtnLBA2Scan_Click);
            // 
            // txtLBA2Health
            // 
            this.txtLBA2Health.Location = new System.Drawing.Point(106, 61);
            this.txtLBA2Health.Name = "txtLBA2Health";
            this.txtLBA2Health.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2Health.TabIndex = 5;
            // 
            // lblLBA2Kashers
            // 
            this.lblLBA2Kashers.AutoSize = true;
            this.lblLBA2Kashers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2Kashers.Location = new System.Drawing.Point(6, 91);
            this.lblLBA2Kashers.Name = "lblLBA2Kashers";
            this.lblLBA2Kashers.Size = new System.Drawing.Size(52, 13);
            this.lblLBA2Kashers.TabIndex = 56;
            this.lblLBA2Kashers.Text = "Kashers";
            // 
            // lblLBA2MagicPoints
            // 
            this.lblLBA2MagicPoints.AutoSize = true;
            this.lblLBA2MagicPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2MagicPoints.Location = new System.Drawing.Point(197, 38);
            this.lblLBA2MagicPoints.Name = "lblLBA2MagicPoints";
            this.lblLBA2MagicPoints.Size = new System.Drawing.Size(80, 13);
            this.lblLBA2MagicPoints.TabIndex = 55;
            this.lblLBA2MagicPoints.Text = "Magic Points";
            // 
            // lblLBA2Health
            // 
            this.lblLBA2Health.AutoSize = true;
            this.lblLBA2Health.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2Health.Location = new System.Drawing.Point(6, 64);
            this.lblLBA2Health.Name = "lblLBA2Health";
            this.lblLBA2Health.Size = new System.Drawing.Size(44, 13);
            this.lblLBA2Health.TabIndex = 54;
            this.lblLBA2Health.Text = "Health";
            // 
            // lblLBA2CloverBoxes
            // 
            this.lblLBA2CloverBoxes.AutoSize = true;
            this.lblLBA2CloverBoxes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2CloverBoxes.Location = new System.Drawing.Point(6, 12);
            this.lblLBA2CloverBoxes.Name = "lblLBA2CloverBoxes";
            this.lblLBA2CloverBoxes.Size = new System.Drawing.Size(81, 13);
            this.lblLBA2CloverBoxes.TabIndex = 52;
            this.lblLBA2CloverBoxes.Text = "Clover Boxes";
            // 
            // txtLBA2CloverBoxes
            // 
            this.txtLBA2CloverBoxes.BackColor = System.Drawing.SystemColors.Window;
            this.txtLBA2CloverBoxes.Location = new System.Drawing.Point(106, 9);
            this.txtLBA2CloverBoxes.Name = "txtLBA2CloverBoxes";
            this.txtLBA2CloverBoxes.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2CloverBoxes.TabIndex = 1;
            // 
            // btnLBA2MaxAll
            // 
            this.btnLBA2MaxAll.Location = new System.Drawing.Point(162, 144);
            this.btnLBA2MaxAll.Name = "btnLBA2MaxAll";
            this.btnLBA2MaxAll.Size = new System.Drawing.Size(63, 23);
            this.btnLBA2MaxAll.TabIndex = 14;
            this.btnLBA2MaxAll.Text = "Max All";
            this.btnLBA2MaxAll.UseVisualStyleBackColor = true;
            this.btnLBA2MaxAll.Click += new System.EventHandler(this.BtnLBA2MaxAll_Click);
            // 
            // lblLBA2Clovers
            // 
            this.lblLBA2Clovers.AutoSize = true;
            this.lblLBA2Clovers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLBA2Clovers.Location = new System.Drawing.Point(197, 12);
            this.lblLBA2Clovers.Name = "lblLBA2Clovers";
            this.lblLBA2Clovers.Size = new System.Drawing.Size(49, 13);
            this.lblLBA2Clovers.TabIndex = 53;
            this.lblLBA2Clovers.Text = "Clovers";
            // 
            // txtLBA2Clovers
            // 
            this.txtLBA2Clovers.Location = new System.Drawing.Point(284, 9);
            this.txtLBA2Clovers.Name = "txtLBA2Clovers";
            this.txtLBA2Clovers.Size = new System.Drawing.Size(44, 20);
            this.txtLBA2Clovers.TabIndex = 2;
            // 
            // frmTrainer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 239);
            this.Controls.Add(this.tcLBAVersion);
            this.Name = "frmTrainer";
            this.Text = "LBATrainer";
            this.tcLBAVersion.ResumeLayout(false);
            this.tpLBA1.ResumeLayout(false);
            this.tcLBA1Inner.ResumeLayout(false);
            this.tpLBA1Twinsen.ResumeLayout(false);
            this.tpLBA1Twinsen.PerformLayout();
            this.tpLBA1Other.ResumeLayout(false);
            this.tpLBA1Other.PerformLayout();
            this.tbLBA2.ResumeLayout(false);
            this.tcLBA2Twinsen.ResumeLayout(false);
            this.tpLBA2Twinsen.ResumeLayout(false);
            this.tpLBA2Twinsen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tcLBAVersion;
        private System.Windows.Forms.TabPage tpLBA1;
        private System.Windows.Forms.TabControl tcLBA1Inner;
        private System.Windows.Forms.TabPage tpLBA1Twinsen;
        private System.Windows.Forms.Label lblLBA1MagicLevel;
        private System.Windows.Forms.CheckBox chkLBA1QuestValue;
        private System.Windows.Forms.ComboBox cboLBA1Inventory;
        private System.Windows.Forms.Label lblLBA1Inventory;
        private System.Windows.Forms.Label lblLBA1Kashers;
        private System.Windows.Forms.Label lblLBA1MagicPoints;
        private System.Windows.Forms.Label lblLBA1Health;
        private System.Windows.Forms.Label lblLBA1CloverBoxes;
        private System.Windows.Forms.TextBox txtLBA1CloverBoxes;
        private System.Windows.Forms.Button btnLBA1MaxAll;
        private System.Windows.Forms.Label lblLBA1Clovers;
        private System.Windows.Forms.TextBox txtLBA1Clovers;
        private System.Windows.Forms.TabPage tbLBA2;
        private System.Windows.Forms.Label lblLBA1Gas;
        private System.Windows.Forms.TextBox txtLBA1Health;
        private System.Windows.Forms.Button btnLBA1Scan;
        private System.Windows.Forms.Button btnLBA1MinAll;
        private System.Windows.Forms.TextBox txtLBA1Gas;
        private System.Windows.Forms.TextBox txtLBA1Kashers;
        private System.Windows.Forms.TextBox txtLBA1MagicPoints;
        private System.Windows.Forms.TextBox txtLBA1MagicLevel;
        private System.Windows.Forms.TextBox txtLBA1Keys;
        private System.Windows.Forms.Label lblKeys;
        private System.Windows.Forms.Button btnLBA1Set;
        private System.Windows.Forms.TabControl tcLBA2Twinsen;
        private System.Windows.Forms.TabPage tpLBA2Twinsen;
        private System.Windows.Forms.Button btnLBA2TwinsenSet;
        private System.Windows.Forms.TextBox txtLBA2Kashers;
        private System.Windows.Forms.TextBox txtLBA2MagicPoints;
        private System.Windows.Forms.TextBox txtLBA2MagicLevel;
        private System.Windows.Forms.Button btnLBA2MinAll;
        private System.Windows.Forms.Button btnLBA2Scan;
        private System.Windows.Forms.TextBox txtLBA2Health;
        private System.Windows.Forms.Label lblLBA2MagicLevel;
        private System.Windows.Forms.Label lblLBA2Kashers;
        private System.Windows.Forms.Label lblLBA2MagicPoints;
        private System.Windows.Forms.Label lblLBA2Health;
        private System.Windows.Forms.Label lblLBA2CloverBoxes;
        private System.Windows.Forms.TextBox txtLBA2CloverBoxes;
        private System.Windows.Forms.Button btnLBA2MaxAll;
        private System.Windows.Forms.Label lblLBA2Clovers;
        private System.Windows.Forms.TextBox txtLBA2Clovers;
        private System.Windows.Forms.TextBox txtLBA2Keys;
        private System.Windows.Forms.Label lblLBA2Keys;
        private System.Windows.Forms.TextBox txtLBA2Zilitos;
        private System.Windows.Forms.Label lblLBA2Zilitos;
        private System.Windows.Forms.ComboBox cboLBA2Inventory;
        private System.Windows.Forms.Label lblLBA2Inventory;
        private System.Windows.Forms.TabPage tpLBA1Other;
        private System.Windows.Forms.ComboBox cboLBA1Quest;
        private System.Windows.Forms.Label lblLBA1Quest;
        private System.Windows.Forms.CheckBox chkLBA1InventoryValue;
        private System.Windows.Forms.CheckBox chkLBA1MoviesValue;
        private System.Windows.Forms.ComboBox cboLBA1Movies;
        private System.Windows.Forms.Label lblLBA1Movies;
    }
}

