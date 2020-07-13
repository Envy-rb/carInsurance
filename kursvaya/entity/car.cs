using System;

namespace kursvaya
{
    [Serializable]
    public class car
    {
        private person owner;
        private string model;
        private string number;
        private double price;

        public car(person owner, string model, string number, double price)
        {
            this.owner = owner ?? throw new ArgumentNullException(nameof(owner));
            this.model = model ?? throw new ArgumentNullException(nameof(model));
            this.number = number ?? throw new ArgumentNullException(nameof(number));
            this.price = price;
        }

        public car(string model, string number, double price)
        {
            this.model = model ?? throw new ArgumentNullException(nameof(model));
            this.number = number ?? throw new ArgumentNullException(nameof(number));
            this.price = price;
        }

        public override string ToString()
        {
            return $"{nameof(model)}: {model}, {nameof(number)}: {number}, {nameof(price)}: {price}\n";
        }

        public string ToStringAdv()
        {
            return $"owner:" + owner.ToString() + ToString();
        }
        
        public string Model
        {
            get => model;
            set => model = value;
        }

        public string Number
        {
            get => number;
            set => number = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public person Owner => owner;
    }
}