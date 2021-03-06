﻿using Npgsql;
using System;
using System.Windows;

namespace Sispani.Model.DAO
{
    public class FirstStart
    {
        public bool start_script(string CMD)
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
