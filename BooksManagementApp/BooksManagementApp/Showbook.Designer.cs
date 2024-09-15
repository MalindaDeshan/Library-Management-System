namespace BooksManagementApp
{
    partial class Showbook
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
            this.btnclose = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnshow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnclose.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnclose.Location = new System.Drawing.Point(149, 50);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(100, 28);
            this.btnclose.TabIndex = 5;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(29, 95);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(603, 279);
            this.dataGridView1.TabIndex = 4;
            // 
            // btnshow
            // 
            this.btnshow.BackColor = System.Drawing.Color.SkyBlue;
            this.btnshow.Location = new System.Drawing.Point(29, 50);
            this.btnshow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(100, 28);
            this.btnshow.TabIndex = 3;
            this.btnshow.Text = "Show";
            this.btnshow.UseVisualStyleBackColor = false;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(556, 15);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 32;
            this.button1.Text = "<< Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Showbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(672, 406);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnshow);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Showbook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Here Books";
            this.Load += new System.EventHandler(this.Showbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button button1;
    }
}