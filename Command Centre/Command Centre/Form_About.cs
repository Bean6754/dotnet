using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Command_Centre
{
    public partial class Form_About : Form
    {
        public Form_About()
        {
            InitializeComponent();
        }

        private void Button_license_Click(object sender, EventArgs e)
        {
            Form_License licenseForm = new Form_License();
            licenseForm.Show();
        }

        private void Button_github_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Bean6754");
        }
    }
}
