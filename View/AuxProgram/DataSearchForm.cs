using System;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class DataSearchForm : Form
    {
        public enum Type
        {
            CLIENTE,
            PRODUTO
        }

        private readonly Type _type;

        public DataSearchForm()
        {
            InitializeComponent();
        }

        public DataSearchForm(Type type)
        {
            InitializeComponent();
            _type = type;
        }

        private void ButtonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ButtonPesquisar_Click(object sender, EventArgs e)
        {
            switch (_type)
            {
                case Type.CLIENTE:
                    break;
                case Type.PRODUTO:
                    break;
            }
        }
    }
}
