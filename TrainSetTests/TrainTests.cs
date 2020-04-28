using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TrainSet;

namespace TrainSetTests
{
    [TestFixture]
    public class TrainTests
    {
        private Train testTrain;

        [SetUp]
        public void SetUp()
        {
            testTrain = new Train();
            testTrain.AddLocomotive(new Locomotive("TestiJuna", 5000));
            testTrain.AddCar(new Car("TestiVaunu", 3000));
            
        }

        [Test]
        public void AddCarTest() 
        {
            Car car = new Car();
            testTrain.AddCar(car);

            Assert.Greater(testTrain.rollingStocks.Count, 0);
        }

        [Test]
        public void AddLocomotive()
        {
            Assert.IsNotNull(testTrain.HasLocomotive());
        }

        [Test]
        public void HasLocomotiveTest()
        {
            Assert.IsTrue(testTrain.HasLocomotive());
        }

        [Test]
        public void HasCars()
        {
            Assert.IsTrue(testTrain.HasCars());
        }
    }
}
