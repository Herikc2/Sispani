using Sispani.Controller;
using Sispani.Model;
using System;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class ProductUC : UserControl
    {
        public ProductUC()
        {
            InitializeComponent();
        }

        private void ProductUC_Load(object sender, EventArgs e)
        {
            cboInsertUnity.SelectedItem = cboInsertUnity.Items[0];
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = ProductController.Select();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (ProductController.Insert(new Product(txtInsertCode.Text, txtInsertName.Text, 
                int.Parse(txtInsertAmount.Text), cboInsertUnity.SelectedItem.ToString(), 
                double.Parse(txtInsertCost.Text), double.Parse(txtInsertSell.Text))))
            {
                ClearInsert();
                UpdateDataGridView();
            }
        }

        private void CancelInsert_Click(object sender, EventArgs e)
        {
            ClearInsert();
        }

        private void CancelAlter_Click(object sender, EventArgs e)
        {
            ClearAlter();
            SetAlterEnables(false);
            btnAlter.Enabled = false;
            btnCancelAlter.Enabled = false;
        }

        private void Alter_Click(object sender, EventArgs e)
        {
            if (ProductController.Alter(new Product(txtInsertCode.Text, txtInsertName.Text,
                int.Parse(txtInsertAmount.Text), cboInsertUnity.SelectedItem.ToString(),
                double.Parse(txtInsertCost.Text), double.Parse(txtInsertSell.Text))))
            {
                ClearAlter();
                UpdateDataGridView();
                SetAlterEnables(false);
                btnAlter.Enabled = false;
                btnCancelAlter.Enabled = false;
            }
        }

        private void AlterCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Product product = ProductController.Select(txtDeleteCode.Text, ProductDAO.CONSULTA_TOTAL);
                if (product != null)
                {
                    txtAlterCode.Text = product.BarCode;
                    txtAlterName.Text = product.Description;
                    txtAlterAmount.Text = product.Stock.ToString();
                    txtAlterCost.Text = product.CostPrice.ToString();
                    txtAlterSell.Text = product.SalePrice.ToString();
                    cboAlterUnity.Text = product.Unity;

                    SetAlterEnables(true);
                    btnAlter.Enabled = true;
                    btnCancelAlter.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void SetAlterEnables(bool enable)
        {
            txtAlterCode.Enabled = !enable;
            txtAlterName.Enabled = enable;
            txtAlterAmount.Enabled = enable;
            txtAlterCost.Enabled = enable;
            txtAlterSell.Enabled = enable;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ProductController.Delete(txtDeleteCode.Text))
            {
                ClearDelete();
                UpdateDataGridView();
                btnDelete.Enabled = false;
                btnCancelDelete.Enabled = false;
            }
        }

        private void CancelDelete_Click(object sender, EventArgs e)
        {
            ClearDelete();
            btnDelete.Enabled = false;
            btnCancelDelete.Enabled = false;
        }

        private void DeleteCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Product product = ProductController.Select(txtDeleteCode.Text, ProductDAO.CONSULTA_TOTAL);
                if (product != null)
                {
                    txtDeleteCode.Text = product.BarCode;
                    txtDeleteName.Text = product.Description;
                    txtDeleteAmount.Text = product.Stock.ToString();
                    txtDeleteCost.Text = product.CostPrice.ToString();
                    txtDeleteSell.Text = product.SalePrice.ToString();
                    cboDeleteUnity.Text = product.Unity;

                    btnDelete.Enabled = true;
                    btnCancelDelete.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Produto não encontrado.", "Produto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ClearInsert()
        {
            txtInsertCode.Text = "";
            txtInsertName.Text = "";
            txtInsertAmount.Text = "";
            cboInsertUnity.SelectedIndex = 0;
            txtInsertCost.Text = "";
            txtInsertSell.Text = "";
        }

        private void ClearAlter()
        {
            txtAlterCode.Text = "";
            txtAlterName.Text = "";
            txtAlterAmount.Text = "";
            cboAlterUnity.Text = "";
            txtAlterCost.Text = "";
            txtAlterSell.Text = "";
        }

        private void ClearDelete()
        {
            txtDeleteCode.Text = "";
            txtDeleteName.Text = "";
            txtDeleteAmount.Text = "";
            cboDeleteUnity.Text = "";
            txtDeleteCost.Text = "";
            txtDeleteSell.Text = "";
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInsert();
            ClearAlter();
            ClearDelete();
        }
    }
}
