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

        [TestMethod]
        public void CheckGetCloth()
        {
            List<clothes> test = new List<clothes>();
            clothes temp = new clothes("some", 1);
            test.Add(temp);
            var actual = test;

            order Some = new order();
            Some.AddCloth("some", 1);
            var expected = Some.cloth;

            var expectedjson = JsonConvert.SerializeObject(expected);
            var actualjson = JsonConvert.SerializeObject(actual);
            Assert.AreEqual(expectedjson, actualjson);
        }

        [TestMethod]
        public void CheckAddCloth()
        {
            order Some = new order();
            bool actual = Some.AddCloth("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckRemoveCloth()
        {
            order Some = new order();
            Some.AddCloth("test", 20);
            bool actual = Some.RemoveCloth("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckGetCeremonie()
        {
            List<ceremonies> test = new List<ceremonies>();
            ceremonies temp = new ceremonies("some", 1);
            test.Add(temp);
            var actual = test;

            order Some = new order();
            Some.AddCeremonie("some", 1);
            var expected = Some.ceremonie;

            var expectedjson = JsonConvert.SerializeObject(expected);
            var actualjson = JsonConvert.SerializeObject(actual);
            Assert.AreEqual(expectedjson, actualjson);
        }

        [TestMethod]
        public void CheckAddCeremonie()
        {
            order Some = new order();
            bool actual = Some.AddCeremonie("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckRemoveCeremonie()
        {
            order Some = new order();
            Some.AddCeremonie("test", 20);
            bool actual = Some.RemoveCeremonie("test", 20);
            bool expected = true;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckSummaryOrder()
        {
            order Some = new order();
            Some.AddCloth("test", 322);
            Some.AddCar("test2", 10);
            double expected = 322 + 10;
            double actual = Some.Summary();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckSummaryOrderDescending()
        {
            order Some = new order();
            Some.AddCloth("test", 322);
            Some.AddCar("test2", 10);
            var actual = Some.DescendingPrice();

            order Some2 = new order();
            Some2.AddCar("test2", 10);
            Some2.AddCloth("test", 322);
            var expected = Some2;

            var expectedjson = JsonConvert.SerializeObject(expected);
            var actualjson = JsonConvert.SerializeObject(actual);
            Assert.AreEqual(expectedjson, actualjson);
        }
    }
}
