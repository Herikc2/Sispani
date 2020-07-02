using System;
using System.Collections;

namespace Sispani.Model
{
    public class Customer
    {
        public string Name { get; set; }
        public string CPF { get; set; }
        public string RG { get; set; }
        public string Gender { get; set; }
        public DateTime Birthday { get; set; }
        public string Phone { get; set; }
        public string CellPhone { get; set; }
        public Address Address { get; set; }
        public Bill Bill { get; set; }

        public Customer(string name, string cpf, string rg, string gender, DateTime birthday, string phone, string cellPhone, Address address)
        {
            Name = name;
            CPF = cpf;
            RG = rg;
            Gender = gender;
            Birthday = birthday;
            Phone = phone;
            CellPhone = cellPhone;
            Address = address;
        }

        public Customer(string name, string cpf, string rg, string gender, DateTime birthday, string phone, string cellPhone, Address address, Bill bill)
        {
            Name = name;
            CPF = cpf;
            RG = rg;
            Gender = gender;
            Birthday = birthday;
            Phone = phone;
            CellPhone = cellPhone;
            Address = address;
            Bill = bill;
        }

        public Customer(string name, string cpf)
        {
            Name = name;
            CPF = cpf;
        }

        public Customer(string name, string cPF, Bill bill) : this(name, cPF)
        {
            Bill = bill;
        }
    }
}
