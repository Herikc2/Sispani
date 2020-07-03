using System.Collections.Generic;
using System.Windows;

namespace Sispani.Model.Util.Validations
{
    public class Validations
    {
        public Message Message { get; set; }
        public bool Validator { get; set; }
        public string TempMessage { get; set; }

        public Validations()
        {
            Message = new Message();
            Validator = true;
            TempMessage = "";
        }

        public void ClearString()
        {
            if (TempMessage != "")
            {
                Message.Add(TempMessage);
                TempMessage = "";
                Validator = false;
            }
        }

        public void CheckMsgInputGeneric(string input, string field)
        {
            TempMessage = CheckInputMessage(input, field);
            ClearString();
        }

        public bool CheckInput(string input)
        {
            if (input == null)
                return true;

            List<string> trash = new List<string>();
            string textOK = input;

            trash.Add("select");
            trash.Add("drop");
            trash.Add(";");
            trash.Add("--");
            trash.Add("insert");
            trash.Add("delete");
            trash.Add("xp_");
            trash.Add("alter");
            trash.Add("table");

            for (int i = 0; i < trash.Count; i++)
                textOK = textOK.Replace(trash[i], "");

            if (input.Equals(textOK)) return true;
            return false;
        }

        public string CheckInputMessage(string input, string field)
        {
            if (!CheckInput(input))
                return "O campo " + field + " está invalido!";
            return "";
        }

        public bool ValidationCheck(List<ValidationItem> inputs)
        {
            if (inputs != null)
            {
                Message.Add("O formulário possui as seguintes invalidações:");

                for (int i = 0; i < inputs.Count; i++)
                    CheckMsgInputGeneric(inputs[i].Value, inputs[i].ValueName);

                if (Validator)
                {
                    Message.ClearMessage();
                    return true;
                }
                else
                {
                    MessageBox.Show(Message.Value,
                        "Campos Invalidos", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return false;
                }
            }
            else
                return true;
        }

    }
}
