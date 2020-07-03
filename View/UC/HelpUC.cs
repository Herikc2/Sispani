using System;
using System.Windows.Forms;

namespace Sispani.View.UC
{
    public partial class HelpUC : UserControl
    {
        public HelpUC()
        {
            InitializeComponent();
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sispani.wixsite.com/home");
        }

        private void PictureBoxLogoNome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sispani.wixsite.com/home");
        }
    }
}
