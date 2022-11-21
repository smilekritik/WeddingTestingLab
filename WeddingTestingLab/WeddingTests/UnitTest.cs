using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingTestingLab;
using System.Collections.Generic;

namespace WeddingTests
{
    [TestClass]
    public class OrderTest
    {

        [TestMethod]
        public void CheckAddCars()
        {
            order Some = new order();
            bool actual = Some.AddCar("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckGetCars()
        {
            List<cars> test = new List<cars>();
            cars temp = new cars("some", 1);
            test.Add(temp);
            var actual = test;

            order Some = new order();
            Some.AddCar("some", 1);
            var expected = Some.Cars;

            Assert.AreEqual(expected, actual);
        }
    }
}
