namespace InterfataU
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnExit = new System.Windows.Forms.PictureBox();
            this.bttnSettings = new System.Windows.Forms.PictureBox();
            this.cmbReturnTime = new MetroFramework.Controls.MetroComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMaxImprumut = new MetroFramework.Controls.MetroComboBox();
            this.cmbAbateri = new MetroFramework.Controls.MetroComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.metroToggle1 = new MetroFramework.Controls.MetroToggle();
            this.label2 = new System.Windows.Forms.Label();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.panelSet = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panelSet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(-3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(719, 29);
            this.panel1.TabIndex = 9;
            // 
            // bttnExit
            // 
            this.bttnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnExit.BackgroundImage")));
            this.bttnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnExit.Location = new System.Drawing.Point(690, 3);
            this.bttnExit.Name = "bttnExit";
            this.bttnExit.Size = new System.Drawing.Size(22, 22);
            this.bttnExit.TabIndex = 13;
            this.bttnExit.TabStop = false;
            this.bttnExit.Click += new System.EventHandler(this.bttnExit_Click);
            // 
            // bttnSettings
            // 
            this.bttnSettings.BackColor = System.Drawing.Color.Transparent;
            this.bttnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnSettings.BackgroundImage")));
            this.bttnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnSettings.Location = new System.Drawing.Point(12, 139);
            this.bttnSettings.Name = "bttnSettings";
            this.bttnSettings.Size = new System.Drawing.Size(247, 239);
            this.bttnSettings.TabIndex = 18;
            this.bttnSettings.TabStop = false;
            // 
            // cmbReturnTime
            // 
            this.cmbReturnTime.FormattingEnabled = true;
            this.cmbReturnTime.ItemHeight = 23;
            this.cmbReturnTime.Items.AddRange(new object[] {
            "2 zile",
            "2 luni"});
            this.cmbReturnTime.Location = new System.Drawing.Point(48, 100);
            this.cmbReturnTime.Name = "cmbReturnTime";
            this.cmbReturnTime.Size = new System.Drawing.Size(239, 29);
            this.cmbReturnTime.TabIndex = 19;
            this.cmbReturnTime.UseSelectable = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Perpetua Titling MT", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 34);
            this.label1.TabIndex = 20;
            this.label1.Text = "Setari";
            // 
            // cmbMaxImprumut
            // 
            this.cmbMaxImprumut.FormattingEnabled = true;
            this.cmbMaxImprumut.ItemHeight = 23;
            this.cmbMaxImprumut.Items.AddRange(new object[] {
            "Maxim 3 carti",
            "Maxim 5 carti",
            "Maxim 7 carti"});
            this.cmbMaxImprumut.Location = new System.Drawing.Point(48, 19);
            this.cmbMaxImprumut.Name = "cmbMaxImprumut";
            this.cmbMaxImprumut.Size = new System.Drawing.Size(239, 29);
            this.cmbMaxImprumut.TabIndex = 21;
            this.cmbMaxImprumut.UseSelectable = true;
            // 
            // cmbAbateri
            // 
            this.cmbAbateri.FormattingEnabled = true;
            this.cmbAbateri.ItemHeight = 23;
            this.cmbAbateri.Items.AddRange(new object[] {
            "5 abateri",
            "2 abateri",
            "1 abatere"});
            this.cmbAbateri.Location = new System.Drawing.Point(48, 182);
            this.cmbAbateri.Name = "cmbAbateri";
            this.cmbAbateri.Size = new System.Drawing.Size(239, 29);
            this.cmbAbateri.TabIndex = 22;
            this.cmbAbateri.UseSelectable = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(312, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(31, 29);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(312, 182);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(31, 29);
            this.pictureBox2.TabIndex = 24;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(312, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(31, 29);
            this.pictureBox3.TabIndex = 25;
            this.pictureBox3.TabStop = false;
            // 
            // metroToggle1
            // 
            this.metroToggle1.AutoSize = true;
            this.metroToggle1.Location = new System.Drawing.Point(207, 222);
            this.metroToggle1.Name = "metroToggle1";
            this.metroToggle1.Size = new System.Drawing.Size(80, 17);
            this.metroToggle1.TabIndex = 26;
            this.metroToggle1.Text = "Off";
            this.metroToggle1.UseSelectable = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Perpetua Titling MT", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 19);
            this.label2.TabIndex = 27;
            this.label2.Text = "Adauga setare";
            // 
            // metroButton1
            // 
            this.metroButton1.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.metroButton1.Location = new System.Drawing.Point(343, 384);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(157, 47);
            this.metroButton1.TabIndex = 28;
            this.metroButton1.Text = "Seteaza";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // panelSet
            // 
            this.panelSet.BackColor = System.Drawing.Color.Transparent;
            this.panelSet.Controls.Add(this.cmbMaxImprumut);
            this.panelSet.Controls.Add(this.pictureBox2);
            this.panelSet.Controls.Add(this.label2);
            this.panelSet.Controls.Add(this.pictureBox1);
            this.panelSet.Controls.Add(this.metroToggle1);
            this.panelSet.Controls.Add(this.pictureBox3);
            this.panelSet.Controls.Add(this.cmbAbateri);
            this.panelSet.Controls.Add(this.cmbReturnTime);
            this.panelSet.Location = new System.Drawing.Point(265, 132);
            this.panelSet.Name = "panelSet";
            this.panelSet.Size = new System.Drawing.Size(405, 246);
            this.panelSet.TabIndex = 29;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 444);
            this.Controls.Add(this.panelSet);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttnSettings);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Settings";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bttnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttnSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panelSet.ResumeLayout(false);
            this.panelSet.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox bttnExit;
        private System.Windows.Forms.PictureBox bttnSettings;
        private MetroFramework.Controls.MetroComboBox cmbReturnTime;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroComboBox cmbMaxImprumut;
        private MetroFramework.Controls.MetroComboBox cmbAbateri;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolTip toolTip;
        private MetroFramework.Controls.MetroToggle metroToggle1;
        private System.Windows.Forms.Label label2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.Panel panelSet;
    }
}