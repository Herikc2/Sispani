using Sispani.Model;
using Sispani.Model.Class;
using Sispani.Model.Class.Validations;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows;

namespace Sispani.Controller
{
    public class CustomerDAO
    {

        public static DataTable Select()
        {
            string cmd = string.Format("select * from selecionar_todos_clientes()");
            DataTable dt = GenericDAO.Select(cmd);

            if (dt != null)
                if (dt.Rows.Count > 0)
                    return formatDataSet(dt);

            return null;
        }

        public static Customer SelectWithBill(string cpf)
        {
            string cmd = string.Format("select * from selecionar_todos_item_conta_nao_pagas_cliente('{0}')", cpf);
            DataTable dt = GenericDAO.Select(cmd);

            List<BillItem> items = new List<BillItem>();

            if (dt != null)
                for (int i = 0; i < dt.Rows.Count; i++)
                    items.Add(new BillItem(Convert.ToDateTime(dt.Rows[i][2].ToString()), double.Parse(dt.Rows[i][3].ToString())));


            if (dt != null)
                if (dt.Rows.Count > 0)
                    return new Customer(dt.Rows[0]["nome"].ToString(), dt.Rows[0]["pessoa_cpf"].ToString(), new Bill(items));
            
            return null;
        }

        public static Customer Select(string cpf)
        {
            string cmd = string.Format("select * from selecionar_cliente('{0}')", cpf);
            DataTable dt = GenericDAO.Select(cmd);

            if (dt != null)
                if (dt.Rows.Count > 0)
                    return new Customer(dt.Rows[0]["nome"].ToString(), dt.Rows[0]["cpf"].ToString(), dt.Rows[0]["rg"].ToString(), dt.Rows[0]["sexo"].ToString(), Convert.ToDateTime(dt.Rows[0]["nascimento"].ToString()), dt.Rows[0]["telefone"].ToString(), dt.Rows[0]["celular"].ToString(),
                           new Address(dt.Rows[0]["rua"].ToString(), dt.Rows[0]["numero"].ToString(), dt.Rows[0]["complemento"].ToString(), dt.Rows[0]["bairro"].ToString(), dt.Rows[0]["cidade"].ToString(), dt.Rows[0]["estado"].ToString()));
            
            return null;
        }

        public static bool Insert(Customer customer)
        {
            if (!ValidatorCustomerMessage(customer))
                return false;
            
            string cmd = string.Format("select * from inserir_cliente('{0}','{1}','{2}','{3}','{4}','{5}','{6}', '{7}','{8}','{9}','{10}','{11}','{12}')",
                        customer.CPF, customer.Name, customer.RG, customer.Gender, customer.Birthday, customer.CellPhone, customer.Phone, customer.Address.Street, customer.Address.Number,
                        customer.Address.Complement, customer.Address.District, customer.Address.City, customer.Address.State);
            
            return GenericDAO.genericBool(cmd);
        }

        public static bool Alter(Customer customer)
        {
            if (!ValidatorCustomerMessage(customer))
                return false;
            
            string cmd = string.Format("select * from alterar_pessoa('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
                        customer.CPF, customer.Name, customer.Gender, customer.CellPhone, customer.Phone, customer.Address.Street, customer.Address.Number,
                        customer.Address.Complement, customer.Address.District, customer.Address.City, customer.Address.State);
            
            return GenericDAO.genericBool(cmd);
        }

        public static bool Delete(string cpf)
        {
            string cmd = string.Format("select * from excluir_cliente('{0}')", cpf);
            return GenericDAO.genericBool(cmd);         
        }

        private static bool ValidatorCustomer(Customer customer)
        {
            Validations val = new Validations();

            val.Validator = val.CheckInput(customer.CPF);
            val.Validator = val.CheckInput(customer.Name);
            val.Validator = val.CheckInput(customer.RG);
            val.Validator = val.CheckInput(customer.Gender);
            val.Validator = val.CheckInput(customer.Birthday.ToString());
            val.Validator = val.CheckInput(customer.CellPhone);
            val.Validator = val.CheckInput(customer.Phone);
            val.Validator = val.CheckInput(customer.Address.Street);
            val.Validator = val.CheckInput(customer.Address.Number);
            val.Validator = val.CheckInput(customer.Address.Complement);
            val.Validator = val.CheckInput(customer.Address.District);
            val.Validator = val.CheckInput(customer.Address.City);
            val.Validator = val.CheckInput(customer.Address.State);

            if (val.Validator)
            {
                MessageBox.Show("O formulario possui campos invalidos",
                    "Campos Invalidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                return false;
            }
            return true;
        }

        private static bool ValidatorCustomerMessage(Customer customer)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(customer.CPF, "CPF"));
            inputs.Add(new ValidationItem(customer.Name, "Nome"));
            inputs.Add(new ValidationItem(customer.RG, "RG"));
            inputs.Add(new ValidationItem(customer.Gender, "Sexo"));
            inputs.Add(new ValidationItem(customer.Birthday.ToString(), "Data de Nascimento"));
            inputs.Add(new ValidationItem(customer.CellPhone, "Celular"));
            inputs.Add(new ValidationItem(customer.Phone, "Telefone"));

            inputs.Add(new ValidationItem(customer.Address.Street, "Rua"));
            inputs.Add(new ValidationItem(customer.Address.Number, "Numero"));
            inputs.Add(new ValidationItem(customer.Address.Complement, "Complemento"));
            inputs.Add(new ValidationItem(customer.Address.District, "Bairro"));
            inputs.Add(new ValidationItem(customer.Address.City, "Cidade"));
            inputs.Add(new ValidationItem(customer.Address.State, "Estado"));

            Validations val = new Validations();
            return val.ValidationCheck(inputs);
        }

        private static DataTable formatDataSet(DataTable dt)
        {
            dt.Columns[0].ColumnName = "CPF";
            dt.Columns[1].ColumnName = "Nome";
            dt.Columns[2].ColumnName = "RG";
            dt.Columns[3].ColumnName = "Sexo";
            dt.Columns[4].ColumnName = "Nascimento";
            dt.Columns[5].ColumnName = "Celular";
            dt.Columns[6].ColumnName = "Telefone";
            dt.Columns[7].ColumnName = "Rua";
            dt.Columns[8].ColumnName = "Numero";
            dt.Columns[9].ColumnName = "Complemento";
            dt.Columns[10].ColumnName = "Bairro";
            dt.Columns[11].ColumnName = "Cidade";
            dt.Columns[12].ColumnName = "Estado";

            // CENTRALIZAR CPF, RG, SEXO, NASCIMENTO, CELULAR, TELEFONE, NUMERO, COMPLEMENTO, BAIRRO, ESTADO
            // Sobreescrever campos não preenchidos

            return dt;
        }

    }
}
