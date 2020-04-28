using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Car : RollingStock
    {
        public decimal horsePowerRequiredEmptyCar { get; set; }
        public decimal load { get; set; }
        public decimal MaxLoad { get; set; }

        public Car(string name, decimal requiredPower, decimal maxLoad)
        {
            this.name = name;
            this.horsePowerRequiredEmptyCar = requiredPower;
            this.MaxLoad = maxLoad;
            this.load = 0;
        }

        public decimal AddLoad(decimal load)
        {
            decimal spaceLeft = this.MaxLoad - this.load;

            if(load > spaceLeft)
            {
                this.load = MaxLoad;
                return spaceLeft - load;
            }

            this.load += load;
            spaceLeft -= load;

            return spaceLeft;
        }
    }
}
