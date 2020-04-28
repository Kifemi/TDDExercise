using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TrainSet
{
    public class Train
    {
        public decimal horsePowerRequired{ get; set; }
        public decimal totalHorsePower { get; set; }

        public List<RollingStock> rollingStocks = new List<RollingStock>();

        public Train()
        {

        }

        public void AddCar(Car car)
        {
            rollingStocks.Add(car);
            this.horsePowerRequired += car.horsePowerRequiredEmptyCar;
        }

        public void AddLocomotive(Locomotive locomotive)
        {
            rollingStocks.Add(locomotive);
            this.totalHorsePower += locomotive.HorsePower;
        }

        public bool HasLocomotive()
        {
            if (rollingStocks.OfType<Locomotive>().Any())
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
            if (rollingStocks.OfType<Car>().Any())
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
                if (rollingStock is Car)
                {
                    output.Add((Car) rollingStock);
                }
            }

            return output;
        }

        public List<Locomotive> GetAllLocomotives()
        {
            List<Locomotive> output = new List<Locomotive>();

            foreach (RollingStock rollingStock in rollingStocks)
            {
                if (rollingStock is Locomotive)
                {
                    output.Add((Locomotive)rollingStock);
                }
            }

            return output;
        }

        public List<RollingStock> GetRollingStocks(Train train)
        {   
            List<RollingStock> output = new List<RollingStock>(train.GetAllCars());

            output.AddRange(train.GetAllLocomotives());

            return output;
        }

        public bool HasEnoughHorsePower()
        {
            if (this.GetAllLocomotives().Count <= 0)
            {
                return false;
            }

            if (this.CalculateTotalHPRequired() > this.totalHorsePower)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public decimal TotalCargo()
        {
            decimal totalLoad = 0;

            foreach (Car car in this.GetAllCars())
            {
                totalLoad += car.load;
            }

            return totalLoad;
        }

        public decimal TotalHorsePowerAvailable()
        {
            decimal totalHorsePowerAvailable = 0;

            foreach (Locomotive locomotive in this.GetAllLocomotives())
            {
                totalHorsePowerAvailable += locomotive.HorsePower;
            }

            return totalHorsePowerAvailable - horsePowerRequired;
        }

        public decimal CalculateTotalHPRequired()
        {
            
            decimal totalLocomotiveWeightKg = 0;

            foreach (Locomotive locomotive in this.GetAllLocomotives())
            {
                totalLocomotiveWeightKg += locomotive.weightInTons;
            }

            return (this.horsePowerRequired + (this.TotalCargo() + totalLocomotiveWeightKg) * 0.8m * 100);
        }
    }
}
