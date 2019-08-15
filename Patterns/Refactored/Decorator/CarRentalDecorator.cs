using System;

namespace Patterns.Refactored.Decorator{
   
   

    public abstract class CarRentalDecorator : IRental
    {
        protected IRental rental;

        public CarRentalDecorator(IRental instance)
        {
            rental = instance;
        }

        public virtual float CalculatePrice()
        {
            return rental.CalculatePrice();
        }

        public int GetDaysRented()
        {
            return rental.GetDaysRented();
        }

        public Model GetModel()
        {
            return rental.GetModel();
        }

        public void SetFuelConsumed(float amount)
        {
            rental.SetFuelConsumed(amount);
        }

        public float GetFuelConsumed()
        {
            return rental.GetFuelConsumed();
        }


     

        
       
        
    }

}