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
        private Locomotive testLocomotive;

        [SetUp]
        public void SetUp()
        {
            testTrain = new Train();
            testLocomotive = new Locomotive("TestiJuna", 5000);
            testTrain.AddLocomotive(testLocomotive);
            testTrain.AddLocomotive(new Locomotive("TestiLocomotive", 4000));
            testTrain.AddCar(new Car("TestiVaunu", 3000));
            
        }

        [Test]
        public void CreateLocomotiveTest()
        {
            Assert.IsNotNull(testLocomotive);
            Assert.IsTrue(testLocomotive.GetType() == typeof(Locomotive));
        }

        [Test]
        [TestCase("TestTrain", 34.5)]
        [TestCase("TestTrain", -34.5)]
        public void CreateTrainTest(string name, decimal horsePower)
        {
            Train testTrain1 = new Train(name, horsePower);

            Assert.IsNotNull(testTrain1.name);
            Assert.Greater(testTrain1.HorsePower, 0);
        }

        [Test]
        public void AddCarTest() 
        {
            Assert.Greater(testTrain.rollingStocks.Count, 0);
        }

        [Test]
        public void AddLocomotiveTest()
        {
            Assert.IsNotNull(testTrain.HasLocomotive());
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
        [TestCase(1)]
        public void GetAllCarsTest(int testNumber)
        {
            Assert.IsNotNull(testTrain.GetAllCars());
            Assert.AreEqual(testTrain.GetAllCars().Count, testNumber);
        }

        [Test]
        public void GetAllLocomotivesTest()
        {
            Assert.IsNotNull(testTrain.GetAllLocomotives());
            Assert.Contains(testLocomotive, testTrain.rollingStocks);
        }

        //[Test]
        //[TestCase(testTrain)]
        //public void GetWholeTrainTest(Train train)
        //{
        //    Assert.IsNotNull(testTrain.GetWholeTrain());
        //    Assert.AreEqual(testTrain.GetWholeTrain().Count, testNumber);
        //}


    }
}
