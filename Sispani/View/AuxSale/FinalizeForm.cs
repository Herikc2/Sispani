using System;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class FinalizeForm : Form
    {
        private SaleForm _sale = (SaleForm)Application.OpenForms[1];

        private readonly double _total;

        private const int MONEY = 0, CARD = 1, TERM = 2;
        private int _method = MONEY;

        public FinalizeForm()
        {
            InitializeComponent();
        }

        public FinalizeForm(double total)
        {
            InitializeComponent();
            _total = total;
            lblTotal.Text = total.ToString("N2");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _sale.FinalizePayment();
            Close();
        }

        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            _sale.FinalizePayment(lblMoney.Text, lblCard.Text, lblTerm.Text);
            Close();
        }

        private void TxtPayValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                var total = double.Parse(lblTotal.Text);
                var pay = double.Parse(txtPayValue.Text);
                txtPayValue.Text = "";

                total -= pay;

                switch(_method)
                {
                    case MONEY:
                        lblMoney.Text = (double.Parse(lblMoney.Text) + pay).ToString("N2");
                        break;
                    case CARD:
                        lblCard.Text = (double.Parse(lblCard.Text) + pay).ToString("N2");
                        break;
                    case TERM:
                        lblTerm.Text = (double.Parse(lblTerm.Text) + pay).ToString("N2");
                        break;
                    default:
                        MessageBox.Show("ERRO: FF00\nContate o suporte técnico.");
                        break;
                }

                if (total <= 0)
                {
                    total *= -1;
                    lblTotalValue.Visible = false;
                    lblTroco.Visible = true;
                    btnFinalize.Enabled = true;
                    btnCancel.Enabled = false;
                    btnCard.Enabled = false;
                    btnMoney.Enabled = false;
                    btnTerm.Enabled = false;
                    txtPayValue.Enabled = false;
                }

                lblTotal.Text = total.ToString("N2");
            }
        }

        private void BtnMoney_Click(object sender, EventArgs e)
        {
            _method = MONEY;
            lblSelMoney.Visible = true;
            lblSelCard.Visible = false;
            lblSelTerm.Visible = false;
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            _method = CARD;
            lblSelMoney.Visible = false;
            lblSelCard.Visible = true;
            lblSelTerm.Visible = false;
        }

        private void BtnTerm_Click(object sender, EventArgs e)
        {
            if (_sale.CustomerAdded)
            {
                _method = TERM;
                lblSelMoney.Visible = false;
                lblSelCard.Visible = false;
                lblSelTerm.Visible = true;
            }
            else
            {
                MessageBox.Show("Nenhum cliente adicionado.");
            }
        }
    }
}
