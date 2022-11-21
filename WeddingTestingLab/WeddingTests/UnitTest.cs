using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingTestingLab;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeddingTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void CheckGetCars()
        {
            List<cars> test = new List<cars>();
            cars temp = new cars("some", 1);
            test.Add(temp);
            var actual = test;

            order Some = new order();
            Some.AddCar("some", 1);
            var expected = Some.car;

            var expectedjson = JsonConvert.SerializeObject(expected);
            var actualjson = JsonConvert.SerializeObject(actual);
            Assert.AreEqual(expectedjson, actualjson);
        }

        [TestMethod]
        public void CheckAddCars()
        {
            order Some = new order();
            bool actual = Some.AddCar("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckRemoveCars()
        {
            order Some = new order();
            Some.AddCar("test", 20);
            bool actual = Some.RemoveCar("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }
    }
}
