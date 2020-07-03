using Npgsql;
using Sispani.Model.Util.Validations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace Sispani.Model.DAO
{
    public class LoginDAO
    {
        public static bool CheckLogin(string login, string pass)
        {
            if (!ValidatorUserMessage(login, pass))
                return false;

            //comandos SQL para verificar no BD
            DataTable dt = new DataTable();
             
            try
            {
                using (DAO.PgsqlConnection = new NpgsqlConnection(DAO.ConnString))
                {
                    // abre a conexão com o PgSQL e define a instrução SQL
                    DAO.PgsqlConnection.Open();
                    string cmd = string.Format("select * from selecionar_usuario_login_('{0}')", login);

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd, DAO.PgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }

                    if (dt.Rows.Count > 0)
                    {
                        // DEVIDO A INEXISTENCIA ATUAL DA INTERFACE DE CADASTRO, NÃO UTILA-SE CRIPTOGRAFIA
                        /*string hash = dt.Rows[0]["senha"].ToString();
                        if (BCrypt.Net.BCrypt.Verify(pass, hash))
                            return true;
                        else 
                            return false;*/
                        if (dt.Rows[0]["senha"].ToString().Equals(pass))
                        {
                            DAO.PgsqlConnection.Close();
                            return true;
                        }
                        else
                        {
                            DAO.PgsqlConnection.Close();
                            return false;
                        }
                    }
                    else
                    {
                        DAO.PgsqlConnection.Close();
                        return false;
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
            }
            finally
            {
                DAO.PgsqlConnection.Close();
            }
            return false;
        }
        private static bool ValidatorUserMessage(string login, string pass)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(login, "Login"));
            inputs.Add(new ValidationItem(pass, "Senha"));

            Validations val = new Validations();
            return val.ValidationCheck(inputs);       
            }

    }
}

