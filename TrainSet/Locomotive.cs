using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Locomotive : RollingStock
    {
        public decimal horsePower { get; set; }
        public decimal weightInTons { get; set; }

        public Locomotive()
        {
               
        }

        public Locomotive(string name, decimal horsePower)
        {
            this.name = name;
            this.horsePower = horsePower;
        }
    }
}
