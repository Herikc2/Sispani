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
    public partial class ItemCancelForm : Form
    {
        private bool _delete = false;

        public string SelectedItem;

        public ItemCancelForm()
        {
            InitializeComponent();
        }

        public ItemCancelForm(DataTable source)
        {
            InitializeComponent();
            dgvProducts.DataSource = source;
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            SelectedItem = txtNumber.Text;
            if (SelectedItem.Equals(""))
            {
                MessageBox.Show("Digite o item a ser excluído.");
            }
            else
            {
                _delete = true;
                Close();
            }
        }

        private void ItemCamcelForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_delete)
            {
                SaleForm sale = (SaleForm)Application.OpenForms[1];
                sale.Delete();
            }
            else
            {
                MessageBox.Show("Nenhum item foi excluído.");
            }
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }
    }
}
