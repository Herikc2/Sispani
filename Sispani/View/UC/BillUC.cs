using Sispani.Controller;
using Sispani.Model;
using Sispani.Model.Class;
using Sispani.View.AuxBill;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class BillUC : UserControl
    {
        public Customer Customer;

        public BillUC()
        {
            InitializeComponent();
        }

        private void TxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtCPF.Text.Length == 3)
                    txtCPF.Text += '.';
                if (txtCPF.Text.Length == 7)
                    txtCPF.Text += '.';
                if (txtCPF.Text.Length == 11)
                    txtCPF.Text += '-';
                txtCPF.Select(txtCPF.Text.Length, 0);
            }
        }

        private void TxtCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Customer = CustomerController.SelectBill(txtCPF.Text);
                if (Customer != null)
                {
                    txtCPF.Enabled = false;
                    btnCancel.Enabled = true;
                    btnPay.Enabled = true;
                    //
                    txtName.Text = Customer.Name;
                    txtCPF.Text = Customer.CPF;
                    // recuperar dt
                    double total = 0D;
                    DataTable source = new DataTable();
                    source.Columns.Add("Data", typeof(DateTime));
                    source.Columns.Add("Total", typeof(string));
                    foreach (BillItem bi in Customer.Bill.Items)
                    {
                        source.Rows.Add(bi.Date, bi.Total.ToString("N2"));
                        total += bi.Total;
                    }
                    dataGridView.DataSource = source;
                    lblTotal.Text = total.ToString("N2");
                }
                else
                {
                    MessageBox.Show("O CPF informado não foi encontrado.",
                                    "Não encontrado",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                    txtCPF.Text = "";
                }
            }
        }

        private void BtnPay_Click(object sender, EventArgs e)
        {
            new PaymentForm(this).Show();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void FinalizePayment()
        {
            MessageBox.Show("O pagamento foi cancelado.",
                "Pagamento cancelado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Exclamation);
        }

        public void FinalizePayment(string money, string card)
        {
            SaleController.Insert(DateTime.Now, Customer, money, card);
            Clear();

            MessageBox.Show("O pagamento foi realizado com sucesso.",
                "Sucesso",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void Clear()
        {
            txtName.Text = "";
            txtCPF.Text = "";
            // limpar dt
        }
    }
}
