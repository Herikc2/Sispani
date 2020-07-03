using Sispani.Model;
using Sispani.Model.DAO;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace Sispani.Controller
{
    public class CustomerController
    {
        public static DataTable Select()
        {
            return CustomerDAO.Select();
        }

        public static Customer SelectBill(string cpf)
        {
            if (!IsCPF(cpf))
            {
                MessageBox.Show("CPF inválido.");
                return null;
            }
            return CustomerDAO.SelectWithBill(cpf);
        }

        public static Customer Select(string cpf)
        {
            if (!IsCPF(cpf))
            {
                MessageBox.Show("CPF inválido.");
                return null;
            }
            return CustomerDAO.Select(cpf);
        }

        public static bool Delete(string cpf)
        {
            if (CustomerDAO.Delete(cpf))
            {
                MessageBox.Show("Cliente excluido com sucesso.");
                return true;
            }
            return false;
        }

        public static bool Alter(Customer customer)
        {
            if (EmptyString(customer.Name))
            {
                MessageBox.Show("Digite um nome.");
                return false;
            }
            if (EmptyString(customer.CellPhone))
            {
                MessageBox.Show("Digite um número de celular.");
                return false;
            }
            if (EmptyString(customer.Address.Street))
            {
                MessageBox.Show("Digite o nome da rua.");
                return false;
            }
            if (EmptyString(customer.Address.Number))
            {
                MessageBox.Show("Digite o número da rua.");
                return false;
            }
            if (EmptyString(customer.Address.District))
            {
                MessageBox.Show("Digite o bairro.");
                return false;
            }
            if (EmptyString(customer.Address.City))
            {
                MessageBox.Show("Digite a cidade.");
                return false;
            }

            if (CustomerDAO.Alter(customer))
            {
                MessageBox.Show("Informações alteradas com sucesso.");
                return true;
            }
            return false;
                
        }

        public static bool Insert(Customer customer)
        {
            if (!IsCPF(customer.CPF))
            {
                MessageBox.Show("CPF inválido.");
                return false;
            }

            if (EmptyString(customer.Name))
            {
                MessageBox.Show("Digite um nome.");
                return false;
            }
            if (EmptyString(customer.RG))
            {
                MessageBox.Show("Digite o RG.");
                return false;
            }
            if (Convert.ToDateTime(customer.Birthday).AddYears(18) >= DateTime.Now)
            {
                MessageBox.Show("Cliente menor de 18 anos.");
                return false;
            }
            if (EmptyString(customer.CellPhone))
            {
                MessageBox.Show("Digite um número de celular.");
                return false;
            }
            if (EmptyString(customer.Address.Street))
            {
                MessageBox.Show("Digite o nome da rua.");
                return false;
            }
            if (EmptyString(customer.Address.Number))
            {
                MessageBox.Show("Digite o número da rua.");
                return false;
            }
            if (EmptyString(customer.Address.District))
            {
                MessageBox.Show("Digite o bairro.");
                return false;
            }
            if (EmptyString(customer.Address.City))
            {
                MessageBox.Show("Digite a cidade.");
                return false;
            }

            if (CustomerDAO.Insert(customer))
            {
                MessageBox.Show("Cliente cadastrado com sucesso.");
                return true;
            }
            return false;
        }

        private static bool EmptyString(string str)
        {
            if (str.Equals("")) return true;
            return false;
        }

        private static bool IsCPF(string cpf)
        {
            int[] multiplier1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplier2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string temp;
            string digit;
            int sum;
            int rest;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            temp = cpf.Substring(0, 9);
            sum = 0;
            for (int i = 0; i < 9; i++)
                sum += int.Parse(temp[i].ToString()) * multiplier1[i];
            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            digit = rest.ToString();
            temp = temp + digit;
            sum = 0;
            for (int i = 0; i < 10; i++)
                sum += int.Parse(temp[i].ToString()) * multiplier2[i];
            rest = sum % 11;
            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;
            digit = digit + rest.ToString();
            return cpf.EndsWith(digit);
        }
    
        public static void SaveToCSV(DataGridView DGV)
        {
            string filename = "";
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "CSV (*.csv)|*.csv";
            sfd.FileName = "Output.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Seu arquivo esta sendo preparado, você será avisado quando finalizar.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("Devido a um erro não foi possivel realizar a exportação.\nErro: " + ex.Message);
                    }
                }

                int columnCount = DGV.ColumnCount;
                string columnNames = "";
                string[] output = new string[DGV.RowCount + 1];

                for (int i = 0; i < columnCount; i++)
                {
                    columnNames += DGV.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < DGV.RowCount; i++)
                {
                    for (int j = 0; j < columnCount; j++)
                    {
                        if (DGV.Rows[i - 1].Cells[j].Value != null && DGV.Rows[i - 1].Cells[j].Value.ToString() != "")
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";
                        else
                            output[i] += "null,";
                    }
                }

                System.IO.File.WriteAllLines(sfd.FileName, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Seu arquivo esta pronto para uso.");
            }
        }
    }
}
