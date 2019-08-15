using System;
using Xunit;
using Patterns.UnRefactored.Decorator;
namespace PatternsTest.Decorator
{

public class CarRentalTests{
        [Fact]
        public void CarRentalBasicTests()
        {
            Model mdl = new Model("Maruti" ,10.0f,50.0f);

            CarRental rental = new CarRental(mdl,10);
            Assert.Equal(rental.CalculatePrice(), 100.0f);

            CarRental rental2 = new CarRental(mdl,5);
            rental2.SetInsuranceRate(12.5f);
            Assert.Equal(rental2.CalculatePrice(), 112.5f);

             CarRental rental3 = new CarRental(mdl,5);
            rental3.SetInsuranceRate(12.5f);
            rental3.SetRefuelPrice(3.75f);
            Assert.Equal(rental3.CalculatePrice(), 300.0f);
        }

}

}