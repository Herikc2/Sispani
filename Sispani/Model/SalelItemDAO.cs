using Sispani.Model.Class;
using Sispani.Model.Class.Validations;
using System.Collections.Generic;
using System.Data;

namespace Sispani.Model
{
    class SalelItemDAO
    {
        
        public static DataTable Select(string id_venda)
        {
            string cmd = string.Format("select * from selecionar_todos_item_venda('{0}')", id_venda);
            DataTable dt = GenericDAO.Select(cmd);

            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;
        }
        
        public static bool Insert(SaleItem saleItem)
        {
            if (!ValidatorSaleItemMessage(saleItem))
                return false;
            else
            {
                string cmd = string.Format("select * from inserir_item_venda('{0}','{1}','{2}')",
                        saleItem.VendaID, saleItem.ProdutoCodigoBarras, saleItem.Quantidade);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool MultiInsertManual(List<SaleItem> saleItem)
        {
            for (int i = 0; i < saleItem.Count; i++)
            {
                if (!ValidatorSaleItemMessage(saleItem[i]))
                    return false;
                else
                {
                    string cmd = string.Format("select * from inserir_item_venda('{0}','{1}','{2}')",
                            saleItem[i].VendaID, saleItem[i].ProdutoCodigoBarras, saleItem[i].Quantidade);
                    GenericDAO.genericBool(cmd);
                }
            }
            return true;
        }

        public static bool MultiInsertAuto(List<SaleItem> saleItem)
        {
            for (int i = 0; i < saleItem.Count; i++)
                if (!ValidatorSaleItemMessage(saleItem[i]))
                    return false;

            string ArrayProdutoCodigoBarras = "{";
            string ArrayQuantidade = "{";

            for (int i = 0; i < saleItem.Count; i++)
            {
                ArrayProdutoCodigoBarras += saleItem[i].ProdutoCodigoBarras;
                ArrayQuantidade += saleItem[i].Quantidade.ToString();
                int temp = i + 1;

                if (temp < saleItem.Count)
                {
                    ArrayProdutoCodigoBarras += ",";
                    ArrayQuantidade += ",";
                }
            }

            ArrayProdutoCodigoBarras += "}";
            ArrayQuantidade += "}";

            string cmd = string.Format("select * from inserir_item_venda_multi('{0}','{1}','{2}')",
                    saleItem[0].VendaID, ArrayProdutoCodigoBarras, ArrayQuantidade);
            
            return GenericDAO.genericBool(cmd);
        }

        public static bool Alter(SaleItem saleItem)
        {
            if (!ValidatorSaleItemMessage(saleItem))
                return false;
            else
            {
                string cmd = string.Format("select * from inserir_item_venda('{0}','{1}')",
                        saleItem.ID, saleItem.Quantidade);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool Delete(string id)
        {
            string cmd = string.Format("select * from excluir_item_venda('{0}')", id);
            return GenericDAO.genericBool(cmd);
        }

        private static bool ValidatorSaleItemMessage(SaleItem saleItem)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(saleItem.ID, "ID"));
            inputs.Add(new ValidationItem(saleItem.VendaID, "Venda ID"));
            inputs.Add(new ValidationItem(saleItem.ProdutoCodigoBarras, "Produto Codigo De Barras"));

            Validations val = new Validations();
            return val.ValidationCheck(inputs);      
        }
    }
}
