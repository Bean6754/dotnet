namespace Command_Centre
{
    partial class Form_License
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
            this.webbrowser_license = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // webbrowser_license
            // 
            this.webbrowser_license.AllowNavigation = false;
            this.webbrowser_license.AllowWebBrowserDrop = false;
            this.webbrowser_license.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webbrowser_license.Location = new System.Drawing.Point(0, 0);
            this.webbrowser_license.MinimumSize = new System.Drawing.Size(20, 20);
            this.webbrowser_license.Name = "webbrowser_license";
            this.webbrowser_license.Size = new System.Drawing.Size(800, 450);
            this.webbrowser_license.TabIndex = 0;
            this.webbrowser_license.WebBrowserShortcutsEnabled = false;
            // 
            // Form_License
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webbrowser_license);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Form_License";
            this.Text = "License";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webbrowser_license;
    }
}