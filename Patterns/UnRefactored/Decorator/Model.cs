using System;
namespace Patterns.UnRefactored.Decorator{

    public class Model
    {

        public Model(string name, float price, float fuelCapacity ){
            this.Price = price;
            this.Name = name;
            this.FuelCapacity= fuelCapacity;
        }
        public float Price { get; internal set; }
        public float FuelCapacity { get; internal set; }

        
        public string Name { get; internal set; }

    }
}