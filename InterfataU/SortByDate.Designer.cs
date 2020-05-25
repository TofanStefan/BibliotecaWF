namespace InterfataU
{
    partial class SortByDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SortByDate));
            this.dateTimeFirst = new MetroFramework.Controls.MetroDateTime();
            this.dateTimeLast = new MetroFramework.Controls.MetroDateTime();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bttnExit = new System.Windows.Forms.PictureBox();
            this.bttnOk = new MetroFramework.Controls.MetroButton();
            this.panel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnExit)).BeginInit();
            this.panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimeFirst
            // 
            this.dateTimeFirst.Location = new System.Drawing.Point(281, 61);
            this.dateTimeFirst.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeFirst.Name = "dateTimeFirst";
            this.dateTimeFirst.Size = new System.Drawing.Size(214, 29);
            this.dateTimeFirst.TabIndex = 4;
            // 
            // dateTimeLast
            // 
            this.dateTimeLast.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeLast.Location = new System.Drawing.Point(280, 119);
            this.dateTimeLast.MinimumSize = new System.Drawing.Size(0, 29);
            this.dateTimeLast.Name = "dateTimeLast";
            this.dateTimeLast.Size = new System.Drawing.Size(214, 29);
            this.dateTimeLast.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.panel1.Controls.Add(this.bttnExit);
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(64)))), ((int)(((byte)(61)))));
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 29);
            this.panel1.TabIndex = 8;
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
            // bttnOk
            // 
            this.bttnOk.BackColor = System.Drawing.Color.White;
            this.bttnOk.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.bttnOk.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.bttnOk.Location = new System.Drawing.Point(323, 169);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(122, 38);
            this.bttnOk.TabIndex = 9;
            this.bttnOk.Text = "Submit";
            this.bttnOk.UseSelectable = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Transparent;
            this.panel.Controls.Add(this.pictureBox1);
            this.panel.Location = new System.Drawing.Point(16, 35);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(194, 186);
            this.panel.TabIndex = 10;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(13, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 166);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(216, 42);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(59, 48);
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(500, 100);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(59, 48);
            this.pictureBox3.TabIndex = 12;
            this.pictureBox3.TabStop = false;
            // 
            // SortByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(713, 233);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.dateTimeLast);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimeFirst);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SortByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SortByDate";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bttnExit)).EndInit();
            this.panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Controls.MetroDateTime dateTimeFirst;
        private MetroFramework.Controls.MetroDateTime dateTimeLast;
        private System.Windows.Forms.Panel panel1;
        private MetroFramework.Controls.MetroButton bttnOk;
        private System.Windows.Forms.Panel panel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox bttnExit;
    }
}