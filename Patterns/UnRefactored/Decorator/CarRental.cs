using System;

namespace Patterns.UnRefactored.Decorator{
    

    public class CarRental 
    {
        protected float fuelConsumed;
        protected int days;
        protected Model model;

        protected float insuranceRate;
        protected bool hasInsurance;
        protected float refuelPrice;
        protected bool hasRefuelOnReturn;

        public CarRental(Model model, int rentalDays)
        {
            days = rentalDays;
            this.model = model;
            hasInsurance = false;
            hasRefuelOnReturn = false;
        }

        public float CalculatePrice()
        {
            float price = model.Price * days;
            if (hasInsurance)
            {
                price += CalculateInsurance();

            }
            if (hasRefuelOnReturn)
            {
                price += CalculateRefuelPrice();
            }


            return price;
        }

        public int GetDaysRented()
        {
            return days;
        }

        public Model GetModel()
        {
            return model;
        }

        public void SetFuelConsumed(float amount)
        {
            fuelConsumed = amount;
        }

        public float GetFuelConsumed()
        {
            return fuelConsumed;
        }

        public void SetInsuranceRate(float rate)
        {
            insuranceRate = rate;
            hasInsurance = true;
        }

        public void SetRefuelPrice(float pricePerGallon)
        {
            refuelPrice = pricePerGallon;
            hasRefuelOnReturn = true;
        }
        private float CalculateRefuelPrice()
        {
            return (GetModel().FuelCapacity - GetFuelConsumed()) * refuelPrice;
        }

        private float CalculateInsurance()
        {
            return GetDaysRented() * insuranceRate;
        }
    }

}