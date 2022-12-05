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

        //[TestMethod]
        //public void CheckGetCloth()
        //{
        //    List<Cloth> test = new List<Cloth>();
        //    Cloth temp = new Cloth("some", 1);
        //    test.Add(temp);
        //    var actual = test;

        //    order Some = new order();
        //    Some.AddCloth("some", 1);
        //    var expected = Some.cloth;

        //    var expectedjson = JsonConvert.SerializeObject(expected);
        //    var actualjson = JsonConvert.SerializeObject(actual);
        //    Assert.AreEqual(expectedjson, actualjson);
        //}

        //[TestMethod]
        //public void CheckAddCloth()
        //{
        //    order Some = new order();
        //    bool actual = Some.AddCloth("test", 20);
        //    bool expected = true;

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void CheckRemoveCloth()
        //{
        //    order Some = new order();
        //    Some.AddCloth("test", 20);
        //    bool actual = Some.RemoveCloth("test", 20);
        //    bool expected = true;

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void CheckGetCeremonie()
        //{
        //    List<ceremonies> test = new List<ceremonies>();
        //    ceremonies temp = new ceremonies("some", 1);
        //    test.Add(temp);
        //    var actual = test;

        //    order Some = new order();
        //    Some.AddCeremonie("some", 1);
        //    var expected = Some.ceremonie;

        //    var expectedjson = JsonConvert.SerializeObject(expected);
        //    var actualjson = JsonConvert.SerializeObject(actual);
        //    Assert.AreEqual(expectedjson, actualjson);
        //}

        //[TestMethod]
        //public void CheckAddCeremonie()
        //{
        //    order Some = new order();
        //    bool actual = Some.AddCeremonie("test", 20);
        //    bool expected = true;

        //    Assert.AreEqual(expected, actual);
        //}

        //[TestMethod]
        //public void CheckRemoveCeremonie()
        //{
        //    order Some = new order();
        //    Some.AddCeremonie("test", 20);
        //    bool actual = Some.RemoveCeremonie("test", 20);
        //    bool expected = true;

        //    Assert.AreEqual(expected, actual);
        //}

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
