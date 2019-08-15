

namespace Patterns.Refactored.Decorator{
    public class RefuelOnReturnDecorator : CarRentalDecorator
    {
        
       
        protected float refuelPrice; 

        public RefuelOnReturnDecorator(IRental rentalInstance,float price):base(rentalInstance){
          
            refuelPrice = price;
        }
        public override float CalculatePrice()
        {
            return rental.CalculatePrice() + CalculateRefuelPrice();
        }

       

       
          private float CalculateRefuelPrice()
        {
            return (rental.GetModel().FuelCapacity - rental.GetFuelConsumed()) * refuelPrice;
        }
      

       

        
    }

}