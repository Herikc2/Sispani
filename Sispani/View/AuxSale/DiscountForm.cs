using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sispani.View.AuxSale
{
    public partial class DiscountForm : Form
    {
        private bool _aplyDiscount = false;

        public string SelectedItem;
        public string Discount;

        public DiscountForm()
        {
            InitializeComponent();
        }

        public DiscountForm(DataTable source)
        {
            InitializeComponent();
            dgvProducts.DataSource = source;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SelectedItem = txtNumber.Text;
            if (txtDiscount.Text.Equals(",0") || txtDiscount.Text.Equals(",") ||
                txtDiscount.Text.Equals("0,"))
            {
                txtDiscount.Text = "";
            }
            Discount = txtDiscount.Text;
            if (SelectedItem.Equals("") || Discount.Equals(""))
            {
                MessageBox.Show("Preencha todos os campos.");
            }
            else
            {
                _aplyDiscount = true;
                Close();
            }
        }

        private void DiscountForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_aplyDiscount)
            {
                SaleForm sale = (SaleForm)Application.OpenForms[1];
                sale.DoDiscount();
            }
            else
            {
                MessageBox.Show("Desconto em item cancelado.");
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void txtDiscount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
                e.Handled = true;
        }
    }
}
