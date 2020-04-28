using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Train
    {
        public string  name { get; set; }
        private decimal _horsePower;

        public decimal HorsePower
        {
            get { return _horsePower; }
            set
            {
                if(value < 1)
                {
                    value = 1;
                }

                _horsePower = value; 
            }
        }

        public List<RollingStock> rollingStocks = new List<RollingStock>();

        public Train()
        {

        }

        public Train(string name, decimal horsePower)
        {
            this.name = name;
            this.HorsePower = horsePower;
        }

        public void AddCar(Car car)
        {
            rollingStocks.Add(car);
        }

        public void AddLocomotive(Locomotive locomotive)
        {
            rollingStocks.Add(locomotive);
        }

        public bool HasLocomotive()
        {
            var x = rollingStocks.Find(x => x.GetType() == typeof(Locomotive));
            if(x != null)
            {
                return true;
            }
            else
            {
                return false;
            }  
        }

        public bool HasCars()
        {
            RollingStock x = rollingStocks.Find(x => x.GetType() == typeof(Car));
            if(x != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public List<Car> GetAllCars()
        {
            List<Car> output = new List<Car>();

            foreach (RollingStock rollingStock in rollingStocks)
            {
                if (rollingStock.GetType() == typeof(Car))
                {
                    output.Add((Car)rollingStock);
                }
            }

            return output;
        }

        public List<Locomotive> GetAllLocomotives()
        {
            List<Locomotive> output = new List<Locomotive>();

            foreach (RollingStock rollingStock in rollingStocks)
            {
                if(rollingStock.GetType() == typeof(Locomotive))
                {
                    output.Add((Locomotive)rollingStock);
                }
            }

            return output;
        }

        public List<RollingStock> GetWholeTrain(Train train)
        {   
            List<RollingStock> output = new List<RollingStock>(train.GetAllCars());

            output.AddRange(train.GetAllLocomotives());

            return output;
        }
    }
}
