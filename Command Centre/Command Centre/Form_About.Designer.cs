namespace Command_Centre
{
    partial class Form_About
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
            this.button_license = new System.Windows.Forms.Button();
            this.button_github = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_license
            // 
            this.button_license.Location = new System.Drawing.Point(12, 12);
            this.button_license.Name = "button_license";
            this.button_license.Size = new System.Drawing.Size(75, 23);
            this.button_license.TabIndex = 3;
            this.button_license.Text = "License";
            this.button_license.UseVisualStyleBackColor = true;
            this.button_license.Click += new System.EventHandler(this.Button_license_Click);
            // 
            // button_github
            // 
            this.button_github.Location = new System.Drawing.Point(94, 13);
            this.button_github.Name = "button_github";
            this.button_github.Size = new System.Drawing.Size(75, 23);
            this.button_github.TabIndex = 4;
            this.button_github.Text = "GitHub";
            this.button_github.UseVisualStyleBackColor = true;
            this.button_github.Click += new System.EventHandler(this.Button_github_Click);
            // 
            // Form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_github);
            this.Controls.Add(this.button_license);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_About";
            this.Text = "About";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_license;
        private System.Windows.Forms.Button button_github;
    }
}