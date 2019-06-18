namespace Command_Centre
{
    partial class Form1
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
            this.button_fireeye = new System.Windows.Forms.Button();
            this.label_title = new System.Windows.Forms.Label();
            this.button_checkuser = new System.Windows.Forms.Button();
            this.label_userexists = new System.Windows.Forms.Label();
            this.button_checkuser_reset = new System.Windows.Forms.Button();
            this.button_about = new System.Windows.Forms.Button();
            this.textbox_username = new System.Windows.Forms.TextBox();
            this.button_gethostname = new System.Windows.Forms.Button();
            this.label_hostname = new System.Windows.Forms.Label();
            this.button_gethostname_reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button_fireeye
            // 
            this.button_fireeye.Location = new System.Drawing.Point(13, 13);
            this.button_fireeye.Name = "button_fireeye";
            this.button_fireeye.Size = new System.Drawing.Size(75, 23);
            this.button_fireeye.TabIndex = 0;
            this.button_fireeye.Text = "Fix FireEye";
            this.button_fireeye.UseVisualStyleBackColor = true;
            this.button_fireeye.Click += new System.EventHandler(this.button_fireeye_Click);
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.Location = new System.Drawing.Point(367, 9);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(88, 13);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Command Centre";
            // 
            // button_checkuser
            // 
            this.button_checkuser.Location = new System.Drawing.Point(94, 12);
            this.button_checkuser.Name = "button_checkuser";
            this.button_checkuser.Size = new System.Drawing.Size(101, 23);
            this.button_checkuser.TabIndex = 3;
            this.button_checkuser.Text = "Check User Exists";
            this.button_checkuser.UseVisualStyleBackColor = true;
            this.button_checkuser.Click += new System.EventHandler(this.Button_checkuser_Click);
            // 
            // label_userexists
            // 
            this.label_userexists.AutoSize = true;
            this.label_userexists.Location = new System.Drawing.Point(94, 64);
            this.label_userexists.Name = "label_userexists";
            this.label_userexists.Size = new System.Drawing.Size(55, 13);
            this.label_userexists.TabIndex = 4;
            this.label_userexists.Text = "________";
            // 
            // button_checkuser_reset
            // 
            this.button_checkuser_reset.Location = new System.Drawing.Point(97, 80);
            this.button_checkuser_reset.Name = "button_checkuser_reset";
            this.button_checkuser_reset.Size = new System.Drawing.Size(75, 23);
            this.button_checkuser_reset.TabIndex = 5;
            this.button_checkuser_reset.Text = "Reset";
            this.button_checkuser_reset.UseVisualStyleBackColor = true;
            this.button_checkuser_reset.Click += new System.EventHandler(this.Button_checkuser_reset_Click);
            // 
            // button_about
            // 
            this.button_about.Location = new System.Drawing.Point(713, 9);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 23);
            this.button_about.TabIndex = 6;
            this.button_about.Text = "About";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.Button_about_Click);
            // 
            // textbox_username
            // 
            this.textbox_username.Location = new System.Drawing.Point(97, 41);
            this.textbox_username.Name = "textbox_username";
            this.textbox_username.Size = new System.Drawing.Size(100, 20);
            this.textbox_username.TabIndex = 7;
            this.textbox_username.Text = "adminSD";
            // 
            // button_gethostname
            // 
            this.button_gethostname.Location = new System.Drawing.Point(201, 12);
            this.button_gethostname.Name = "button_gethostname";
            this.button_gethostname.Size = new System.Drawing.Size(85, 23);
            this.button_gethostname.TabIndex = 8;
            this.button_gethostname.Text = "Get Hostname";
            this.button_gethostname.UseVisualStyleBackColor = true;
            this.button_gethostname.Click += new System.EventHandler(this.Button_gethostname_Click);
            // 
            // label_hostname
            // 
            this.label_hostname.AutoSize = true;
            this.label_hostname.Location = new System.Drawing.Point(203, 64);
            this.label_hostname.Name = "label_hostname";
            this.label_hostname.Size = new System.Drawing.Size(55, 13);
            this.label_hostname.TabIndex = 9;
            this.label_hostname.Text = "________";
            // 
            // button_gethostname_reset
            // 
            this.button_gethostname_reset.Location = new System.Drawing.Point(201, 80);
            this.button_gethostname_reset.Name = "button_gethostname_reset";
            this.button_gethostname_reset.Size = new System.Drawing.Size(75, 23);
            this.button_gethostname_reset.TabIndex = 10;
            this.button_gethostname_reset.Text = "Reset";
            this.button_gethostname_reset.UseVisualStyleBackColor = true;
            this.button_gethostname_reset.Click += new System.EventHandler(this.Button_gethostname_reset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_gethostname_reset);
            this.Controls.Add(this.label_hostname);
            this.Controls.Add(this.button_gethostname);
            this.Controls.Add(this.textbox_username);
            this.Controls.Add(this.button_about);
            this.Controls.Add(this.button_checkuser_reset);
            this.Controls.Add(this.label_userexists);
            this.Controls.Add(this.button_checkuser);
            this.Controls.Add(this.label_title);
            this.Controls.Add(this.button_fireeye);
            this.Name = "Form1";
            this.Text = "Command Centre";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_fireeye;
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Button button_checkuser;
        private System.Windows.Forms.Label label_userexists;
        private System.Windows.Forms.Button button_checkuser_reset;
        private System.Windows.Forms.Button button_about;
        private System.Windows.Forms.TextBox textbox_username;
        private System.Windows.Forms.Button button_gethostname;
        private System.Windows.Forms.Label label_hostname;
        private System.Windows.Forms.Button button_gethostname_reset;
    }
}

