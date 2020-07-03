namespace Sispani.Model.Util.Validations
{
    public class Message
    {
        public string Value;

        public Message()
        {
            Value = "";
        }

        public string Add(string input)
        {
            if (Value == "")
                Value = input;
            else
                Value += "\n" + "- " + input;

            return Value;
        }

        public void ClearMessage()
        {
            Value = "";
        }
    }
}
