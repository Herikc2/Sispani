using Npgsql;
using Sispani.Controller;
using Sispani.Model.Class;
using Sispani.Model.Class.Validations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace Sispani.Model
{
    public class UserDAO
    {

        public static DataTable SelectAll()
        {
            string cmd = string.Format("select * from selecionar_todos_funcionarios()");
            DataTable dt = GenericDAO.Select(cmd);

            if (dt.Rows.Count > 0)
                return dt;
            else
                return null;
        }

        public static User Select(string cpf)
        {
            string cmd = string.Format("select * from selecionar_funcionario('{0}')", cpf);
            DataTable dt = GenericDAO.Select(cmd);
   

            if (dt.Rows.Count > 0)
                return new User(dt.Rows[0]["id"].ToString(), dt.Rows[0]["login"].ToString(), dt.Rows[0]["senha"].ToString(), dt.Rows[0]["nome"].ToString());
            return null;
        }

        public static bool Insert(User user)
        {
            if (!ValidatorUserMessage(user))
                return false;
            else
            {
                string cmd = string.Format("select * from inserir_usuario('{0}','{1}','{2}'')",
                        user.Login, user.Senha, user.Nome);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool Alter(User user)
        {
            if (!ValidatorUserMessage(user))
                return false;
            else
            {
                string cmd = string.Format("select * from alterar_usuario('{0}','{1}','{2}'')",
                        user.Login, user.Senha, user.Nome);
                return GenericDAO.genericBool(cmd);
            }
        }

        public static bool Delete(string login)
        {
            string cmd = string.Format("select * from excluir_usuario('{0}')", login);
            return GenericDAO.genericBool(cmd);    
        }

        public bool verificaExistenciaLogin(string login)
        {
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
                        MessageBox.Show("Aviso: Ja possui cadastro com esse email", "Usuario Existente",
                        MessageBoxButton.OK, MessageBoxImage.Warning);
                        return false;
                    }
                    else
                        if (dt.Rows[0]["login"].ToString().Equals(login))
                        return false;
                    else
                        return true;
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
                MessageBox.Show("Erro: " + ex.Message + ".\nPor Favor contate o suporte.", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return false;
            }
            finally
            {
                DAO.PgsqlConnection.Close();
            }
        }
        
        private static bool ValidatorUserMessage(User user)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(user.Login, "Login"));
            inputs.Add(new ValidationItem(user.Senha, "Senha"));
            inputs.Add(new ValidationItem(user.Nome, "Nome"));

            Validations val = new Validations();
            return val.ValidationCheck(inputs);
        }

    }
}
