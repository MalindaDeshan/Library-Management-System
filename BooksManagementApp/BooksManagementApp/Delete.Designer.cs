namespace BooksManagementApp
{
    partial class Delete
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
            this.pannelsearch = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.pannelsearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // pannelsearch
            // 
            this.pannelsearch.Controls.Add(this.label5);
            this.pannelsearch.Controls.Add(this.btndelete);
            this.pannelsearch.Controls.Add(this.txtusername);
            this.pannelsearch.Location = new System.Drawing.Point(23, 49);
            this.pannelsearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelsearch.Name = "pannelsearch";
            this.pannelsearch.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pannelsearch.Size = new System.Drawing.Size(428, 209);
            this.pannelsearch.TabIndex = 32;
            this.pannelsearch.TabStop = false;
            this.pannelsearch.Text = "Delete Record";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 28;
            this.label5.Text = "Username :";
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.Color.SkyBlue;
            this.btndelete.Location = new System.Drawing.Point(249, 144);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(100, 28);
            this.btndelete.TabIndex = 27;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(125, 92);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(223, 22);
            this.txtusername.TabIndex = 29;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(12, 266);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 33;
            this.button1.Text = "<< Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 302);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pannelsearch);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Delete";
            this.Text = "Delete User Record";
            this.Load += new System.EventHandler(this.Delete_Load);
            this.pannelsearch.ResumeLayout(false);
            this.pannelsearch.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pannelsearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.Button button1;
    }
}