using Sispani.Model;
using Sispani.Model.Class;
using System;
using System.Windows.Forms;
using System.Windows;

namespace Sispani.View.AuxProgram
{
    public partial class ConnectDB___User : Form
    {
        public ConnectDB___User()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (UserDAO.Insert(new User(textUser.Text, textPassword.Text, textName.Text)))          
                System.Windows.MessageBox.Show("Usuario Inserido", "Inserção",
                    MessageBoxButton.OK, MessageBoxImage.Information);
            else
                System.Windows.MessageBox.Show("Erro ao Inserir Usuario", "Erro de Cadastro",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
        }
    }
}
