using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using TrainSet;

namespace TrainSetTests
{
    [TestFixture]
    public class LocomotiveTests
    {
        private Locomotive testLocomotive;

        [Test]
        [TestCase("TestiJuna", 2000, 5000)]
        public void CreateLocomotiveTest(string name, decimal weightInTons, decimal horsePower)
        {
            testLocomotive = new Locomotive(name, weightInTons, horsePower);

            Assert.IsNotNull(testLocomotive);
            Assert.IsTrue(testLocomotive.GetType() == typeof(Locomotive));
            Assert.Greater(testLocomotive.weightInTons, 0);
            Assert.Greater(testLocomotive.HorsePower, 0);
        }

        [Test]
        [TestCase("TestTrain", 34.5)]
        [TestCase("TestTrain", -34.5)]
        public void CreateTrainTest(string name, decimal horsePower)
        {
            testLocomotive = new Locomotive(name, 0, horsePower);

            Assert.IsNotNull(testLocomotive.name);
            Assert.Greater(testLocomotive.HorsePower, 0);
        }
    }
}
