using BPS;
using Npgsql;
using Sispani.Model;
using System;
using System.Windows;

namespace Sispani.Controller
{
    public static class DAO
    {
        private static string key_f = "tLg56G!T";
        private static Cryptography crip_f = new Cryptography(CryptProvider.RC2, key_f);         

        private static BPSFile file = BPSReader.Read("config");

        private static string _serverName = file.FindValue("sgbd", "serverName");
        private static string _port = file.FindValue("sgbd", "port");
        private static string _userName = file.FindValue("sgbd", "username");
        public static string _password { get; set; } = file.FindValue("sgbd", "password");
        private static string _databaseName = file.FindValue("sgbd", "databaseName");
        private static string _first_start = file.FindValue("sgbd", "first_start");
        public static string _first_user { get; set; } = file.FindValue("sgbd", "firstUser");
        public static NpgsqlConnection PgsqlConnection { get; set; } = null;
        public static string ConnString { get; set; } = null;

        static DAO()
        {

            script_start();
            
            if (!TestConnection())
            {
                try
                {
                    MessageBox.Show("Devido ao Banco de Dados não estar conectando, irá ser forçado uma tentativa de conexão!\nEssa tentativa pode demorar de 5 a 10 segundos para aparecer o Login.", "Tempo de Espera",
                    MessageBoxButton.OK, MessageBoxImage.Warning);

                    string path_appdata = System.Environment.GetEnvironmentVariable("APPDATA");

                    System.Diagnostics.Process.Start("\"" + path_appdata + "/Microsoft/windows/start menu/programs/startup/start_pg.vbs\"");
                    System.Threading.Thread.Sleep(5000);

                    ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                            _serverName, _port, _userName, _password, _databaseName);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro: Não foi possivel realizar conexão com o banco de dados", "Erro de Banco de Dados",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                }
                
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
            catch (NpgsqlException)
            {
                return false;
            }
            finally
            {
                PgsqlConnection.Close();
            }
        }

        private static void script_start()
        {
            if (_first_start.Equals("false"))
            {
                file.FindData("sgbd", "serverName").Value = crip_f.Encrypt(_serverName);
                file.FindData("sgbd", "port").Value = crip_f.Encrypt(_port);
                file.FindData("sgbd", "username").Value = crip_f.Encrypt(_userName);
                file.FindData("sgbd", "password").Value = crip_f.Encrypt(_password);
                file.FindData("sgbd", "databaseName").Value = crip_f.Encrypt(_databaseName);
                file.FindData("sgbd", "first_start").Value = crip_f.Encrypt("true");
                file.FindData("sgbd", "firstUser").Value = crip_f.Encrypt(_first_user);

                BPSWriter.Write(file, "config");

                ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        _serverName, _port, _userName, _password, _databaseName);

                FirstStart fs_s = new FirstStart();
                fs_s.start_script();

                BPSFile file_s = BPSReader.Read("script");
                string script = file_s.FindValue("script", "script_start");

                file_s.FindData("script", "script_start").Value = crip_f.Encrypt(script);
                BPSWriter.Write(file_s, "script");
            }
            else
            {
                _serverName = crip_f.Decrypt(_serverName);
                _port = crip_f.Decrypt(_port);
                _userName = crip_f.Decrypt(_userName);
                _password = crip_f.Decrypt(_password);
                _databaseName = crip_f.Decrypt(_databaseName);
                _first_start = crip_f.Decrypt(_first_start);
                _first_user = crip_f.Decrypt(_first_user);

                ConnString = string.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                                        _serverName, _port, _userName, _password, _databaseName);
            }
        }
    }
}
