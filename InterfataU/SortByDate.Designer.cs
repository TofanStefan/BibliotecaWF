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
            this.dateTimeFirst = new System.Windows.Forms.DateTimePicker();
            this.dateTimeLast = new System.Windows.Forms.DateTimePicker();
            this.bttnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dateTimeFirst
            // 
            this.dateTimeFirst.Location = new System.Drawing.Point(104, 58);
            this.dateTimeFirst.Name = "dateTimeFirst";
            this.dateTimeFirst.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFirst.TabIndex = 0;
            // 
            // dateTimeLast
            // 
            this.dateTimeLast.Location = new System.Drawing.Point(412, 58);
            this.dateTimeLast.Name = "dateTimeLast";
            this.dateTimeLast.Size = new System.Drawing.Size(200, 20);
            this.dateTimeLast.TabIndex = 1;
            // 
            // bttnOk
            // 
            this.bttnOk.Location = new System.Drawing.Point(309, 138);
            this.bttnOk.Name = "bttnOk";
            this.bttnOk.Size = new System.Drawing.Size(75, 23);
            this.bttnOk.TabIndex = 3;
            this.bttnOk.Text = "OK";
            this.bttnOk.UseVisualStyleBackColor = true;
            this.bttnOk.Click += new System.EventHandler(this.bttnOk_Click);
            // 
            // SortByDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 201);
            this.Controls.Add(this.bttnOk);
            this.Controls.Add(this.dateTimeLast);
            this.Controls.Add(this.dateTimeFirst);
            this.Name = "SortByDate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "SortByDate";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeFirst;
        private System.Windows.Forms.DateTimePicker dateTimeLast;
        private System.Windows.Forms.Button bttnOk;
    }
}