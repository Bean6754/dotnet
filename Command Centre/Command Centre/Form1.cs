using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
// Process starting.
using System.Diagnostics;
// User Accounts.
/*
 * Add "C:\Program Files\Reference Assemblies\Microsoft\Framework.NETFramework\v4.n"
* -System.DirectoryServices.dll
* -System.DirectoryServices.AccountManagement.dll
* to References.
*/
using System.DirectoryServices;
// using System.DirectoryServices.AccountManagement;

namespace Command_Centre
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Anchors.
            label_title.Anchor = (AnchorStyles.Top);
            button_fireeye.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            button_about.Anchor = (AnchorStyles.Top | AnchorStyles.Right);
        }

        private void button_fireeye_Click(object sender, EventArgs e)
        {
            ProcessStartInfo info = new ProcessStartInfo();
            info.FileName = "powershell.exe";
            info.UseShellExecute = true;
            info.Verb = "runas"; // Provides Run as Administrator
            info.Arguments = @"Disable-ScheduledTask -TaskPath '\Microsoft\Windows\Application Experience\' -TaskName 'Microsoft Compatibility Appraiser';
Disable-ScheduledTask -TaskPath '\Microsoft\Windows\Application Experience\' -TaskName 'ProgramDataUpdater';
Disable-ScheduledTask -TaskPath '\Microsoft\Windows\Application Experience\' -TaskName 'StartupAppTask';
Disable-ScheduledTask -TaskPath '\Microsoft\Windows\Autochk\' -TaskName 'Proxy';
Disable-ScheduledTask -TaskPath '\Microsoft\Windows\Customer Experience Improvement Program\' -TaskName 'Consolidator';
Disable-ScheduledTask -TaskPath '\Microsoft\Windows\Customer Experience Improvement Program\' -TaskName 'UsbCeip'
";

            if (Process.Start(info) != null)
            {
                // The user accepted the UAC prompt.
            }
        }

        private void Button_checkuser_Click(object sender, EventArgs e)
        {
            DirectoryEntry dirEntryLocalMachine = new DirectoryEntry("WinNT://" + Environment.MachineName + ",computer");
            try
            {
                string UserExists = dirEntryLocalMachine.Children.Find(textbox_username.Text).ToString();
                label_userexists.Text = "User exists.";
            }
            catch
            {
                label_userexists.Text = "User does not exist.";
            }
        }

        private void Button_checkuser_reset_Click(object sender, EventArgs e)
        {
            label_userexists.Text = "________"; // ¬_¬
        }

        private void Button_about_Click(object sender, EventArgs e)
        {
            Form_About aboutForm = new Form_About();
            aboutForm.Show();
        }

        private void Button_gethostname_Click(object sender, EventArgs e)
        {
            label_hostname.Text = System.Environment.MachineName;
        }

        private void Button_gethostname_reset_Click(object sender, EventArgs e)
        {
            label_hostname.Text = "________"; // ¬_¬
        }
    }
}
