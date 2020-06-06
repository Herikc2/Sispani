using Npgsql;
using Sispani.Model;
using Sispani.Model.Class;
using Sispani.Model.Class.Validations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Windows;

namespace Sispani.Controller
{
    public class SaleDAO
    {

        public static DataTable Select()
        {
            string cmd = string.Format("select * from selecionar_todas_vendas()");
            return GenericDAO.Select(cmd); 
        }

        public static Sale Select(string id)
        {
            string cmd = string.Format("select * from selecionar_venda('{0}')", id);
            DataTable dt = GenericDAO.Select(cmd);

            if (dt.Rows.Count > 0)
                return new Sale(dt.Rows[0]["id"].ToString(), Convert.ToDateTime(dt.Rows[0]["data"].ToString()), new Customer(dt.Rows[0]["nome"].ToString(), dt.Rows[0]["pessoa_cpf"].ToString()),
                    Convert.ToDouble(dt.Rows[0]["total_dinheiro"].ToString()), Convert.ToDouble(dt.Rows[0]["total_cartao"].ToString()),
                    Convert.ToDouble(dt.Rows[0]["valor_total"].ToString()));
            else
                return null;
        }

        public static DataTable Select(DateTime start, DateTime end)
        {
            string cmd = string.Format("select * from selecionar_todas_vendas_periodo('{0}','{1}')", start, end);
            return GenericDAO.Select(cmd);
        }

        public static bool Insert(BillItem billItem)
        {
            if (!ValidatorSaleMessage(billItem.sale))
                return false;

            DataTable dt = new DataTable();

            try
            {
                using (DAO.PgsqlConnection = new NpgsqlConnection(DAO.ConnString))
                {
                    //Abra a conexão com o PgSQL
                    DAO.PgsqlConnection.Open();

                    string inserirVendaCMD = string.Format("select * from inserir_venda('{0}','{1}','{2}','{3}')",
                        billItem.sale.Customer.CPF, billItem.sale.Date,
                        billItem.sale.TotalMoney.ToString("N", CultureInfo.CreateSpecificCulture("en-US")), 
                        billItem.sale.TotalCard.ToString("N", CultureInfo.CreateSpecificCulture("en-US")));

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(inserirVendaCMD, DAO.PgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        billItem.sale.ID = dt.Rows[0]["inserir_venda"].ToString(); // Captura ID da venda
                        for (int i = 0; i < billItem.sale.SaleItem_.Count; i++)
                            billItem.sale.SaleItem_[i].VendaID = billItem.sale.ID;

                        SalelItemDAO.MultiInsertAuto(billItem.sale.SaleItem_);

                        string inserirItemContaCMD = string.Format("select * from inserir_item_conta('{0}','{1}','{2}')",
                        billItem.sale.ID, billItem.sale.Customer.CPF, 
                        billItem.Total.ToString("N", CultureInfo.CreateSpecificCulture("en-US")));

                        return GenericDAO.genericBool(inserirItemContaCMD);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Sofware",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            finally
            {
                DAO.PgsqlConnection.Close();
            }

            return false;
        }

        public static bool Insert(Sale sale)
        {
            if (!ValidatorSaleMessage(sale))
                return false;

            DataTable dt = new DataTable();

            try
            {
                using (DAO.PgsqlConnection = new NpgsqlConnection(DAO.ConnString))
                {
                    //Abra a conexão com o PgSQL
                    DAO.PgsqlConnection.Open();

                    if (sale.Customer is null)
                        sale.Customer = new Customer(null, null);

                    string cmd = string.Format("select * from inserir_venda('{0}','{1}','{2}','{3}')",
                        sale.Customer.CPF, sale.Date, 
                        sale.TotalMoney.ToString("N", CultureInfo.CreateSpecificCulture("en-US")),
                        sale.TotalCard.ToString("N", CultureInfo.CreateSpecificCulture("en-US")));

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd, DAO.PgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }        

                    if (dt.Rows.Count > 0) {
                        string id_venda = dt.Rows[0]["inserir_venda"].ToString(); // Captura ID da venda
                        for (int i = 0; i < sale.SaleItem_.Count; i++)
                            sale.SaleItem_[i].VendaID = id_venda;
                    }              
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Sofware",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            finally
            {
                DAO.PgsqlConnection.Close();
            }

            return SalelItemDAO.MultiInsertAuto(sale.SaleItem_); // Executa inserção dos itens_venda
        }

        public static bool Alter(Sale sale)
        {
            if (!ValidatorSaleMessage(sale))
                return false;
            else
            {
                string cmd = string.Format("select * from alterar_venda('{0}','{1}','{2}','{3}','{4}')",
                        sale.ID, sale.Customer.CPF, sale.Date, sale.TotalMoney, sale.TotalCard);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool Delete(string id)
        {
            string cmd = string.Format("select * from excluir_venda('{0}')", id);
            return GenericDAO.genericBool(cmd);
        }

        private static bool ValidatorSaleMessage(Sale sale)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(sale.ID, "ID"));
            inputs.Add(new ValidationItem(sale.Date.ToString(), "Data"));

            if (sale.Customer != null)
            {
                inputs.Add(new ValidationItem(sale.Customer.Name, "Nome"));
                inputs.Add(new ValidationItem(sale.Customer.CPF, "CPF"));
            }

            Validations val = new Validations();
            return val.ValidationCheck(inputs);
        }
    }
}
