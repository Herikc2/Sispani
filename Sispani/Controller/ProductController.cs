using Sispani.Model;

namespace Sispani.Controller
{
    public class ProductController
    {
        public static Product Select(string code, string operacao)
        {
            return ProductDAO.Select(code, operacao);
        }
    }
}
