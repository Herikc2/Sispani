using Sispani.Controller;
using System;
using System.Windows.Forms;
using System.Windows;

namespace Sispani.View.AuxProgram
{
    public partial class ConnectDB : Form
    {
        public ConnectDB()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if(DAO.ConnectDAO(textServerName.Text, textPort.Text, textUser.Text, textPassword.Text, textNameDB.Text))
            {
                // CHAMAR PAINEL DE CRIAR USUARIOS -> CONECTADO
            }
            else
            {
                System.Windows.MessageBox.Show("Erro ao Conectar com Banco de Dados", "Erro de Conexão",
                      MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}
