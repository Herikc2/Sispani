using Sispani.Model.Util.Validations;
using System.Collections.Generic;

namespace Sispani.Model.DAO
{
    public class BillPaymentDAO
    {
        public static bool Insert(BillPayment billPayment)
        {
            if (!ValidatorBillPaymentMessage(billPayment))
                return false;
            else
            {
                string cmd = string.Format("select * from inserir_pagamento_conta('{0}','{1}','{2}','{3}')",
                        billPayment.Customer.CPF, billPayment.PaymentDate, billPayment.Money, billPayment.Card);
                return GenericDAO.genericBool(cmd);
            }
        }

        private static bool ValidatorBillPaymentMessage(BillPayment billPayment)
        {
            List<ValidationItem> inputs = new List<ValidationItem>();

            inputs.Add(new ValidationItem(billPayment.Customer.CPF, "CPF"));
            inputs.Add(new ValidationItem(billPayment.Customer.Name, "Nome"));
            inputs.Add(new ValidationItem(billPayment.Customer.RG, "RG"));
            inputs.Add(new ValidationItem(billPayment.Customer.Gender, "Sexo"));
            inputs.Add(new ValidationItem(billPayment.Customer.Birthday.ToString(), "Data de Nascimento"));
            inputs.Add(new ValidationItem(billPayment.Customer.CellPhone, "Celular"));
            inputs.Add(new ValidationItem(billPayment.Customer.Phone, "Telefone"));

            inputs.Add(new ValidationItem(billPayment.Customer.Address.Street, "Rua"));
            inputs.Add(new ValidationItem(billPayment.Customer.Address.Number, "Numero"));
            inputs.Add(new ValidationItem(billPayment.Customer.Address.Complement, "Complemento"));
            inputs.Add(new ValidationItem(billPayment.Customer.Address.District, "Bairro"));
            inputs.Add(new ValidationItem(billPayment.Customer.Address.City, "Cidade"));
            inputs.Add(new ValidationItem(billPayment.Customer.Address.State, "Estado"));

            inputs.Add(new ValidationItem(billPayment.PaymentDate.ToString(), "Data de Pagamento"));

            Validations val = new Validations();
            return val.ValidationCheck(inputs);      
        }

    }
}
