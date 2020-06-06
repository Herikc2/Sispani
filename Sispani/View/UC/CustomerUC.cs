using Sispani.Controller;
using Sispani.Model;
using System;
using System.Windows.Forms;

namespace Sispani.View
{
    public partial class CustomerUC : UserControl
    {
        private const int INSERT = 0;
        private const int ALTER = 1;
        private const int DELETE = 2;

        private const int DEFAULT_STATE = 23;
        private const int DEFAULT_GENDER = 0;

        public CustomerUC()
        {
            InitializeComponent();
        }

        private void CustomerUC_Load(object sender, EventArgs e)
        {
            // Caso queira começar o programa com item na tabela
            //Test.InsertCustomer(200);

            // configuração inicial cadastro de clientes
            cboInsertState.SelectedItem = cboInsertState.Items[DEFAULT_STATE];
            cboInsertGender.SelectedItem = cboInsertGender.Items[DEFAULT_GENDER];

            //
            UpdateDataGridView();
        }

        private void UpdateDataGridView()
        {
            dgvCustomers.DataSource = CustomerController.Select();

            //dgvCustomers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[11].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            //dgvCustomers.Columns[12].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            if (CustomerController.Insert(new Customer(txtInsertName.Text, txtInsertCPF.Text,
                txtInsertRG.Text, cboInsertGender.Text, dtpInsertBirthday.Value,
                txtInsertPhone.Text, txtInsertCellPhone.Text, 
                new Address(txtInsertStreet.Text, txtInsertNumber.Text, txtInsertComplement.Text,
                txtInsertDistrict.Text, txtInsertCity.Text, cboInsertState.Text))))
            {
                ClearInsert();
                UpdateDataGridView();
            }
        }

        private void BtnInsertCancel_Click(object sender, EventArgs e)
        {
            ClearInsert();
        }

        private void BtnAlter_Click(object sender, EventArgs e)
        {
            if (CustomerController.Alter(new Customer(txtAlterName.Text, txtAlterCPF.Text,
                txtAlterRG.Text, cboAlterGender.Text, dtpAlterBirthday.Value,
                txtAlterPhone.Text, txtAlterCellPhone.Text,
                new Address(txtAlterStreet.Text, txtAlterNumber.Text, txtAlterComplement.Text,
                txtAlterDistrict.Text, txtAlterCity.Text, cboAlterState.Text))))
            {
                CleanAlter();
                UpdateDataGridView();
            }
        }

        private void BtnAlterCancel_Click(object sender, EventArgs e)
        {
            CleanAlter();
        }

        private void TxtAlterCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Customer customer = CustomerController.Select(txtAlterCPF.Text);
                if (customer != null)
                {
                    txtAlterName.Enabled = true;
                    txtAlterCPF.Enabled = false;
                    cboAlterGender.Enabled = true;
                    txtAlterPhone.Enabled = true;
                    txtAlterCellPhone.Enabled = true;
                    txtAlterStreet.Enabled = true;
                    txtAlterNumber.Enabled = true;
                    txtAlterComplement.Enabled = true;
                    txtAlterDistrict.Enabled = true;
                    txtAlterCity.Enabled = true;
                    cboAlterState.Enabled = true;
                    btnAlterCancel.Enabled = true;
                    btnAlter.Enabled = true;
                    //
                    txtAlterName.Text = customer.Name;
                    txtAlterRG.Text = customer.RG;
                    txtAlterCPF.Text = customer.CPF;
                    cboAlterGender.Text = customer.Gender;
                    dtpAlterBirthday.Value = customer.Birthday;
                    txtAlterPhone.Text = customer.Phone;
                    txtAlterCellPhone.Text = customer.CellPhone;
                    txtAlterStreet.Text = customer.Address.Street;
                    txtAlterNumber.Text = customer.Address.Number;
                    txtAlterComplement.Text = customer.Address.Complement;
                    txtAlterDistrict.Text = customer.Address.District;
                    txtAlterCity.Text = customer.Address.City;
                    cboAlterState.Text = customer.Address.State;
                }
                else
                {
                    txtAlterCPF.Text = "";
                }
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (CustomerController.Delete(txtDeleteCPF.Text))
            {
                txtDeleteName.Text = "";
                txtDeleteRG.Text = "";
                txtDeleteCPF.Text = "";
                cboDeleteGender.Text = "";
                dtpDeleteBirthday.Value = DateTime.Now;
                txtDeletePhone.Text = "";
                txtDeleteCellPhone.Text = "";
                txtDeleteStreet.Text = "";
                txtDeleteNumber.Text = "";
                txtDeleteComplement.Text = "";
                txtDeleteDistrict.Text = "";
                txtDeleteCity.Text = "";
                cboDeleteState.Text = "";
                //
                txtDeleteName.Enabled = false;
                txtDeleteRG.Enabled = false;
                txtDeleteCPF.Enabled = true;
                cboDeleteGender.Enabled = false;
                dtpDeleteBirthday.Enabled = false;
                txtDeletePhone.Enabled = false;
                txtDeleteCellPhone.Enabled = false;
                txtDeleteStreet.Enabled = false;
                txtDeleteNumber.Enabled = false;
                txtDeleteComplement.Enabled = false;
                txtDeleteDistrict.Enabled = false;
                txtDeleteCity.Enabled = false;
                cboDeleteState.Enabled = false;
                btnDeleteCancel.Enabled = false;
                btnDelete.Enabled = false;
                //
                UpdateDataGridView();
            }
        }

        private void BtnDeleteCancel_Click(object sender, EventArgs e)
        {
            CleanDelete();
        }

        private void TxtDeleteCPF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Customer customer = CustomerController.Select(txtDeleteCPF.Text);
                if (customer != null)
                {
                    txtDeleteCPF.Enabled = false;
                    btnDeleteCancel.Enabled = true;
                    btnDelete.Enabled = true;
                    //
                    txtDeleteName.Text = customer.Name;
                    txtDeleteRG.Text = customer.RG;
                    txtDeleteCPF.Text = customer.CPF;
                    cboDeleteGender.Text = customer.Gender;
                    dtpDeleteBirthday.Value = customer.Birthday;
                    txtDeletePhone.Text = customer.Phone;
                    txtDeleteCellPhone.Text = customer.CellPhone;
                    txtDeleteStreet.Text = customer.Address.Street;
                    txtDeleteNumber.Text = customer.Address.Number;
                    txtDeleteComplement.Text = customer.Address.Complement;
                    txtDeleteDistrict.Text = customer.Address.District;
                    txtDeleteCity.Text = customer.Address.City;
                    cboDeleteState.Text = customer.Address.State;
                }
                else
                {
                    txtDeleteCPF.Text = "";
                }
            }
        }

        private void TabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == INSERT)
            {
                CleanAlter();
                CleanDelete();
            }
            if (e.TabPageIndex == ALTER)
            {
                ClearInsert();
                CleanDelete();
            }
            if (e.TabPageIndex == DELETE)
            {
                ClearInsert();
                CleanAlter();
            }
        }

        private void ClearInsert()
        {
            txtInsertName.Text = "";
            txtInsertCPF.Text = "";
            txtInsertRG.Text = "";
            cboInsertGender.SelectedItem = cboInsertGender.Items[DEFAULT_GENDER];
            dtpInsertBirthday.Value = DateTime.Now;
            txtInsertPhone.Text = "";
            txtInsertCellPhone.Text = "";
            txtInsertStreet.Text = "";
            txtInsertNumber.Text = "";
            txtInsertComplement.Text = "";
            txtInsertDistrict.Text = "";
            txtInsertCity.Text = "";
            cboInsertState.SelectedItem = cboInsertState.Items[DEFAULT_STATE];
        }

        private void CleanAlter()
        {
            txtAlterName.Text = "";
            txtAlterCPF.Text = "";
            txtAlterRG.Text = "";
            cboAlterGender.SelectedItem = "";
            dtpAlterBirthday.Value = DateTime.Now;
            txtAlterPhone.Text = "";
            txtAlterCellPhone.Text = "";
            txtAlterStreet.Text = "";
            txtAlterNumber.Text = "";
            txtAlterComplement.Text = "";
            txtAlterDistrict.Text = "";
            txtAlterCity.Text = "";
            cboAlterState.SelectedItem = "";
            //
            txtAlterName.Enabled = false;
            txtAlterCPF.Enabled = true;
            cboAlterGender.Enabled = false;
            txtAlterPhone.Enabled = false;
            txtAlterCellPhone.Enabled = false;
            txtAlterStreet.Enabled = false;
            txtAlterNumber.Enabled = false;
            txtAlterComplement.Enabled = false;
            txtAlterDistrict.Enabled = false;
            txtAlterCity.Enabled = false;
            cboAlterState.Enabled = false;
            btnAlterCancel.Enabled = false;
            btnAlter.Enabled = false;
        }

        private void CleanDelete()
        {
            txtDeleteName.Text = "";
            txtDeleteCPF.Text = "";
            txtDeleteRG.Text = "";
            cboDeleteGender.SelectedItem = "";
            dtpDeleteBirthday.Value = DateTime.Now;
            txtDeletePhone.Text = "";
            txtDeleteCellPhone.Text = "";
            txtDeleteStreet.Text = "";
            txtDeleteNumber.Text = "";
            txtDeleteComplement.Text = "";
            txtDeleteDistrict.Text = "";
            txtDeleteCity.Text = "";
            cboDeleteState.SelectedItem = "";
            txtDeleteCPF.Enabled = true;
            btnDeleteCancel.Enabled = false;
            btnDelete.Enabled = false;
        }

        private void VerifyDigit(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
                e.Handled = true;
        }

        private void VerifyLetter(KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != ' ')
                e.Handled = true;
        }

        private void DotInsertCPF(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtInsertCPF.Text.Length == 3)
                    txtInsertCPF.Text += '.';
                if (txtInsertCPF.Text.Length == 7)
                    txtInsertCPF.Text += '.';
                if (txtInsertCPF.Text.Length == 11)
                    txtInsertCPF.Text += '-';
                txtInsertCPF.Select(txtInsertCPF.Text.Length, 0);
            }
        }

        private void DotAlterCPF(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtAlterCPF.Text.Length == 3)
                    txtAlterCPF.Text += '.';
                if (txtAlterCPF.Text.Length == 7)
                    txtAlterCPF.Text += '.';
                if (txtAlterCPF.Text.Length == 11)
                    txtAlterCPF.Text += '-';
                txtAlterCPF.Select(txtAlterCPF.Text.Length, 0);
            }
        }

        private void DotDeleteCPF(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtDeleteCPF.Text.Length == 3)
                    txtDeleteCPF.Text += '.';
                if (txtDeleteCPF.Text.Length == 7)
                    txtDeleteCPF.Text += '.';
                if (txtDeleteCPF.Text.Length == 11)
                    txtDeleteCPF.Text += '-';
                txtDeleteCPF.Select(txtDeleteCPF.Text.Length, 0);
            }
        }

        private void DotInsertPhone(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtInsertPhone.Text.Length == 1)
                    if (!txtInsertPhone.Text.Equals("("))
                        txtInsertPhone.Text = '(' + txtInsertPhone.Text;
                if (txtInsertPhone.Text.Length == 3)
                    txtInsertPhone.Text += ") ";
                if (txtInsertPhone.Text.Length == 9)
                    txtInsertPhone.Text += '-';
                txtInsertPhone.Select(txtInsertPhone.Text.Length, 0);
            }
        }

        private void DotInsertCellPhone(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtInsertCellPhone.Text.Length == 1)
                    if (!txtInsertCellPhone.Text.Equals("("))
                        txtInsertCellPhone.Text = '(' + txtInsertCellPhone.Text;
                if (txtInsertCellPhone.Text.Length == 3)
                    txtInsertCellPhone.Text += ") ";
                if (txtInsertCellPhone.Text.Length == 10)
                    txtInsertCellPhone.Text += '-';
                txtInsertCellPhone.Select(txtInsertCellPhone.Text.Length, 0);
            }
        }

        private void DotAlterPhone(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtAlterPhone.Text.Length == 1)
                    if (!txtAlterPhone.Text.Equals("("))
                        txtAlterPhone.Text = '(' + txtAlterPhone.Text;
                if (txtAlterPhone.Text.Length == 3)
                    txtAlterPhone.Text += ") ";
                if (txtAlterPhone.Text.Length == 9)
                    txtAlterPhone.Text += '-';
                txtAlterPhone.Select(txtAlterPhone.Text.Length, 0);
            }
        }

        private void DotAlterCellPhone(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if (txtAlterCellPhone.Text.Length == 1)
                    if (!txtAlterCellPhone.Text.Equals("("))
                        txtAlterCellPhone.Text = '(' + txtAlterCellPhone.Text;
                if (txtAlterCellPhone.Text.Length == 3)
                    txtAlterCellPhone.Text += ") ";
                if (txtAlterCellPhone.Text.Length == 10)
                    txtAlterCellPhone.Text += '-';
                txtAlterCellPhone.Select(txtAlterCellPhone.Text.Length, 0);
            }
        }

        private void TxtInsertName_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyLetter(e);
        }

        private void TxtInsertCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotInsertCPF(e);
        }

        private void TxtInsertPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotInsertPhone(e);
        }

        private void TxtInsertCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotInsertCellPhone(e);
        }

        private void TxtInsertNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
        }

        private void TxtAlterName_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyLetter(e);
        }

        private void TxtAlterPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotAlterPhone(e);
        }

        private void TxtAlterCellPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotAlterCellPhone(e);
        }

        private void TxtAlterNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
        }

        private void TxtAlterCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotAlterCPF(e);
        }

        private void TxtDeleteCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            VerifyDigit(e);
            DotDeleteCPF(e);
        }

        private void TsmiExportCSV_Click(object sender, EventArgs e)
        {
            CustomerController.SaveToCSV(dgvCustomers);
        }
    }
}
