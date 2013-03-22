﻿namespace POELadder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.selectladderLabel = new System.Windows.Forms.Label();
            this.ladderselectBox = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.LadderTable = new System.Windows.Forms.DataGridView();
            this.DeathTable = new System.Windows.Forms.DataGridView();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.seasonPoints = new System.Windows.Forms.DataGridView();
            this.Rank = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Points = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerLabel = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            ((System.ComponentModel.ISupportInitialize)(this.LadderTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeathTable)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seasonPoints)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // selectladderLabel
            // 
            this.selectladderLabel.AutoSize = true;
            this.selectladderLabel.Location = new System.Drawing.Point(11, 15);
            this.selectladderLabel.Name = "selectladderLabel";
            this.selectladderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.selectladderLabel.Size = new System.Drawing.Size(76, 13);
            this.selectladderLabel.TabIndex = 151;
            this.selectladderLabel.Text = "Select Ladder:";
            // 
            // ladderselectBox
            // 
            this.ladderselectBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ladderselectBox.FormattingEnabled = true;
            this.ladderselectBox.Location = new System.Drawing.Point(93, 12);
            this.ladderselectBox.Name = "ladderselectBox";
            this.ladderselectBox.Size = new System.Drawing.Size(388, 21);
            this.ladderselectBox.TabIndex = 151;
            this.toolTip1.SetToolTip(this.ladderselectBox, "Select the ladder or race you\'re interested in.");
            this.ladderselectBox.SelectedIndexChanged += new System.EventHandler(this.ladderselectBox_SelectedIndexChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(487, 15);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 17);
            this.checkBox1.TabIndex = 156;
            this.checkBox1.Text = "Auto";
            this.toolTip1.SetToolTip(this.checkBox1, "Enable auto-refreshing of table every 15 seconds");
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LadderTable
            // 
            this.LadderTable.AllowUserToAddRows = false;
            this.LadderTable.AllowUserToDeleteRows = false;
            this.LadderTable.AllowUserToOrderColumns = true;
            this.LadderTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.LadderTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.LadderTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LadderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.LadderTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.LadderTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.LadderTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LadderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.LadderTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.LadderTable.Location = new System.Drawing.Point(10, 39);
            this.LadderTable.MultiSelect = false;
            this.LadderTable.Name = "LadderTable";
            this.LadderTable.RowHeadersVisible = false;
            this.LadderTable.Size = new System.Drawing.Size(1084, 443);
            this.LadderTable.TabIndex = 149;
            // 
            // DeathTable
            // 
            this.DeathTable.AllowUserToAddRows = false;
            this.DeathTable.AllowUserToDeleteRows = false;
            this.DeathTable.AllowUserToOrderColumns = true;
            this.DeathTable.AllowUserToResizeColumns = false;
            this.DeathTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.DeathTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DeathTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeathTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DeathTable.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DeathTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.DeathTable.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DeathTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DeathTable.DefaultCellStyle = dataGridViewCellStyle4;
            this.DeathTable.Location = new System.Drawing.Point(0, 0);
            this.DeathTable.Name = "DeathTable";
            this.DeathTable.Size = new System.Drawing.Size(1080, 120);
            this.DeathTable.TabIndex = 150;
            // 
            // timer1
            // 
            this.timer1.Interval = 15000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(527, 15);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(39, 13);
            this.linkLabel1.TabIndex = 167;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "refresh";
            this.toolTip1.SetToolTip(this.linkLabel1, "Manually refresh the table");
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.seasonPoints);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1076, 120);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Details";
            this.toolTip1.SetToolTip(this.tabPage1, "Filter table results");
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All",
            "Duelist",
            "Marauder",
            "Ranger",
            "Shadow",
            "Templar",
            "Witch"});
            this.comboBox1.Location = new System.Drawing.Point(148, 36);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(123, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "All";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Filter by class:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(148, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(123, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search character/account:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(10, 488);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1084, 146);
            this.tabControl1.TabIndex = 168;
            // 
            // seasonPoints
            // 
            this.seasonPoints.AllowUserToAddRows = false;
            this.seasonPoints.AllowUserToDeleteRows = false;
            this.seasonPoints.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.seasonPoints.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.seasonPoints.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.seasonPoints.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.seasonPoints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.seasonPoints.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Rank,
            this.Account,
            this.Points});
            this.seasonPoints.Location = new System.Drawing.Point(888, 0);
            this.seasonPoints.MultiSelect = false;
            this.seasonPoints.Name = "seasonPoints";
            this.seasonPoints.ReadOnly = true;
            this.seasonPoints.RowHeadersVisible = false;
            this.seasonPoints.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.seasonPoints.Size = new System.Drawing.Size(188, 120);
            this.seasonPoints.TabIndex = 0;
            this.seasonPoints.TabStop = false;
            // 
            // Rank
            // 
            this.Rank.FillWeight = 102.9156F;
            this.Rank.HeaderText = "Rank";
            this.Rank.MaxInputLength = 4;
            this.Rank.Name = "Rank";
            this.Rank.ReadOnly = true;
            this.Rank.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Account
            // 
            this.Account.FillWeight = 121.8274F;
            this.Account.HeaderText = "Account";
            this.Account.MaxInputLength = 30;
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Points
            // 
            this.Points.FillWeight = 75.25701F;
            this.Points.HeaderText = "Points";
            this.Points.MaxInputLength = 4;
            this.Points.Name = "Points";
            this.Points.ReadOnly = true;
            this.Points.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timerLabel.Location = new System.Drawing.Point(815, 15);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(282, 18);
            this.timerLabel.TabIndex = 169;
            this.timerLabel.Text = "00:00:00";
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DeathTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1076, 120);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Deaths";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.linkLabel1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1113, 646);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.LadderTable);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.selectladderLabel);
            this.Controls.Add(this.ladderselectBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Path of Exile League and Race Ladder";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LadderTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeathTable)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.seasonPoints)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label selectladderLabel;
        internal System.Windows.Forms.ComboBox ladderselectBox;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.DataGridView LadderTable;
        private System.Windows.Forms.DataGridView DeathTable;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView seasonPoints;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rank;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn Points;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.TabPage tabPage3;

    }
}

