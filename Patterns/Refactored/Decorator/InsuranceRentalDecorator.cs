namespace Patterns.Refactored.Decorator{
    public class InsuranceRentalDecorator : CarRentalDecorator
    {
        
        private float insuranceRate;
            

        public InsuranceRentalDecorator(IRental rentalInstance,float rate):base(rentalInstance){
          
            insuranceRate = rate;
        }
        public override float CalculatePrice()
        {
            return rental.CalculatePrice() + CalculateInsurance();
        }

       

       
        private float CalculateInsurance()
        {
            return rental.GetDaysRented() * insuranceRate;
        }
      

       

        
    }

}