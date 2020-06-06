using Sispani.Model;
using System;
using System.Windows;
using System.Windows.Forms;

namespace Sispani.View.AuxProgram
{
    public partial class LoginForm : Form
    {
        private ProgramForm _program = (ProgramForm)System.Windows.Forms.Application.OpenForms[0];
        private bool _programExit = true;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = '*';
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (LoginDAO.CheckLogin(txtLogin.Text, txtPassword.Text))
            {
                _programExit = false;
                _program.LoginLoad();
                Close();
            }
            else
            {
                System.Windows.MessageBox.Show("Usuario ou senha incorreta", "Erro de Login",
                    MessageBoxButton.OK, MessageBoxImage.Warning);
            }

            // TESTES 
            //if (LoginDAO.verificarLogin(txtLogin.Text, txtPassword.Text))
            //{
            //    MessageBox.Show("Logado", "Logado");
            //}
            //else
            //{
            //    MessageBox.Show("Erro: Login Incorreto ou Inexistente", "Falha no Login");
            //}
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_programExit)
            {
                _program.LoginExit();
            }
        }
    }
}
