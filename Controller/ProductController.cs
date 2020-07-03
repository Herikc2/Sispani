using Sispani.Model;
using Sispani.Model.DAO;
using System.Data;
using System.Windows.Forms;

namespace Sispani.Controller
{
    public class ProductController
    {
        public static DataTable Select()
        {
            return ProductDAO.Select(ProductDAO.CONSULTA_TOTAL);
        }

        public static Product Select(string code, string operacao)
        {
            return ProductDAO.Select(code, operacao);
        }

        public static bool Insert(Product product)
        {
            if (product.Code.Equals(""))
            {
                MessageBox.Show("Insira o código de barras.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (product.Amount.Equals(""))
            {
                MessageBox.Show("Insira a quantidade.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (product.Name.Equals(""))
            {
                MessageBox.Show("Insira o nome do produto.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (product.SalePrice.Equals(""))
            {
                MessageBox.Show("Insira o preço de venda.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return ProductDAO.Insert(product);
        }

        public static bool Alter(Product product)
        {
            if (product.Amount.Equals(""))
            {
                MessageBox.Show("Insira a quantidade.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (product.Name.Equals(""))
            {
                MessageBox.Show("Insira o nome do produto.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (product.SalePrice.Equals(""))
            {
                MessageBox.Show("Insira o preço de venda.", "Campo vazio",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return ProductDAO.Alter(product);
        }

        public static bool Delete(string code)
        {
            return ProductDAO.Delete(code);
        }
    }
}
