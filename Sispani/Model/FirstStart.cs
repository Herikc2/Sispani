using BPS;
using Npgsql;
using Sispani.Controller;
using System;
using System.Windows;

namespace Sispani.Model
{
    class FirstStart
    {

        public bool start_script()
        {
            try
            {
                using (DAO.PgsqlConnection = new NpgsqlConnection(DAO.ConnString))
                {
                    //Abra a conexão com o PgSQL                  
                    DAO.PgsqlConnection.Open();

                    BPSFile file = BPSReader.Read("script");
                    string CMD = file.FindValue("script", "script_start");

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(CMD, DAO.PgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }

                    CMD = string.Format("select * from inserir_usuario('{0}','{1}','{2}')",
                        DAO._first_user, DAO._password, "Admin");

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

    }
}
