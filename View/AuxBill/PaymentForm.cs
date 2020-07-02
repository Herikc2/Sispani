using System;
using System.Windows.Forms;

namespace Sispani.View.AuxBill
{
    public partial class PaymentForm : Form
    {
        private readonly BillUC _billUC;

        private readonly double _total;

        private const int MONEY = 0, CARD = 1;
        private int _method = MONEY;

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(BillUC billUC)
        {
            InitializeComponent();
            _total = billUC.Customer.Bill.GetTotal();
            _billUC = billUC;
            lblTotal.Text = _total.ToString("N2");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            _billUC.FinalizePayment();
            Close();
        }

        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            _billUC.FinalizePayment(lblMoney.Text, lblCard.Text);
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

                switch (_method)
                {
                    case MONEY:
                        lblMoney.Text = (double.Parse(lblMoney.Text) + pay).ToString("N2");
                        break;
                    case CARD:
                        lblCard.Text = (double.Parse(lblCard.Text) + pay).ToString("N2");
                        break;
                    default:
                        MessageBox.Show("ERRO: PF00\nContate o suporte técnico.");
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
        }

        private void BtnCard_Click(object sender, EventArgs e)
        {
            _method = CARD;
            lblSelMoney.Visible = false;
            lblSelCard.Visible = true;
        }
    }
}
