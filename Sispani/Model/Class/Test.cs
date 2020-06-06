using System;
using Sispani.Controller;

namespace Sispani.Model
{
    public class Test
    {
        private static readonly Random _rand = new Random();

        public static void InsertOnCustomer(int amount)
        {
            for (int i = 0; i < amount; i++)
            {
                string cpf;
                do
                {
                    cpf = GenerateCPF();
                } while (CustomerDAO.Select(cpf) != null);
                cpf = InsertCPFPunc(cpf);
                CustomerDAO.Insert(
                    new Customer("nome " + i, cpf, "123456" + i, "F", new DateTime(2000, 1, 1), "(47) 9999-9999", "(47) 99999-9999",
                    new Address("rua" + i, "" + i, "", "bairro", "cidade", "estado"))
                );
            }
        }

        public static string InsertCPFPunc(string cpf)
        {
            string[] cpfParts = new string[4];
            cpfParts[0] = cpf.Remove(3, 8);
            cpf = cpf.Remove(0, 3);
            cpfParts[1] = cpf.Remove(3, 5);
            cpf = cpf.Remove(0, 3);
            cpfParts[2] = cpf.Remove(3, 2);
            cpf = cpf.Remove(0, 3);
            cpfParts[3] = cpf;
            return string.Format("{0}.{1}.{2}-{3}", cpfParts[0], cpfParts[1], cpfParts[2], cpfParts[3]);
        }

        private static string GenerateCPF()
        {
            int sum = 0;
            int rest;
            int[] multipliers = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string seed;

            do
            {
                seed = _rand.Next(1, 999999999).ToString().PadLeft(9, '0');
            }
            while (
                seed.Equals("000000000") ||
                seed.Equals("111111111") ||
                seed.Equals("222222222") ||
                seed.Equals("333333333") ||
                seed.Equals("444444444") ||
                seed.Equals("555555555") ||
                seed.Equals("666666666") ||
                seed.Equals("777777777") ||
                seed.Equals("888888888") ||
                seed.Equals("999999999")
            );

            for (int i = 1; i < multipliers.Length; i++)
                sum += int.Parse(seed[i - 1].ToString()) * multipliers[i];

            rest = sum % 11;

            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            seed += rest;
            sum = 0;

            for (int i = 0; i < multipliers.Length; i++)
                sum += int.Parse(seed[i].ToString()) * multipliers[i];

            rest = sum % 11;

            if (rest < 2)
                rest = 0;
            else
                rest = 11 - rest;

            seed += rest;

            return seed;
        }
    }
}
