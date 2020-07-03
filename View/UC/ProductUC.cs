using Sispani.Controller;
using Sispani.Model;
using Sispani.Model.DAO;
using System;
using System.Windows.Forms;

namespace Sispani.View.UC
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
            dataGridView.DataSource = ProductController.Select();
        }

        private void UpdateDataGridView()
        {
            dataGridView.DataSource = ProductController.Select();
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            if (ProductController.Insert(new Product(txtInsertCode.Text, txtInsertName.Text, 
                int.Parse(txtInsertAmount.Text), cboInsertUnity.Text.ToString(), 
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
        }

        private void Alter_Click(object sender, EventArgs e)
        {
            if (ProductController.Alter(new Product(txtAlterCode.Text, txtAlterName.Text,
                int.Parse(txtAlterAmount.Text), cboAlterUnity.Text.ToString(),
                double.Parse(txtAlterCost.Text), double.Parse(txtAlterSell.Text))))
            {
                ClearAlter();
                UpdateDataGridView();
                SetAlterEnables(false);
            }
        }

        private void AlterCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Product product = ProductController.Select(txtAlterCode.Text, ProductDAO.CONSULTA_TOTAL);
                if (product != null)
                {
                    txtAlterCode.Text = product.Code;
                    txtAlterName.Text = product.Name;
                    txtAlterAmount.Text = product.Amount.ToString();
                    txtAlterCost.Text = product.CostPrice.ToString();
                    txtAlterSell.Text = product.SalePrice.ToString();
                    cboAlterUnity.Text = product.Unity;

                    SetAlterEnables(true);
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
            btnAlter.Enabled = enable;
            btnCancelAlter.Enabled = enable;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (ProductController.Delete(txtDeleteCode.Text))
            {
                ClearDelete();
                UpdateDataGridView();
            }
        }

        private void CancelDelete_Click(object sender, EventArgs e)
        {
            ClearDelete();
        }

        private void DeleteCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Enter))
            {
                Product product = ProductController.Select(txtDeleteCode.Text, ProductDAO.CONSULTA_TOTAL);
                if (product != null)
                {
                    txtDeleteCode.Text = product.Code;
                    txtDeleteName.Text = product.Name;
                    txtDeleteAmount.Text = product.Amount.ToString();
                    txtDeleteCost.Text = product.CostPrice.ToString();
                    txtDeleteSell.Text = product.SalePrice.ToString();
                    cboDeleteUnity.Text = product.Unity;

                    txtDeleteCode.Enabled = false;
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
            SetAlterEnables(false);
            btnAlter.Enabled = false;
            btnCancelAlter.Enabled = false;
        }

        private void ClearDelete()
        {
            txtDeleteCode.Text = "";
            txtDeleteName.Text = "";
            txtDeleteAmount.Text = "";
            cboDeleteUnity.Text = "";
            txtDeleteCost.Text = "";
            txtDeleteSell.Text = "";
            txtDeleteCode.Enabled = true;
            btnDelete.Enabled = false;
            btnCancelDelete.Enabled = false;
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClearInsert();
            ClearAlter();
            ClearDelete();
        }

        private void VerifyDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void VerifyDigitDot(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ',')
                e.Handled = true;
        }

        private void InsertAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
        }

        private void InsertCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigitDot(e);
        }

        private void InsertSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigitDot(e);
        }

        private void AlterAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
        }

        private void AlterCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigitDot(e);
        }

        private void AlterSell_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigitDot(e);
        }
    }
}
