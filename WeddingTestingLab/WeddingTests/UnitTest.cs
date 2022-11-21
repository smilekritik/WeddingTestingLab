using Microsoft.VisualStudio.TestTools.UnitTesting;
using WeddingTestingLab;


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

    }
}
