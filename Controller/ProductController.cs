using Sispani.Model;
using System.Data;

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
            return ProductDAO.Insert(product);
        }

        public static bool Alter(Product product)
        {
            return ProductDAO.Alter(product);
        }

        public static bool Delete(string code)
        {
            return ProductDAO.Delete(code);
        }
    }
}
