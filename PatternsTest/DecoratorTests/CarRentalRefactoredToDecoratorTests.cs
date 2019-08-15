using System;
using Xunit;
using Patterns.Refactored.Decorator;
namespace PatternsTest.Decorator
{



public class CarRentalRefactoredToDecoratorTests{

    /*
        [Fact]
        public void CarRentalBasicTests()
        {
            Model mdl = new Model("Maruti" ,10.0f,50.0f);

            IRental maruti = new CarRental(mdl,5);
            maruti.SetInsuranceRate(12.5f);
            //Assert.Equal(maruti.CalculatePrice(), 100.0f);

            IRental insuredMaruti = new CarRental(mdl,5);
            insuredMaruti.SetInsuranceRate(12.5f);
            Assert.Equal(insuredMaruti.CalculatePrice(), maruti.CalculatePrice());

            
        }
        */
        [Fact]
        public void CarRentalInsurancDecoratorTests()
        {
            Model mdl = new Model("Maruti" ,10.0f,50.0f);
            IRental insuredMaruti = new InsuranceRental(new CarRental(mdl,5),12.5f);           
            Assert.Equal(insuredMaruti.CalculatePrice(),112.5f);

            
        }

         [Fact]
        public void CarRentalInsurancAndRefuelDecoratorTests()
        {
            Model mdl = new Model("Maruti" ,10.0f,50.0f);
            IRental insuredMaruti = new InsuranceRentalDecorator(new CarRental(mdl,5),12.5f); 
            IRental refuelInsuredMaruti = new RefuelOnReturnDecorator(insuredMaruti,3.75f);          
            Assert.Equal(refuelInsuredMaruti.CalculatePrice(),300.0f);

            
        }

}


}