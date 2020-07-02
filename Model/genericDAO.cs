using Npgsql;
using Sispani.Controller;
using System;
using System.Data;
using System.Windows;

namespace Sispani.Model
{
    class GenericDAO
    {
        public static DataTable Select(string cmd)
        {
            DataTable dt = new DataTable();

            try
            {
                using (DAO.PgsqlConnection = new NpgsqlConnection(DAO.ConnString))
                {
                    //Abra a conexão com o PgSQL
                    DAO.PgsqlConnection.Open();

                    using (NpgsqlDataAdapter Adpt = new NpgsqlDataAdapter(cmd, DAO.PgsqlConnection))
                    {
                        Adpt.Fill(dt);
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Sofware",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return null;
            }
            finally
            {
                DAO.PgsqlConnection.Close();
            }

            return dt;
        }

        public static bool genericBool(string CMD)
        {
            try
            {
                using (DAO.PgsqlConnection = new NpgsqlConnection(DAO.ConnString))
                {
                    //Abra a conexão com o PgSQL                  
                    DAO.PgsqlConnection.Open();

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(CMD, DAO.PgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
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
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Software",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            finally
            {
                DAO.PgsqlConnection.Close();
            }

            return true;
        }
    }
}
