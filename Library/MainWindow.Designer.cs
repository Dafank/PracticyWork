namespace Library
{
    partial class MainWindow
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.booksButton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.editButton = new System.Windows.Forms.Button();
            this.myBooksButton = new System.Windows.Forms.Button();
            this.myProfileButton = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(922, 75);
            this.panel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 21.75F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(391, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Library";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.booksButton);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.editButton);
            this.panel4.Controls.Add(this.myBooksButton);
            this.panel4.Controls.Add(this.myProfileButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 75);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(167, 353);
            this.panel4.TabIndex = 1;
            // 
            // booksButton
            // 
            this.booksButton.Location = new System.Drawing.Point(12, 127);
            this.booksButton.Name = "booksButton";
            this.booksButton.Size = new System.Drawing.Size(155, 50);
            this.booksButton.TabIndex = 4;
            this.booksButton.Text = "Books";
            this.booksButton.UseVisualStyleBackColor = true;
            this.booksButton.Click += new System.EventHandler(this.booksButton_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(1, 80);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(12, 50);
            this.panel5.TabIndex = 2;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(12, 223);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(155, 50);
            this.editButton.TabIndex = 4;
            this.editButton.Text = "Edit Data";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // myBooksButton
            // 
            this.myBooksButton.Location = new System.Drawing.Point(12, 175);
            this.myBooksButton.Name = "myBooksButton";
            this.myBooksButton.Size = new System.Drawing.Size(155, 50);
            this.myBooksButton.TabIndex = 3;
            this.myBooksButton.Text = "My Books";
            this.myBooksButton.UseVisualStyleBackColor = true;
            this.myBooksButton.Click += new System.EventHandler(this.myBooksButton_Click);
            // 
            // myProfileButton
            // 
            this.myProfileButton.Location = new System.Drawing.Point(12, 79);
            this.myProfileButton.Name = "myProfileButton";
            this.myProfileButton.Size = new System.Drawing.Size(155, 50);
            this.myProfileButton.TabIndex = 2;
            this.myProfileButton.Text = "My Profile";
            this.myProfileButton.UseVisualStyleBackColor = true;
            this.myProfileButton.Click += new System.EventHandler(this.myProfileButton_Click);
            // 
            // MainWindow
            // 
            this.ClientSize = new System.Drawing.Size(922, 428);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(938, 467);
            this.MinimumSize = new System.Drawing.Size(938, 467);
            this.Name = "MainWindow";
            this.Text = "Library";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button myBooksButton;
        private System.Windows.Forms.Button myProfileButton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button booksButton;
    }
}