namespace Sispani.Model.Class
{
    public class User
    {
        public string ID { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }

        public User(string id, string login, string senha, string nome)
        {
            ID = id;
            Login = login;
            Senha = senha;
            Nome = nome;
        }

        public User(string login, string senha, string nome)
        {
            Login = login;
            Senha = senha;
            Nome = nome;
        }

    }
}
