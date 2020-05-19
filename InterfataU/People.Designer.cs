namespace InterfataU
{
    partial class People
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(People));
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listBox_Book = new System.Windows.Forms.ListBox();
            this.lbl_Books = new System.Windows.Forms.Label();
            this.listBox_Name = new System.Windows.Forms.ListBox();
            this.bttnAdd_Book_Left = new System.Windows.Forms.Button();
            this.AntetBooks = new System.Windows.Forms.TextBox();
            this.lblAdd_Books = new System.Windows.Forms.Label();
            this.AntetPers = new System.Windows.Forms.TextBox();
            this.AntetBooks_Left = new System.Windows.Forms.TextBox();
            this.bttnCancel_Books = new System.Windows.Forms.Button();
            this.bttnAdd_Book = new System.Windows.Forms.Button();
            this.btnDelete_Book = new System.Windows.Forms.Button();
            this.lbl_Librarie = new System.Windows.Forms.Label();
            this.bttnDelete = new System.Windows.Forms.Button();
            this.bttnAdd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.bttnCancel = new System.Windows.Forms.PictureBox();
            this.bttn_AddPers = new System.Windows.Forms.PictureBox();
            this.userIcon = new System.Windows.Forms.PictureBox();
            this.lblAdd_Person = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.txtBox_Name = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cartiImprumutateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttn_AddPers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 361);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.listBox_Book);
            this.panel1.Controls.Add(this.lbl_Books);
            this.panel1.Controls.Add(this.listBox_Name);
            this.panel1.Controls.Add(this.bttnAdd_Book_Left);
            this.panel1.Controls.Add(this.AntetBooks);
            this.panel1.Controls.Add(this.lblAdd_Books);
            this.panel1.Controls.Add(this.AntetPers);
            this.panel1.Controls.Add(this.AntetBooks_Left);
            this.panel1.Controls.Add(this.bttnCancel_Books);
            this.panel1.Controls.Add(this.bttnAdd_Book);
            this.panel1.Controls.Add(this.btnDelete_Book);
            this.panel1.Controls.Add(this.lbl_Librarie);
            this.panel1.Controls.Add(this.bttnDelete);
            this.panel1.Controls.Add(this.bttnAdd);
            this.panel1.Location = new System.Drawing.Point(29, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(724, 392);
            this.panel1.TabIndex = 22;
            // 
            // listBox_Book
            // 
            this.listBox_Book.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_Book.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Book.FormattingEnabled = true;
            this.listBox_Book.ItemHeight = 14;
            this.listBox_Book.Location = new System.Drawing.Point(392, 68);
            this.listBox_Book.Name = "listBox_Book";
            this.listBox_Book.Size = new System.Drawing.Size(308, 270);
            this.listBox_Book.TabIndex = 23;
            // 
            // lbl_Books
            // 
            this.lbl_Books.AutoSize = true;
            this.lbl_Books.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Books.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Books.ForeColor = System.Drawing.Color.White;
            this.lbl_Books.Location = new System.Drawing.Point(452, 18);
            this.lbl_Books.Name = "lbl_Books";
            this.lbl_Books.Size = new System.Drawing.Size(180, 29);
            this.lbl_Books.TabIndex = 3;
            this.lbl_Books.Text = "CARTI IMPRUMUTATE";
            this.lbl_Books.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // listBox_Name
            // 
            this.listBox_Name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBox_Name.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Name.FormattingEnabled = true;
            this.listBox_Name.ItemHeight = 14;
            this.listBox_Name.Location = new System.Drawing.Point(22, 68);
            this.listBox_Name.Name = "listBox_Name";
            this.listBox_Name.Size = new System.Drawing.Size(308, 270);
            this.listBox_Name.TabIndex = 0;
            this.listBox_Name.SelectedIndexChanged += new System.EventHandler(this.listBox_Name_SelectedIndexChanged);
            // 
            // bttnAdd_Book_Left
            // 
            this.bttnAdd_Book_Left.Location = new System.Drawing.Point(60, 344);
            this.bttnAdd_Book_Left.Name = "bttnAdd_Book_Left";
            this.bttnAdd_Book_Left.Size = new System.Drawing.Size(98, 32);
            this.bttnAdd_Book_Left.TabIndex = 19;
            this.bttnAdd_Book_Left.Text = "Add";
            this.bttnAdd_Book_Left.UseVisualStyleBackColor = true;
            this.bttnAdd_Book_Left.Visible = false;
            this.bttnAdd_Book_Left.Click += new System.EventHandler(this.bttnAdd_Book_Left_Click);
            // 
            // AntetBooks
            // 
            this.AntetBooks.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntetBooks.Location = new System.Drawing.Point(392, 50);
            this.AntetBooks.Name = "AntetBooks";
            this.AntetBooks.Size = new System.Drawing.Size(308, 20);
            this.AntetBooks.TabIndex = 15;
            // 
            // lblAdd_Books
            // 
            this.lblAdd_Books.AutoSize = true;
            this.lblAdd_Books.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd_Books.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdd_Books.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_Books.ForeColor = System.Drawing.Color.White;
            this.lblAdd_Books.Location = new System.Drawing.Point(116, 18);
            this.lblAdd_Books.Name = "lblAdd_Books";
            this.lblAdd_Books.Size = new System.Drawing.Size(87, 29);
            this.lblAdd_Books.TabIndex = 18;
            this.lblAdd_Books.Text = "LIBRARIE";
            this.lblAdd_Books.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblAdd_Books.Visible = false;
            // 
            // AntetPers
            // 
            this.AntetPers.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntetPers.Location = new System.Drawing.Point(22, 50);
            this.AntetPers.MaximumSize = new System.Drawing.Size(308, 20);
            this.AntetPers.MinimumSize = new System.Drawing.Size(308, 20);
            this.AntetPers.Name = "AntetPers";
            this.AntetPers.Size = new System.Drawing.Size(308, 20);
            this.AntetPers.TabIndex = 14;
            // 
            // AntetBooks_Left
            // 
            this.AntetBooks_Left.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AntetBooks_Left.Location = new System.Drawing.Point(22, 50);
            this.AntetBooks_Left.Name = "AntetBooks_Left";
            this.AntetBooks_Left.Size = new System.Drawing.Size(308, 20);
            this.AntetBooks_Left.TabIndex = 17;
            this.AntetBooks_Left.Visible = false;
            // 
            // bttnCancel_Books
            // 
            this.bttnCancel_Books.Location = new System.Drawing.Point(193, 344);
            this.bttnCancel_Books.Name = "bttnCancel_Books";
            this.bttnCancel_Books.Size = new System.Drawing.Size(98, 32);
            this.bttnCancel_Books.TabIndex = 16;
            this.bttnCancel_Books.Text = "Cancel";
            this.bttnCancel_Books.UseVisualStyleBackColor = true;
            this.bttnCancel_Books.Visible = false;
            this.bttnCancel_Books.Click += new System.EventHandler(this.bttnCancel_Books_Click);
            // 
            // bttnAdd_Book
            // 
            this.bttnAdd_Book.Location = new System.Drawing.Point(432, 344);
            this.bttnAdd_Book.Name = "bttnAdd_Book";
            this.bttnAdd_Book.Size = new System.Drawing.Size(98, 32);
            this.bttnAdd_Book.TabIndex = 6;
            this.bttnAdd_Book.Text = "Add";
            this.bttnAdd_Book.UseVisualStyleBackColor = true;
            this.bttnAdd_Book.Click += new System.EventHandler(this.bttnAdd_Book_Click);
            // 
            // btnDelete_Book
            // 
            this.btnDelete_Book.Location = new System.Drawing.Point(565, 344);
            this.btnDelete_Book.Name = "btnDelete_Book";
            this.btnDelete_Book.Size = new System.Drawing.Size(98, 32);
            this.btnDelete_Book.TabIndex = 7;
            this.btnDelete_Book.Text = "Delete";
            this.btnDelete_Book.UseVisualStyleBackColor = true;
            this.btnDelete_Book.Click += new System.EventHandler(this.btnDelete_Book_Click);
            // 
            // lbl_Librarie
            // 
            this.lbl_Librarie.AutoSize = true;
            this.lbl_Librarie.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Librarie.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Librarie.Font = new System.Drawing.Font("Mistral", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Librarie.ForeColor = System.Drawing.Color.White;
            this.lbl_Librarie.Location = new System.Drawing.Point(116, 18);
            this.lbl_Librarie.Name = "lbl_Librarie";
            this.lbl_Librarie.Size = new System.Drawing.Size(100, 29);
            this.lbl_Librarie.TabIndex = 2;
            this.lbl_Librarie.Text = "PERSOANE";
            this.lbl_Librarie.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bttnDelete
            // 
            this.bttnDelete.Location = new System.Drawing.Point(193, 344);
            this.bttnDelete.Name = "bttnDelete";
            this.bttnDelete.Size = new System.Drawing.Size(98, 32);
            this.bttnDelete.TabIndex = 5;
            this.bttnDelete.Text = "Delete";
            this.bttnDelete.UseVisualStyleBackColor = true;
            this.bttnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bttnAdd
            // 
            this.bttnAdd.Location = new System.Drawing.Point(60, 344);
            this.bttnAdd.Name = "bttnAdd";
            this.bttnAdd.Size = new System.Drawing.Size(98, 32);
            this.bttnAdd.TabIndex = 4;
            this.bttnAdd.Text = "Add";
            this.bttnAdd.UseVisualStyleBackColor = true;
            this.bttnAdd.Click += new System.EventHandler(this.bttnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.cmbStatus);
            this.panel2.Controls.Add(this.bttnCancel);
            this.panel2.Controls.Add(this.bttn_AddPers);
            this.panel2.Controls.Add(this.userIcon);
            this.panel2.Controls.Add(this.lblAdd_Person);
            this.panel2.Controls.Add(this.lbl_Name);
            this.panel2.Controls.Add(this.txtBox_Name);
            this.panel2.Location = new System.Drawing.Point(29, 33);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(724, 392);
            this.panel2.TabIndex = 24;
            // 
            // cmbStatus
            // 
            this.cmbStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Student",
            "Elev",
            "Angajat"});
            this.cmbStatus.Location = new System.Drawing.Point(348, 191);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 28);
            this.cmbStatus.TabIndex = 26;
            // 
            // bttnCancel
            // 
            this.bttnCancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttnCancel.BackgroundImage")));
            this.bttnCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttnCancel.Location = new System.Drawing.Point(432, 251);
            this.bttnCancel.Name = "bttnCancel";
            this.bttnCancel.Size = new System.Drawing.Size(37, 37);
            this.bttnCancel.TabIndex = 25;
            this.bttnCancel.TabStop = false;
            this.bttnCancel.Click += new System.EventHandler(this.bttnCancel_Click);
            // 
            // bttn_AddPers
            // 
            this.bttn_AddPers.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bttn_AddPers.BackgroundImage")));
            this.bttn_AddPers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttn_AddPers.Location = new System.Drawing.Point(349, 251);
            this.bttn_AddPers.Name = "bttn_AddPers";
            this.bttn_AddPers.Size = new System.Drawing.Size(37, 37);
            this.bttn_AddPers.TabIndex = 0;
            this.bttn_AddPers.TabStop = false;
            this.bttn_AddPers.Click += new System.EventHandler(this.bttn_AddPers_Click);
            // 
            // userIcon
            // 
            this.userIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("userIcon.BackgroundImage")));
            this.userIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.userIcon.Location = new System.Drawing.Point(60, 96);
            this.userIcon.Name = "userIcon";
            this.userIcon.Size = new System.Drawing.Size(212, 192);
            this.userIcon.TabIndex = 22;
            this.userIcon.TabStop = false;
            // 
            // lblAdd_Person
            // 
            this.lblAdd_Person.AutoSize = true;
            this.lblAdd_Person.BackColor = System.Drawing.Color.Transparent;
            this.lblAdd_Person.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblAdd_Person.Font = new System.Drawing.Font("Mistral", 26.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdd_Person.ForeColor = System.Drawing.Color.White;
            this.lblAdd_Person.Location = new System.Drawing.Point(295, 18);
            this.lblAdd_Person.Name = "lblAdd_Person";
            this.lblAdd_Person.Size = new System.Drawing.Size(249, 42);
            this.lblAdd_Person.TabIndex = 8;
            this.lblAdd_Person.Text = "ADAUGA PERSOANA";
            this.lblAdd_Person.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Name.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_Name.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.White;
            this.lbl_Name.Location = new System.Drawing.Point(358, 96);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(111, 36);
            this.lbl_Name.TabIndex = 10;
            this.lbl_Name.Text = "NUME:";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtBox_Name
            // 
            this.txtBox_Name.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBox_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_Name.Location = new System.Drawing.Point(294, 161);
            this.txtBox_Name.Name = "txtBox_Name";
            this.txtBox_Name.Size = new System.Drawing.Size(250, 24);
            this.txtBox_Name.TabIndex = 9;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartiImprumutateToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // cartiImprumutateToolStripMenuItem
            // 
            this.cartiImprumutateToolStripMenuItem.Name = "cartiImprumutateToolStripMenuItem";
            this.cartiImprumutateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cartiImprumutateToolStripMenuItem.Text = "Carti Imprumutate";
          
            // 
            // People
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(779, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(795, 489);
            this.MinimumSize = new System.Drawing.Size(795, 489);
            this.Name = "People";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "People";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bttnCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bttn_AddPers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userIcon)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listBox_Book;
        private System.Windows.Forms.Label lbl_Books;
        private System.Windows.Forms.ListBox listBox_Name;
        private System.Windows.Forms.TextBox AntetBooks;
        private System.Windows.Forms.Label lblAdd_Books;
        private System.Windows.Forms.Button bttnAdd_Book_Left;
        private System.Windows.Forms.TextBox AntetPers;
        private System.Windows.Forms.TextBox AntetBooks_Left;
        private System.Windows.Forms.Button bttnCancel_Books;
        private System.Windows.Forms.Button bttnAdd_Book;
        private System.Windows.Forms.Button btnDelete_Book;
        private System.Windows.Forms.Label lbl_Librarie;
        private System.Windows.Forms.Button bttnDelete;
        private System.Windows.Forms.Button bttnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox userIcon;
        private System.Windows.Forms.Label lblAdd_Person;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.TextBox txtBox_Name;
        private System.Windows.Forms.PictureBox bttnCancel;
        private System.Windows.Forms.PictureBox bttn_AddPers;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cartiImprumutateToolStripMenuItem;
    }
}