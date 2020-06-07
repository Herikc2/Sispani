using BPS;
using Npgsql;
using Sispani.Model;
using System;
using System.Windows;

namespace Sispani.Controller
{
    public static class DAO
    {
        private static BPSFile file = BPSReader.Read("config");
        private static readonly bool debug = true;

        private static readonly string _serverName = file.FindValue("sgbd", "serverName");
        private static readonly string _port = file.FindValue("sgbd", "port");
        public static string _userName { get; } = file.FindValue("sgbd", "username");
        public static string _password { get; } = file.FindValue("sgbd", "password");
        private static readonly string _databaseName = file.FindValue("sgbd", "databaseName");
        private static readonly string _first_start = file.FindValue("sgbd", "first_start");
        public static NpgsqlConnection PgsqlConnection { get; set; } = null;
        public static string ConnString { get; set; } = null;

        static DAO()
        {
            if(debug)
                ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        _serverName, _port, _userName, _password, _databaseName);

            if (!TestConnection())
            {
                try
                {
                    string path_appdata = System.Environment.GetEnvironmentVariable("APPDATA");

                    System.Diagnostics.Process.Start("\"" + path_appdata + "/Microsoft/windows/start menu/programs/startup/start_pg.vbs\"");
                    System.Threading.Thread.Sleep(3000);

                    ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                            _serverName, _port, _userName, _password, _databaseName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro: Não foi possivel realizar conexão com o banco de dados", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
            }

            if (_first_start.Equals("false"))
            {
                // TODO: SUBSTITUIR FIRST_START:FALSE POR TRUE
                //file.DeleteAll();

                //file.AddSection(new Section("sgbd"));
                //file.AddData("sgbd", new Data("serverName", _serverName));
                //file.AddData("sgbd", new Data("port", _port));
                //file.AddData("sgbd", new Data("username", _userName));
                //file.AddData("sgbd", new Data("password", _password));
                //file.AddData("sgbd", new Data("databaseName", _databaseName));
                //file.AddData("sgbd", new Data("first_start", "true"));


                file.FindData("sgbd", "first_start").Value = "true";

                BPSWriter.Write(file, "config");

                FirstStart fs_s = new FirstStart();
                fs_s.start_script();
            }

        }

        public static bool ConnectDAO(string _ServerName, string _Port, string _UserName, string _Password, string _DatabaseName)
        {
            ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        _ServerName, _Port, _UserName, _Password, _DatabaseName);

            return TestConnection();
        }

        public static bool TestConnection()
        {
            try
            {
                using (PgsqlConnection = new NpgsqlConnection(ConnString))
                {
                    PgsqlConnection.Open();
                    PgsqlConnection.Close();

                    return true;
                }
            }
            catch (NpgsqlException ex)
            {
                return false;
            }
            finally
            {
                PgsqlConnection.Close();
            }
        }
    }
}
