using System;
using System.Collections.Generic;
using System.Text;

namespace TrainSet
{
    public class Train
    {
        public List<RollingStock> rollingStocks = new List<RollingStock>();

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
            throw new NotImplementedException("asdf");
        }
    }
}
