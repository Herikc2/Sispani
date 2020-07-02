using System;
using System.Windows.Forms;
using Sispani.View.AuxProgram;

namespace Sispani.View
{
    public partial class ProgramForm : Form
    {
        private LoginForm _login;

        public ProgramForm()
        {
            InitializeComponent();
        }

        private void FormProgram_Load(object sender, EventArgs e)
        {
            _login = new LoginForm();
            _login.ShowDialog();
        }

        public void LoginExit()
        {
            Application.Exit();
        }

        public void LoginLoad()
        {
            ucMain.LoadGraphic();

            // Carregamento dos dados
            lblTradeName.Text = "Nome Fantasia";
            lblCompanyName.Text = "Nome Jurídico";
            lblCNPJ.Text = "CNPJ " + "000.000.000/0000-00";

            labelVersion.Text = "1.0.0";

            // Carregamentos das User Control
            // enables
            ucHelp.Enabled = false;
            ucCustomer.Enabled = false;
            ucProduct.Enabled = false;
            ucReport.Enabled = false;
            ucBill.Enabled = false;
            // escondendo
            ucHelp.Hide();
            ucCustomer.Hide();
            ucProduct.Hide();
            ucReport.Hide();
            ucBill.Hide();
            //user control inicial
            ucMain.Enabled = true;
            ucMain.BringToFront();
            ucMain.Show();
        }

        private void ButtonVenda_Click(object sender, EventArgs e)
        {
            new SaleForm().ShowDialog();
        }

        private void ButtonProdutos_Click(object sender, EventArgs e)
        {
            if (ucProduct.Enabled)
            {
                ucProduct.Enabled = false;
                ucProduct.Hide();

                // mostrar user control inicial
                ucMain.Show();
            }
            else
            {
                ucProduct.Enabled = true;
                ucProduct.Show();
                ucProduct.BringToFront();

                // esconder outras
                ucHelp.Enabled = false;
                ucCustomer.Enabled = false;
                ucReport.Enabled = false;
                ucBill.Enabled = false;
                ucMain.Hide();
                ucCustomer.Hide();
                ucHelp.Hide();
                ucReport.Hide();
                ucBill.Hide();
            }
        }

        private void ButtonClientes_Click(object sender, EventArgs e)
        {
            if (ucCustomer.Enabled)
            {
                ucCustomer.Enabled = false;
                ucCustomer.Hide();

                // mostrar user control inicial
                ucMain.Show();
            }
            else
            {
                ucCustomer.Enabled = true;
                ucCustomer.Show();
                ucCustomer.BringToFront();

                // esconder outras
                ucHelp.Enabled = false;
                ucProduct.Enabled = false;
                ucReport.Enabled = false;
                ucBill.Enabled = false;
                ucMain.Hide();
                ucHelp.Hide();
                ucProduct.Hide();
                ucReport.Hide();
                ucBill.Hide();
            }
        }

        private void ButtonRelatorio_Click(object sender, EventArgs e)
        {
            if (ucReport.Enabled)
            {
                ucReport.Enabled = false;
                ucReport.Hide();

                // mostrar user control inicial
                ucMain.Show();
            }
            else
            {
                ucReport.InitialData();
                ucReport.Enabled = true;
                ucReport.Show();
                ucReport.BringToFront();

                // esconder outras
                ucHelp.Enabled = false;
                ucCustomer.Enabled = false;
                ucProduct.Enabled = false;
                ucBill.Enabled = false;
                ucMain.Hide();
                ucCustomer.Hide();
                ucProduct.Hide();
                ucHelp.Hide();
                ucBill.Hide();
            }
        }

        private void ButtonAjuda_Click(object sender, EventArgs e)
        {
            if (ucHelp.Enabled)
            {
                ucHelp.Enabled = false;
                ucHelp.Hide();

                // mostrar user control inicial
                ucMain.Show();
            }
            else
            {
                ucHelp.Enabled = true;
                ucHelp.Show();
                ucHelp.BringToFront();

                // esconder outras
                ucCustomer.Enabled = false;
                ucProduct.Enabled = false;
                ucReport.Enabled = false;
                ucBill.Enabled = false;
                ucMain.Hide();
                ucCustomer.Hide();
                ucProduct.Hide();
                ucReport.Hide();
                ucBill.Hide();
            }
        }

        private void PictureBoxLogo_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sispani.wixsite.com/home");
        }

        private void PictureBoxLogoNome_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://sispani.wixsite.com/home");
        }

        private void buttonContaCliente_Click(object sender, EventArgs e)
        {
            if (ucBill.Enabled)
            {
                ucBill.Enabled = false;
                ucBill.Hide();

                // mostrar user control inicial
                ucMain.Show();
            }
            else
            {
                ucBill.Enabled = true;
                ucBill.Show();
                ucBill.BringToFront();

                // esconder outras
                ucCustomer.Enabled = false;
                ucProduct.Enabled = false;
                ucReport.Enabled = false;
                ucHelp.Enabled = false;
                ucMain.Hide();
                ucCustomer.Hide();
                ucProduct.Hide();
                ucReport.Hide();
                ucHelp.Hide();
            }
        }
    }
}
