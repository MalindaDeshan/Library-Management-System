namespace BooksManagementApp
{
    partial class Bookinsert
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtaouthor = new System.Windows.Forms.TextBox();
            this.txtBname = new System.Windows.Forms.TextBox();
            this.txtBid = new System.Windows.Forms.TextBox();
            this.txtAuthor = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnCancel.Location = new System.Drawing.Point(476, 180);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 28);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "Close";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtaouthor
            // 
            this.txtaouthor.Location = new System.Drawing.Point(157, 226);
            this.txtaouthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtaouthor.Name = "txtaouthor";
            this.txtaouthor.Size = new System.Drawing.Size(265, 22);
            this.txtaouthor.TabIndex = 31;
            // 
            // txtBname
            // 
            this.txtBname.Location = new System.Drawing.Point(157, 158);
            this.txtBname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBname.Name = "txtBname";
            this.txtBname.Size = new System.Drawing.Size(265, 22);
            this.txtBname.TabIndex = 30;
            // 
            // txtBid
            // 
            this.txtBid.Location = new System.Drawing.Point(157, 84);
            this.txtBid.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtBid.Name = "txtBid";
            this.txtBid.Size = new System.Drawing.Size(265, 22);
            this.txtBid.TabIndex = 29;
            // 
            // txtAuthor
            // 
            this.txtAuthor.AutoSize = true;
            this.txtAuthor.Location = new System.Drawing.Point(48, 231);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(48, 16);
            this.txtAuthor.TabIndex = 28;
            this.txtAuthor.Text = "Author:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 160);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 27;
            this.label3.Text = "Books Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 87);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 26;
            this.label2.Text = "Books Id:";
            // 
            // btnInsert
            // 
            this.btnInsert.BackColor = System.Drawing.Color.SkyBlue;
            this.btnInsert.Location = new System.Drawing.Point(476, 123);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 28);
            this.btnInsert.TabIndex = 25;
            this.btnInsert.Text = "INSERT";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(16, 309);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "<< Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Bookinsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(621, 352);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtaouthor);
            this.Controls.Add(this.txtBname);
            this.Controls.Add(this.txtBid);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnInsert);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Bookinsert";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bookinsert";
            this.Load += new System.EventHandler(this.Bookinsert_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtaouthor;
        private System.Windows.Forms.TextBox txtBname;
        private System.Windows.Forms.TextBox txtBid;
        private System.Windows.Forms.Label txtAuthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button button1;
    }
}