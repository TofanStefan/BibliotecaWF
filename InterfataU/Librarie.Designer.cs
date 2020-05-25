namespace InterfataU
{
    partial class Librarie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Librarie));
            this.lbl_Librarie = new System.Windows.Forms.Label();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPeople = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFile = new System.Windows.Forms.Button();
            this.Antet = new System.Windows.Forms.TextBox();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.bttnSearch = new System.Windows.Forms.PictureBox();
            this.SaveFile = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dataAdaugariiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataModificariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filtreazaDupaDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bttnSettings = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bttnSearch)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnSettings)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Librarie
            // 
            this.lbl_Librarie.AutoSize = true;
            this.lbl_Librarie.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Librarie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Librarie.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Librarie.Location = new System.Drawing.Point(239, 9);
            this.lbl_Librarie.Name = "lbl_Librarie";
            this.lbl_Librarie.Size = new System.Drawing.Size(87, 29);
            this.lbl_Librarie.TabIndex = 1;
            this.lbl_Librarie.Text = "LIBRARIE";
            this.lbl_Librarie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ListBox
            // 
            this.ListBox.BackColor = System.Drawing.Color.White;
            this.ListBox.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 14;
            this.ListBox.Location = new System.Drawing.Point(104, 97);
            this.ListBox.Name = "ListBox";
            this.ListBox.Size = new System.Drawing.Size(350, 256);
            this.ListBox.TabIndex = 2;
            this.ListBox.DoubleClick += new System.EventHandler(this.ListBox_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 387);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "--MADE BY TOFAN STEFAN--";
            // 
            // btnPeople
            // 
            this.btnPeople.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPeople.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeople.Image = ((System.Drawing.Image)(resources.GetObject("btnPeople.Image")));
            this.btnPeople.Location = new System.Drawing.Point(483, 204);
            this.btnPeople.Name = "btnPeople";
            this.btnPeople.Size = new System.Drawing.Size(68, 32);
            this.btnPeople.TabIndex = 8;
            this.btnPeople.UseVisualStyleBackColor = false;
            this.btnPeople.Click += new System.EventHandler(this.btnPeople_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Image = ((System.Drawing.Image)(resources.GetObject("btnAdd.Image")));
            this.btnAdd.Location = new System.Drawing.Point(483, 81);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(68, 32);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.Location = new System.Drawing.Point(483, 141);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(68, 32);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseCompatibleTextRendering = true;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFile.Image = ((System.Drawing.Image)(resources.GetObject("btnFile.Image")));
            this.btnFile.Location = new System.Drawing.Point(483, 321);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(68, 32);
            this.btnFile.TabIndex = 12;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // Antet
            // 
            this.Antet.Location = new System.Drawing.Point(104, 81);
            this.Antet.Name = "Antet";
            this.Antet.Size = new System.Drawing.Size(350, 20);
            this.Antet.TabIndex = 13;
            // 
            // SearchBox
            // 
            this.SearchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.Location = new System.Drawing.Point(192, 55);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(145, 22);
            this.SearchBox.TabIndex = 14;
            // 
            // bttnSearch
            // 
            this.bttnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.bttnSearch.BackColor = System.Drawing.Color.White;
            this.bttnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttnSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bttnSearch.Image = ((System.Drawing.Image)(resources.GetObject("bttnSearch.Image")));
            this.bttnSearch.Location = new System.Drawing.Point(332, 55);
            this.bttnSearch.Name = "bttnSearch";
            this.bttnSearch.Padding = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.bttnSearch.Size = new System.Drawing.Size(26, 22);
            this.bttnSearch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bttnSearch.TabIndex = 15;
            this.bttnSearch.TabStop = false;
            this.bttnSearch.Click += new System.EventHandler(this.bttnSearch_Click);
            // 
            // SaveFile
            // 
            this.SaveFile.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.SaveFile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("SaveFile.Image")));
            this.SaveFile.Location = new System.Drawing.Point(483, 261);
            this.SaveFile.Name = "SaveFile";
            this.SaveFile.Size = new System.Drawing.Size(68, 32);
            this.SaveFile.TabIndex = 16;
            this.SaveFile.UseVisualStyleBackColor = false;
            this.SaveFile.Click += new System.EventHandler(this.SaveFile_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataAdaugariiToolStripMenuItem,
            this.dataModificariToolStripMenuItem,
            this.filtreazaDupaDataToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(175, 70);
            // 
            // dataAdaugariiToolStripMenuItem
            // 
            this.dataAdaugariiToolStripMenuItem.Name = "dataAdaugariiToolStripMenuItem";
            this.dataAdaugariiToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dataAdaugariiToolStripMenuItem.Text = "Data Adaugarii";
            this.dataAdaugariiToolStripMenuItem.Click += new System.EventHandler(this.dataAdaugariiToolStripMenuItem_Click);
            // 
            // dataModificariToolStripMenuItem
            // 
            this.dataModificariToolStripMenuItem.Name = "dataModificariToolStripMenuItem";
            this.dataModificariToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.dataModificariToolStripMenuItem.Text = "Data Modificari";
            this.dataModificariToolStripMenuItem.Click += new System.EventHandler(this.dataModificariToolStripMenuItem_Click);
            // 
            // filtreazaDupaDataToolStripMenuItem
            // 
            this.filtreazaDupaDataToolStripMenuItem.Name = "filtreazaDupaDataToolStripMenuItem";
            this.filtreazaDupaDataToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.filtreazaDupaDataToolStripMenuItem.Text = "Filtreaza dupa Data";
            this.filtreazaDupaDataToolStripMenuItem.Click += new System.EventHandler(this.filtreazaDupaDataToolStripMenuItem_Click);
            // 
            // bttnSettings
            // 
            this.bttnSettings.BackColor = System.Drawing.Color.Transparent;
            this.bttnSettings.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnSettings.BackgroundImage")));
            this.bttnSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnSettings.Location = new System.Drawing.Point(12, 9);
            this.bttnSettings.Name = "bttnSettings";
            this.bttnSettings.Size = new System.Drawing.Size(25, 25);
            this.bttnSettings.TabIndex = 17;
            this.bttnSettings.TabStop = false;
            this.bttnSettings.Click += new System.EventHandler(this.bttnSettings_Click);
            // 
            // Librarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(584, 424);
            this.Controls.Add(this.bttnSettings);
            this.Controls.Add(this.SaveFile);
            this.Controls.Add(this.bttnSearch);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.Antet);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnPeople);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.lbl_Librarie);
            this.MaximumSize = new System.Drawing.Size(600, 463);
            this.MinimumSize = new System.Drawing.Size(600, 463);
            this.Name = "Librarie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Librarie";
            ((System.ComponentModel.ISupportInitialize)(this.bttnSearch)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bttnSettings)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Librarie;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPeople;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.TextBox Antet;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.PictureBox bttnSearch;
        private System.Windows.Forms.Button SaveFile;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dataAdaugariiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataModificariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filtreazaDupaDataToolStripMenuItem;
        private System.Windows.Forms.PictureBox bttnSettings;
    }
}

