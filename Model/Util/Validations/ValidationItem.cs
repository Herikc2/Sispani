namespace Sispani.Model.Util.Validations
{
    public class ValidationItem
    {
        public string Value { get; set; }
        public string ValueName { get; set; }

        public ValidationItem(string value, string valueName)
        {
            Value = value;
            ValueName = valueName;
        }
    }
}
