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
        private Car testivaunu1;
        private Car testivaunu2;
        private Car testivaunu3;

        [SetUp]
        public void SetUp()
        {
            testTrain = new Train();
            testTrain.AddLocomotive(new Locomotive("TestiVeturi", 1500, 250000));
            testivaunu1 = new Car("TestiVaunu1", 2500, 500);
            testivaunu2 = new Car("TestiVaunu2", 2000, 400);
            testivaunu3 = new Car("TestiVaunu3", 400, 100);
            testTrain.AddCar(testivaunu1);
            testTrain.AddCar(testivaunu2);
            testTrain.AddCar(testivaunu3);
            

        }

        [Test]
        public void HasLocomotiveTest()
        {
            Assert.IsTrue(testTrain.HasLocomotive());
        }

        [Test]
        public void HasCarsTest()
        {
            Assert.IsTrue(testTrain.HasCars());
        }

        [Test]
        [TestCase(3)]
        public void GetAllCarsTest(int testNumber)
        {
            Assert.IsNotNull(testTrain.GetAllCars());
            Assert.AreEqual(testNumber, testTrain.GetAllCars().Count);
        }

        [Test]
        [TestCase(1)]
        public void GetAllLocomotivesTest(int testNumber)
        {
            Assert.IsNotNull(testTrain.GetAllLocomotives());
            Assert.AreEqual(testNumber, testTrain.GetAllLocomotives().Count);
        }

        [Test] 
        [TestCase(4)]
        public void GetRollingStocksTest(int testNumber)
        {
            Assert.IsNotNull(testTrain.GetRollingStocks(testTrain));
            Assert.AreEqual(testTrain.GetRollingStocks(testTrain).Count, testNumber);
        }

        [Test]
        public void HasEnoughHorsePowerTest()
        {
            Assert.IsTrue(testTrain.HasEnoughHorsePower());
        }

        [Test]
        [TestCase(0, 0, 0, 0, 0)]
        [TestCase(100.10, 500, 200, 90.35, 180000)]
        public void CalculateTotalHPRequiredTest(decimal number1, decimal number2, decimal number3, decimal number4, decimal result)
        {
            testivaunu1.AddLoad(number1);
            testivaunu1.AddLoad(number2);
            testivaunu2.AddLoad(number3);
            testivaunu3.AddLoad(number4);
            Assert.Greater(testTrain.CalculateTotalHPRequired(), result);
        }

        [Test]
        [TestCase(100.10, 500, 200, 90.35, 790, 800)]
        public void TotalCargoTest(decimal number1, decimal number2, decimal number3, decimal number4, decimal result1, decimal result2)
        {
            testivaunu1.AddLoad(number1);
            testivaunu1.AddLoad(number2);
            testivaunu2.AddLoad(number3);
            testivaunu3.AddLoad(number4);
            Assert.Greater(testTrain.TotalCargo(), result1);
            Assert.Less(testTrain.TotalCargo(), result2);
        }

        [Test]
        public void TotalHorsePowerAvailableTest()
        {
            Assert.AreEqual(testTrain.TotalHorsePowerAvailable(), 100);
        }

    }
}
