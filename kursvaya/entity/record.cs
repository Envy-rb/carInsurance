using kursvaya.service;
using System;
using System.Runtime.InteropServices;

namespace kursvaya
{
    [Serializable]
    public class record
    {
        private car car;
        private double insurancePrice;
        private DateTime date;

        public record(car car, double insurancePrice, DateTime date)
        {
            this.car = car ?? throw new ArgumentNullException(nameof(car));
            insuranceService _insuranceService = new insuranceService(insurancePrice);
            this.insurancePrice = _insuranceService.insurancePrice(car);
            this.date = date;
        }

        public car Car => car;

        public double InsurancePrice => insurancePrice;

        public DateTime Date => date;

        public override string ToString()
        {
            return $"{nameof(car)}: {car.ToStringAdv()}, {nameof(insurancePrice)}: {insurancePrice}, {nameof(date)}: {date.ToShortDateString()}";
        }

        public string carNumber => car.Number;
    }
}