namespace kursvaya.validator
{
    public class carValidator
    {
        public bool priceValidator(double price)
        {
            return price > 0;
        }

        public bool modelValidator(string model)
        {
            return model.Length > 0;
        }

        public bool numberValidator(string number)
        {
            return number.Length > 0;
        }

    }
}