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
        [Test]
        public void CreateLocomotiveTest()
        {
            Locomotive lc = new Locomotive("TestJuna", 5000);

            Assert.IsTrue(lc.name != null && lc.horsePower == 5000);
        }
    }
}
