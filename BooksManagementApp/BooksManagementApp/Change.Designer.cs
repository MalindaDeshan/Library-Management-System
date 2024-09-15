namespace BooksManagementApp
{
    partial class Change
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
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pannelsearch = new System.Windows.Forms.GroupBox();
            this.pannelupdate = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtnewuser = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtuser = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnchange = new System.Windows.Forms.Button();
            this.txtCNpassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtNpassword = new System.Windows.Forms.TextBox();
            this.txtusename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pannelsearch.SuspendLayout();
            this.pannelupdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(35, 282);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(115, 16);
            this.linkLabel1.TabIndex = 43;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "change username";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // pannelsearch
            // 
            this.pannelsearch.Controls.Add(this.pannelupdate);
            this.pannelsearch.Controls.Add(this.label5);
            this.pannelsearch.Controls.Add(this.btnsearch);
            this.pannelsearch.Controls.Add(this.txtuser);
            this.pannelsearch.Location = new System.Drawing.Point(507, 36);
            this.pannelsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelsearch.Name = "pannelsearch";
            this.pannelsearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelsearch.Size = new System.Drawing.Size(428, 305);
            this.pannelsearch.TabIndex = 42;
            this.pannelsearch.TabStop = false;
            this.pannelsearch.Text = "Change Username";
            // 
            // pannelupdate
            // 
            this.pannelupdate.Controls.Add(this.button1);
            this.pannelupdate.Controls.Add(this.txtnewuser);
            this.pannelupdate.Controls.Add(this.label6);
            this.pannelupdate.Location = new System.Drawing.Point(8, 134);
            this.pannelupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelupdate.Name = "pannelupdate";
            this.pannelupdate.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelupdate.Size = new System.Drawing.Size(412, 164);
            this.pannelupdate.TabIndex = 30;
            this.pannelupdate.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SkyBlue;
            this.button1.Location = new System.Drawing.Point(268, 82);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 4;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtnewuser
            // 
            this.txtnewuser.Location = new System.Drawing.Point(165, 38);
            this.txtnewuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtnewuser.Name = "txtnewuser";
            this.txtnewuser.Size = new System.Drawing.Size(201, 22);
            this.txtnewuser.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 42);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Enter New username :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Username :";
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.SkyBlue;
            this.btnsearch.Location = new System.Drawing.Point(249, 80);
            this.btnsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(100, 28);
            this.btnsearch.TabIndex = 27;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtuser
            // 
            this.txtuser.Location = new System.Drawing.Point(125, 34);
            this.txtuser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtuser.Name = "txtuser";
            this.txtuser.Size = new System.Drawing.Size(223, 22);
            this.txtuser.TabIndex = 29;
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(203, 92);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(249, 22);
            this.txtpassword.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 40;
            this.label1.Text = "Current Passsword :";
            // 
            // btnchange
            // 
            this.btnchange.BackColor = System.Drawing.Color.SkyBlue;
            this.btnchange.ForeColor = System.Drawing.Color.Black;
            this.btnchange.Location = new System.Drawing.Point(379, 274);
            this.btnchange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnchange.Name = "btnchange";
            this.btnchange.Size = new System.Drawing.Size(75, 32);
            this.btnchange.TabIndex = 39;
            this.btnchange.Text = "Change";
            this.btnchange.UseVisualStyleBackColor = false;
            this.btnchange.Click += new System.EventHandler(this.btnchange_Click);
            // 
            // txtCNpassword
            // 
            this.txtCNpassword.Location = new System.Drawing.Point(203, 218);
            this.txtCNpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCNpassword.Name = "txtCNpassword";
            this.txtCNpassword.Size = new System.Drawing.Size(249, 22);
            this.txtCNpassword.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 37;
            this.label4.Text = "Confirm New Password:";
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btncancel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btncancel.Location = new System.Drawing.Point(287, 274);
            this.btncancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(75, 32);
            this.btncancel.TabIndex = 36;
            this.btncancel.Text = "Close";
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.btncancel_Click);
            // 
            // txtNpassword
            // 
            this.txtNpassword.Location = new System.Drawing.Point(203, 155);
            this.txtNpassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNpassword.Name = "txtNpassword";
            this.txtNpassword.Size = new System.Drawing.Size(249, 22);
            this.txtNpassword.TabIndex = 35;
            // 
            // txtusename
            // 
            this.txtusename.Location = new System.Drawing.Point(203, 37);
            this.txtusename.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtusename.Name = "txtusename";
            this.txtusename.Size = new System.Drawing.Size(249, 22);
            this.txtusename.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "New Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Username :";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(16, 334);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 28);
            this.button2.TabIndex = 44;
            this.button2.Text = "<< Back";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Change
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(957, 377);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.pannelsearch);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnchange);
            this.Controls.Add(this.txtCNpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.txtNpassword);
            this.Controls.Add(this.txtusename);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Change";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change Password/Username";
            this.Load += new System.EventHandler(this.Change_Load);
            this.pannelsearch.ResumeLayout(false);
            this.pannelsearch.PerformLayout();
            this.pannelupdate.ResumeLayout(false);
            this.pannelupdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox pannelsearch;
        private System.Windows.Forms.GroupBox pannelupdate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtnewuser;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtuser;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnchange;
        private System.Windows.Forms.TextBox txtCNpassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtNpassword;
        private System.Windows.Forms.TextBox txtusename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}