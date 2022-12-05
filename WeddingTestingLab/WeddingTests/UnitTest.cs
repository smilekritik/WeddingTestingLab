using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingTestingLab;
using System.Collections.Generic;
using Newtonsoft.Json;
using WeddingServices;

namespace WeddingTests
{
    [TestClass]
    public class OrderTest
    {
        [TestMethod]
        public void GetCars_SomeCar1WithPrice100_And_SomeCar2WithPrice200_Return_ListWith2Members()
        {
            Orders SomeOrder = new Orders();
            SomeOrder.AddCar("Some car1", 100);
            SomeOrder.AddCar("Some car2", 200);

            var actual = SomeOrder.GetAvailableCars();
            var expected = new List<Car> {
            new Car("Some car3", 300),
            new Car("Some car4", 400)
            };

            var expectedjson = JsonConvert.SerializeObject(expected);
            var actualjson = JsonConvert.SerializeObject(actual);

            Assert.AreEqual(expectedjson, actualjson);
        }

        [TestMethod]
        public void AddCar_SomeCar1WithPrice100_ReturnTrue()
        {
            Orders SomeOrder = new Orders();

            bool actual = SomeOrder.AddCar("Some car1", 100);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void RemoveCar_SomeCar1WithPrice100_ReturnTrue()
        {
            Orders SomeOrder = new Orders();

            SomeOrder.AddCar("Some car1", 100);
            bool actual = SomeOrder.RemoveCar("Some car1", 100);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void GetCeremonies_SomeCeremony1WithPrice100_And_SomeCeremony2WithPrice200_Return_ListWith2Members()
        {
            Orders SomeOrder = new Orders();
            SomeOrder.AddCeremony("Some ceremony1", 100);
            SomeOrder.AddCeremony("Some ceremony2", 200);

            var actual = SomeOrder.GetAvailableCeremonies();
            var expected = new List<Ceremony> {
            new Ceremony("Some ceremony3", 300),
            new Ceremony("Some ceremony4", 400)
            };

            var expectedjson = JsonConvert.SerializeObject(expected);
            var actualjson = JsonConvert.SerializeObject(actual);

            Assert.AreEqual(expectedjson, actualjson);
        }

        [TestMethod]
        public void AddCeremony_SomeCeremony1WithPrice100_ReturnTrue()
        {
            Orders SomeOrder = new Orders();

            bool actual = SomeOrder.AddCeremony("Some ceremony1", 100);

            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void RemoveCeremony_SomeCeremony1WithPrice100_ReturnTrue()
        {
            Orders SomeOrder = new Orders();

            SomeOrder.AddCeremony("Some ceremony1", 100);
            bool actual = SomeOrder.RemoveCeremony("Some ceremony1", 100);

            Assert.IsTrue(actual);
        }

        //[TestMethod]
        //public void CheckSummaryOrder()
        //{
        //    order Some = new order();
        //    Some.AddCloth("test", 322);
        //    Some.AddCar("test2", 10);
        //    double expected = 322 + 10;
        //    double actual = Some.Summary();

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void CheckSummaryOrderDescending()
        //{
        //    order Some = new order();
        //    Some.AddCloth("test", 322);
        //    Some.AddCar("test2", 10);
        //    var actual = Some.DescendingPrice();

        //    order Some2 = new order();
        //    Some2.AddCar("test2", 10);
        //    Some2.AddCloth("test", 322);
        //    var expected = Some2;

        //    var expectedjson = JsonConvert.SerializeObject(expected);
        //    var actualjson = JsonConvert.SerializeObject(actual);
        //    Assert.AreEqual(expectedjson, actualjson);
        //}
    }
}
