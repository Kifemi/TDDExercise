using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Car : RollingStock
    {
        public decimal horsePowerRequiredEmptyCar { get; set; }

        public Car()
        {

        }

        public Car(string name, decimal requiredPower)
        {
            this.name = name;
            this.horsePowerRequiredEmptyCar = requiredPower;
        }
    }
}
