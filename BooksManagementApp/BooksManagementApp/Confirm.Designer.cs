namespace BooksManagementApp
{
    partial class Confirm
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
            this.btnconfirm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnconfirm
            // 
            this.btnconfirm.BackColor = System.Drawing.Color.SkyBlue;
            this.btnconfirm.Location = new System.Drawing.Point(325, 193);
            this.btnconfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnconfirm.Name = "btnconfirm";
            this.btnconfirm.Size = new System.Drawing.Size(100, 28);
            this.btnconfirm.TabIndex = 12;
            this.btnconfirm.Text = "Confirm";
            this.btnconfirm.UseVisualStyleBackColor = false;
            this.btnconfirm.Click += new System.EventHandler(this.btnconfirm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(125, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Comfirm Code: Hint [123]";
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(129, 148);
            this.txtconfirm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.Size = new System.Drawing.Size(297, 22);
            this.txtconfirm.TabIndex = 10;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(1, 331);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(583, 28);
            this.progressBar.TabIndex = 9;
            // 
            // Confirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(587, 363);
            this.Controls.Add(this.btnconfirm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.progressBar);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Confirm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirm Login Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnconfirm;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}