using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TrainSet;

namespace TrainSetTests
{
    public class CarTests
    {
        private Car testCar;

        [SetUp]
        public void SetUp()
        {
            testCar = new Car("TestiVaunu", 1000, 450);
        }

        [Test]
        public void CreateCarTest()
        {
            Assert.IsNotNull(testCar);
            Assert.NotZero(testCar.horsePowerRequiredEmptyCar);
            Assert.Greater(testCar.MaxLoad, 0);
        }

        [Test]
        [TestCase(200,0, 250, 250)]
        [TestCase(100, 400, 350, -50)]
        public void AddLoad(int testNumber, int testNumber2, int result1, int result2)
        {
            Assert.AreEqual(testCar.AddLoad(testNumber), result1);
            Assert.AreEqual(testCar.AddLoad(testNumber2), result2);
        }
    }
}
