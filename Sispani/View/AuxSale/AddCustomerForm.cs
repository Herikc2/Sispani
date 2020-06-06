using System;
using System.Windows.Forms;
using Sispani.Controller;
using Sispani.Model;

namespace Sispani.View
{
    public partial class AddCustomerForm : Form
    {
        public Customer Customer { get; set; }
        private SaleForm _sale;

        public AddCustomerForm()
        {
            InitializeComponent();  
        }

        public AddCustomerForm(SaleForm sale)
        {
            InitializeComponent();
            _sale = sale;
        }

        private void TxtCpfT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //Customer customer = new Customer("teste", "cpf");
                Customer customer = CustomerController.Select(txtCpfT.Text);
                if (customer != null)
                {
                    Customer = customer;
                    txtCpfT.Text = customer.CPF;
                    txtNameT.Text = customer.Name;
                    txtCpfT.Enabled = false;
                }
                else
                {
                    MessageBox.Show("O cliente não foi encontrado.",
                        "Cliente.",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    txtCpfT.Text = "";
                }
            }
        }

        private void BtnConfirmT_Click(object sender, EventArgs e)
        {
            if (Customer != null)
            {
                _sale.AddCustomer();
                Close();
            }
            else
            {
                MessageBox.Show("Adicione um cliente.");
            }
        }

        private void BtnCancelT_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Operação cancelada.");
            Close();
        }

        // --- INTERFACE ---

        private void TxtCpfT_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DoComCadastroCPF(e);
        }

        private void VerifyDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void DoComCadastroCPF(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtCpfT.Text.Length == 3)
                    txtCpfT.Text += '.';
                if (txtCpfT.Text.Length == 7)
                    txtCpfT.Text += '.';
                if (txtCpfT.Text.Length == 11)
                    txtCpfT.Text += '-';
                txtCpfT.Select(txtCpfT.Text.Length, 0);
            }
        }
    }
}
