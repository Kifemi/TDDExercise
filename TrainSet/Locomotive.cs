using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Locomotive : RollingStock
    {        
        public decimal weightInTons { get; set; }
        private Decimal _horsePower;

        public Decimal HorsePower
        {
            get { return _horsePower; }
            set
            {
                if (value < 1)
                {
                    value = 1;
                }

                _horsePower = value;
            }
        }


        public Locomotive(string name, decimal weightInTons, decimal horsePower)
        {
            this.name = name;
            this.weightInTons = weightInTons;
            this.HorsePower = horsePower;
        }
    }
}
