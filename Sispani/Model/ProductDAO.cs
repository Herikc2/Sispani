using Sispani.Model;
using Sispani.Model.Class.Validations;
using System;
using System.Collections.Generic;
using System.Data;

namespace Sispani.Controller
{
    public class ProductDAO
    {
        public const string CONSULTA_TOTAL = "0";
        public const string CONSULTA_VENDA = "1";

        public static DataTable Select(string operacao)
        {
            string cmd = "";
            if (operacao.Equals(CONSULTA_TOTAL))
                cmd = string.Format("select * from selecionar_todos_produtos()");
            else if (operacao.Equals(CONSULTA_VENDA))
                cmd = string.Format("select * from selecionar_todos_produtos_venda()");

            DataTable dt = GenericDAO.Select(cmd);

            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;
        }

        public static Product Select(string codigoBarras, string operacao)
        {
            string cmd = "";

            if (operacao.Equals(CONSULTA_TOTAL))
                cmd = string.Format("select * from selecionar_produto_venda('{0}')", codigoBarras);
            else if (operacao.Equals(CONSULTA_VENDA))
                cmd = string.Format("select * from selecionar_produto_venda('{0}')", codigoBarras);

            DataTable dt = GenericDAO.Select(cmd);

            if (dt != null)
            {
                if (dt.Rows.Count > 0)
                {
                    if (operacao.Equals(CONSULTA_TOTAL))
                    {
                        return new Product(dt.Rows[0]["codigo_barras"].ToString(), dt.Rows[0]["descricao"].ToString(), Int32.Parse(dt.Rows[0]["estoque"].ToString()),
                        dt.Rows[0]["unidade"].ToString(), Convert.ToDouble(dt.Rows[0]["preco_custo"].ToString()), Convert.ToDouble(dt.Rows[0]["preco_venda"].ToString()),
                        Convert.ToDouble(dt.Rows[0]["preco_venda"].ToString()) - Convert.ToDouble(dt.Rows[0]["preco_custo"].ToString()),
                        ((Convert.ToDouble(dt.Rows[0]["preco_venda"].ToString()) * 100) / Convert.ToDouble(dt.Rows[0]["preco_custo"].ToString())) - 100);
                    }
                    if (operacao.Equals(CONSULTA_VENDA))
                    {
                        return new Product(dt.Rows[0]["codigo_barras"].ToString(), dt.Rows[0]["descricao"].ToString(), Int32.Parse(dt.Rows[0]["estoque"].ToString()),
                        dt.Rows[0]["unidade"].ToString(), Convert.ToDouble(dt.Rows[0]["preco_venda"].ToString()));
                    }
                    return null;
                }
            }
            
            return null;
        }

        public static bool Insert(Product product)
        {
            if (!ValidatorProductMessage(product))
                return false;
            else
            {
                string cmd = string.Format("select * from inserir_produto('{0}','{1}','{2}','{3}','{4}','{5}')",
                        product.BarCode, product.Description, product.Stock, product.Unity, product.CostPrice, product.SalePrice);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool Alter(Product product)
        {
            if (!ValidatorProductMessage(product))
                return false;
            else
            {
                string cmd = string.Format("select * from alterar_produto('{0}','{1}','{2}','{3}','{4}','{5}')",
                        product.BarCode, product.Description, product.Stock, product.Unity, product.CostPrice, product.SalePrice);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool Delete(string barCode)
        {
            string cmd = string.Format("select * from excluir_produto('{0}')", barCode);
            return GenericDAO.genericBool(cmd);
        }

        private static bool ValidatorProductMessage(Product product)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(product.BarCode, "Código de Barras"));
            inputs.Add(new ValidationItem(product.Description, "Descriçao"));
            inputs.Add(new ValidationItem(product.Unity, "Unidade"));

            Validations val = new Validations();
            return val.ValidationCheck(inputs);
        }
    }
}
