namespace BooksManagementApp
{
    partial class Home
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertBooksDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkStudentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hereBooksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUserNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutUsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeToolStripMenuItem,
            this.settingToolStripMenuItem,
            this.aboutUsToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1106, 36);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.insertBooksDetailsToolStripMenuItem,
            this.insertStudentDetailsToolStripMenuItem,
            this.checkStudentDetailsToolStripMenuItem,
            this.hereBooksToolStripMenuItem});
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(82, 32);
            this.homeToolStripMenuItem.Text = "Home";
            this.homeToolStripMenuItem.Click += new System.EventHandler(this.homeToolStripMenuItem_Click);
            // 
            // insertBooksDetailsToolStripMenuItem
            // 
            this.insertBooksDetailsToolStripMenuItem.Name = "insertBooksDetailsToolStripMenuItem";
            this.insertBooksDetailsToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.insertBooksDetailsToolStripMenuItem.Text = "Insert Books Details";
            this.insertBooksDetailsToolStripMenuItem.Click += new System.EventHandler(this.insertBooksDetailsToolStripMenuItem_Click);
            // 
            // insertStudentDetailsToolStripMenuItem
            // 
            this.insertStudentDetailsToolStripMenuItem.Name = "insertStudentDetailsToolStripMenuItem";
            this.insertStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.insertStudentDetailsToolStripMenuItem.Text = "Insert Student Details";
            this.insertStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.insertStudentDetailsToolStripMenuItem_Click);
            // 
            // checkStudentDetailsToolStripMenuItem
            // 
            this.checkStudentDetailsToolStripMenuItem.Name = "checkStudentDetailsToolStripMenuItem";
            this.checkStudentDetailsToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.checkStudentDetailsToolStripMenuItem.Text = "Check Student Details";
            this.checkStudentDetailsToolStripMenuItem.Click += new System.EventHandler(this.checkStudentDetailsToolStripMenuItem_Click);
            // 
            // hereBooksToolStripMenuItem
            // 
            this.hereBooksToolStripMenuItem.Name = "hereBooksToolStripMenuItem";
            this.hereBooksToolStripMenuItem.Size = new System.Drawing.Size(297, 32);
            this.hereBooksToolStripMenuItem.Text = "Here Books";
            this.hereBooksToolStripMenuItem.Click += new System.EventHandler(this.hereBooksToolStripMenuItem_Click);
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeUserNameToolStripMenuItem,
            this.changePasswordToolStripMenuItem,
            this.changeUToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(91, 32);
            this.settingToolStripMenuItem.Text = "Setting";
            // 
            // changeUserNameToolStripMenuItem
            // 
            this.changeUserNameToolStripMenuItem.Name = "changeUserNameToolStripMenuItem";
            this.changeUserNameToolStripMenuItem.Size = new System.Drawing.Size(356, 32);
            this.changeUserNameToolStripMenuItem.Text = "Add UserName/Password";
            this.changeUserNameToolStripMenuItem.Click += new System.EventHandler(this.changeUserNameToolStripMenuItem_Click);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(356, 32);
            this.changePasswordToolStripMenuItem.Text = "Change Password/username";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // changeUToolStripMenuItem
            // 
            this.changeUToolStripMenuItem.Name = "changeUToolStripMenuItem";
            this.changeUToolStripMenuItem.Size = new System.Drawing.Size(356, 32);
            this.changeUToolStripMenuItem.Text = "Delete username/password";
            this.changeUToolStripMenuItem.Click += new System.EventHandler(this.changeUToolStripMenuItem_Click);
            // 
            // aboutUsToolStripMenuItem
            // 
            this.aboutUsToolStripMenuItem.Name = "aboutUsToolStripMenuItem";
            this.aboutUsToolStripMenuItem.Size = new System.Drawing.Size(109, 32);
            this.aboutUsToolStripMenuItem.Text = "About us";
            this.aboutUsToolStripMenuItem.Click += new System.EventHandler(this.aboutUsToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toWindowsToolStripMenuItem});
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(58, 32);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // toWindowsToolStripMenuItem
            // 
            this.toWindowsToolStripMenuItem.Name = "toWindowsToolStripMenuItem";
            this.toWindowsToolStripMenuItem.Size = new System.Drawing.Size(209, 32);
            this.toWindowsToolStripMenuItem.Text = "To Windows";
            this.toWindowsToolStripMenuItem.Click += new System.EventHandler(this.toWindowsToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BooksManagementApp.Properties.Resources.blog5;
            this.pictureBox1.Location = new System.Drawing.Point(13, 53);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1080, 535);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(147, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(812, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "WELCOME TO WORLD OF BOOKS";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 603);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertBooksDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem insertStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkStudentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hereBooksToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUserNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutUsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toWindowsToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}