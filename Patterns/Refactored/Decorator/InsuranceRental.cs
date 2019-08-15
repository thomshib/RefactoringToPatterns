namespace Patterns.Refactored.Decorator{
    public class InsuranceRental : IRental
    {
        private IRental rental;
        private float insuranceRate;
            //hasInsurance = true;

        public InsuranceRental(IRental rentalInstance,float rate){
            rental = rentalInstance;
            insuranceRate = rate;
        }
        public float CalculatePrice()
        {
            return rental.CalculatePrice() + CalculateInsurance();
        }

        public int GetDaysRented()
        {
            return rental.GetDaysRented();
        }

        public float GetFuelConsumed()
        {
            return rental.GetFuelConsumed();
        }

        public Model GetModel()
        {
            return rental.GetModel();
        }

        public void SetFuelConsumed(float amount)
        {
            rental.SetFuelConsumed(amount);
        }


        /*  
         public void SetRefuelPrice(float pricePerGallon)
        {
            rental.SetRefuelPrice(pricePerGallon);
        }

       
        public void SetInsuranceRate(float rate)
        {
           rental.SetInsuranceRate(rate);
        }
        */
        private float CalculateInsurance()
        {
            return GetDaysRented() * insuranceRate;
        }
      

       

        
    }

}