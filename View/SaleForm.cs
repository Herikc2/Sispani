using Sispani.Controller;
using Sispani.Model;
using Sispani.Model.DAO;
using Sispani.View.AuxSale;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class SaleForm : Form
    {
        public const string ITEM_NUMBER = "Nº";
        public const string CODE = "Código de Barras";
        public const string DESCRIPTION = "Descrição";
        public const string AMOUNT = "Qtd";
        public const string UNITY = "Un";
        public const string UN_VALUE = "Valor R$";
        public const string TOTAL_VALUE = "Total R$";

        public bool CustomerAdded = false;

        private AddCustomerForm _addCustomerForm;
        private FinalizeForm _finalizeForm;
        private DiscountForm _discountForm;
        private ItemCancelForm _itemCancelForm;
        private DataTable _source;
        private Customer _customer;

        public SaleForm()
        {
            InitializeComponent();
        }

        private void SaleForm_Load(object sender, EventArgs e)
        {
            NewSource();
        }

        private void NewSource()
        {
            _source = new DataTable();

            _source.Columns.Add(ITEM_NUMBER, typeof(string));
            _source.Columns.Add(CODE, typeof(string));
            _source.Columns.Add(DESCRIPTION, typeof(string));
            _source.Columns.Add(AMOUNT, typeof(string));
            _source.Columns.Add(UNITY, typeof(string));
            _source.Columns.Add(UN_VALUE, typeof(string));
            _source.Columns.Add(TOTAL_VALUE, typeof(string));

            dgvProducts.DataSource = _source;
        }

        private void UpdateLabels()
        {
            int amount = 0;
            var rows = _source.Rows;

            for (int i = 0; i < rows.Count; i++)
            {
                amount += int.Parse(rows[i][AMOUNT].ToString());
            }

            lblItemAmount.Text = amount.ToString();
            lblSubtotal.Text = SubTotal().ToString("N2");
            lblTotal.Text = Total().ToString("N2");
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            if (!CustomerAdded)
            {
                _addCustomerForm = new AddCustomerForm(this);
                _addCustomerForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Cliente já foi adicionado.");
            }
        }

        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            if (Total() <= 0)
            {
                MessageBox.Show("Adicione itens à venda.");
            }
            else
            {
                _finalizeForm = new FinalizeForm(Total());
                _finalizeForm.ShowDialog();
            }
        }

        public void FinalizePayment(string money, string card, string term)
        {
            SaleController.Insert(_source, _customer, money, card, term);
            Clear();
            MessageBox.Show("Venda finalizada com sucesso.");
        }

        public void FinalizePayment()
        {
            MessageBox.Show("Pagamento cancelado.");
        }

        private double SubTotal()
        {
            var rows = _source.Rows;
            var total = 0D;
            for (int i = 0; i < rows.Count; i++)
            {
                var cols = _source.Rows[i];
                total += double.Parse(cols[AMOUNT].ToString()) * double.Parse(cols[UN_VALUE].ToString());
            }
            return total;
        }

        private double Total()
        {
            var rows = _source.Rows;
            var total = 0D;
            for (int i = 0; i < rows.Count; i++)
            {
                var cols = _source.Rows[i];
                total += double.Parse(cols[TOTAL_VALUE].ToString());
            }
            return total;
        }

        private void BtnDiscount_Click(object sender, EventArgs e)
        {
            if (_source.Rows.Count <= 0)
            {
                MessageBox.Show("Não há itens para dar desconto.");
            }
            else
            {
                _discountForm = new DiscountForm(_source);
                _discountForm.Show();
            }
        }

        public void DoDiscount()
        {
            var selItem = int.Parse(_discountForm.SelectedItem);
            var disc = double.Parse(_discountForm.Discount);
            if (selItem >= _source.Rows.Count)
            {
                MessageBox.Show("Item inválido.");
                return;
            }
            var curVal = double.Parse(_source.Rows[selItem][TOTAL_VALUE].ToString());
            if (curVal - disc < 0)
            {
                MessageBox.Show("O desconto não pode ser maior que o valor total.");
                return;
            }
            _source.Rows[selItem][TOTAL_VALUE] = curVal - disc;
            lblDiscount.Text = (double.Parse(lblDiscount.Text) + disc).ToString();
            UpdateLabels();
            MessageBox.Show("Desconto aplicado.");
        }

        private void BtnCancelItem_Click(object sender, EventArgs e)
        {
            if (_source.Rows.Count <= 0)
            {
                MessageBox.Show("Não há itens para excluir.");
            }
            else
            {
                _itemCancelForm = new ItemCancelForm(_source);
                _itemCancelForm.Show();
            }
        }

        public void Delete()
        {
            var selItem = int.Parse(_itemCancelForm.SelectedItem);
            if (selItem >= _source.Rows.Count)
            {
                MessageBox.Show("Item inválido.");
                return;
            }
            _source.Rows[selItem].Delete();
            var rows = _source.Rows;
            for (int i = 0; i < rows.Count; i++)
            {
                rows[i][ITEM_NUMBER] = i;
            }
            UpdateLabels();
            MessageBox.Show("Item excluído.");
        }

        public void AddCustomer()
        {
            CustomerAdded = true;
            _customer = _addCustomerForm.Customer;
            lblCustomerName.Text = _customer.Name;
            lblCustomerCPF.Text = _customer.CPF;
            gbCustomer.Visible = true;
        }

        private void BtnCancelSale_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Venda cancelada.");
            Close();
        }

        private void TxtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Product product = ProductController.Select(txtCode.Text, ProductDAO.CONSULTA_VENDA);
                if (product != null)
                {
                    DataRow cols = _source.NewRow();
                    cols[ITEM_NUMBER] = _source.Rows.Count;
                    cols[CODE] = product.Code;
                    cols[DESCRIPTION] = product.Name;
                    cols[AMOUNT] = txtAmount.Text;
                    cols[UNITY] = product.Unity;
                    cols[UN_VALUE] = product.SalePrice.ToString("N2");
                    cols[TOTAL_VALUE] = (product.SalePrice * double.Parse(txtAmount.Text)).ToString("N2");
                    _source.Rows.Add(cols);

                    txtAmount.Text = "1";
                    txtCode.Text = "";

                    int tempX = lblTotal.Width;
                    UpdateLabels();
                    FormatDataTable();
                    lblTotal.Location = new Point(lblTotal.Location.X - Math.Abs((tempX - lblTotal.Width)), lblTotal.Location.Y);
                    lblCifraoTotal.Location = new Point(lblCifraoTotal.Location.X - Math.Abs((tempX - lblTotal.Width)), lblCifraoTotal.Location.Y);
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.");
                }
            }
        }

        private void FormatDataTable()
        {
            //dgvProducts.Columns[ITEM_NUMBER].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvProducts.Columns[CODE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvProducts.Columns[DESCRIPTION].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvProducts.Columns[AMOUNT].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvProducts.Columns[UNITY].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvProducts.Columns[UN_VALUE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvProducts.Columns[TOTAL_VALUE].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void Clear()
        {
            int tempX = lblTotal.Width;
            NewSource();
            lblDiscount.Text = "0,00";
            lblItemAmount.Text = "0";
            lblSubtotal.Text = "0,00";
            lblTotal.Text = "0,00";
            //picProduct.Image = "";
            txtAmount.Text = "1";
            txtCode.Text = "";
            lblCustomerCPF.Text = "";
            lblCustomerName.Text = "";
            gbCustomer.Visible = false;
            _addCustomerForm = null;
            _finalizeForm = null;
            _customer = null;
            CustomerAdded = false;

            lblTotal.Location = new Point(lblTotal.Location.X + Math.Abs((tempX - lblTotal.Width)), lblTotal.Location.Y);
            lblCifraoTotal.Location = new Point(lblCifraoTotal.Location.X + Math.Abs((tempX - lblTotal.Width)), lblCifraoTotal.Location.Y);
        }

        private void TxtAmount_Leave(object sender, EventArgs e)
        {
            if (txtAmount.Text.Equals(""))
            {
                txtAmount.Text = "1";
            }
        }

        private void VerifyDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void TxtAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
        }

        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            CustomerAdded = false;
            _customer = null;
            lblCustomerName.Text = "";
            lblCustomerCPF.Text = "";
            gbCustomer.Visible = false;
            MessageBox.Show("Cliente excluído da venda.");
        }
    }
}
