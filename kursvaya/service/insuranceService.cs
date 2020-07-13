namespace kursvaya.service
{
    public class insuranceService
    {
        private double basicTariff;

        public insuranceService(double basicTariff)
        {
            this.basicTariff = basicTariff;
        }

        public double BasicTariff => basicTariff;

        public double getCoefficient(person owner)
        {
            int age = owner.Age;
            int drivinExp = owner.DrivingExperience;
            double coef = 2;
            if (age < 22 && drivinExp <= 3)
                coef = 1.8;
            else if (age > 22 && drivinExp <= 3)
                coef = 1.7;
            else if (age < 22 && drivinExp > 3)
                coef = 1.6;
            else if (age > 22 && drivinExp > 3)
                coef = 1;
            return coef;
        }
        
        public double insurancePrice(car _car)
        {
            person owner = _car.Owner;

            double price = _car.Price * getCoefficient(owner) + basicTariff * getCoefficient(owner);


            return price;
        }
    }
}