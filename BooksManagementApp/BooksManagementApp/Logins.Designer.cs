namespace BooksManagementApp
{
    partial class Logins
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
            this.btnlogin = new System.Windows.Forms.Button();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnlogin
            // 
            this.btnlogin.BackColor = System.Drawing.Color.SkyBlue;
            this.btnlogin.Location = new System.Drawing.Point(339, 207);
            this.btnlogin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlogin.Name = "btnlogin";
            this.btnlogin.Size = new System.Drawing.Size(100, 28);
            this.btnlogin.TabIndex = 9;
            this.btnlogin.Text = "Login";
            this.btnlogin.UseVisualStyleBackColor = false;
            this.btnlogin.Click += new System.EventHandler(this.btnlogin_Click);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(231, 160);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(207, 22);
            this.txtpassword.TabIndex = 8;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(231, 98);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(207, 22);
            this.txtusername.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 98);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Admin Name:";
            // 
            // Logins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(565, 327);
            this.Controls.Add(this.btnlogin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Logins";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnlogin;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

