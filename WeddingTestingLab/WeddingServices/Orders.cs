using System.Collections.Generic;
using System.Linq;
using WeddingTestingLab;

namespace WeddingServices
{
    public sealed class Orders
    {
        public List<Services> ServicesInOrder { get; set; } = new List<Services>();
        public List<Services> AvailableServices { get; set; } = new List<Services>{
            new Car("Some car1", 100),
            new Car("Some car2", 200),
            new Car("Some car3", 300),
            new Car("Some car4", 400),
            new Ceremony("Some ceremony1", 100),
            new Ceremony("Some ceremony2", 200),
            new Ceremony("Some ceremony3", 300),
            new Ceremony("Some ceremony4", 400),
            new Cloth("Some cloth1", 100),
            new Cloth("Some cloth2", 200),
            new Cloth("Some cloth3", 300),
            new Cloth("Some cloth4", 400),
            };

        public List<Car> GetAvailableCars()
        {
            var carsInOrder = ServicesInOrder.Where(e => e is Car).Select(e => new Car((e as Car).Name, e.Price)).ToList();
            var availableCars = AvailableServices.Where(e => e is Car).Select(e => new Car((e as Car).Name, e.Price)).ToList();

            foreach (var car in carsInOrder)
            {
                availableCars.Remove(availableCars.Where(e => e.Name == car.Name).FirstOrDefault());
            }

            return availableCars;
        }

        public bool AddCar(string name, double price)
        {
            if (string.IsNullOrEmpty(name) || price <= 0)
            {
                return false;
            }

            var carForAdd = new Car(name, price);

            if (AvailableServices.Where(e => e is Car &&
               (e as Car).Name == carForAdd.Name && (e as Car).Price == carForAdd.Price).FirstOrDefault() == null
               || ServicesInOrder.Where(e => e is Car &&
               (e as Car).Name == carForAdd.Name && (e as Car).Price == carForAdd.Price).FirstOrDefault() != null)
            {
                return false;
            }

            ServicesInOrder.Add(carForAdd);

            return true;
        }

        public bool RemoveCar(string name, double price)
        {
            var carForRemove = (Car)ServicesInOrder.Where(e => e is Car &&
               (e as Car).Name == name && (e as Car).Price == price).FirstOrDefault();

            if (AvailableServices.Where(e => e is Car &&
               (e as Car).Name == carForRemove.Name && (e as Car).Price == carForRemove.Price).FirstOrDefault() == null
               || carForRemove == null)
            {
                return false;
            }

            return ServicesInOrder.Remove(carForRemove);
        }

        //public bool AddCloth(string Name, double Price)
        //{
        //    if (string.IsNullOrEmpty(Name) || Price <= 0)
        //    {
        //        return false;
        //    }
        //    Cloth temp = new Cloth(Name, Price);
        //    cloth.Add(temp);
        //    return true;
        //}

        //public bool RemoveCloth(string Name, double Price)
        //{
        //    var test = cloth.Single(r => r.name == Name);
        //    return cloth.Remove(test);
        //}
        //public bool AddCeremonie(string Place, double Price)
        //{
        //    if (string.IsNullOrEmpty(Place) || Price <= 0)
        //    {
        //        return false;
        //    }
        //    ceremonies temp = new ceremonies(Place, Price);
        //    ceremonie.Add(temp);
        //    return true;
        //}

        //public bool RemoveCeremonie(string Place, double Price)
        //{
        //    var test = ceremonie.Single(r => r.place == Place);
        //    return ceremonie.Remove(test);
        //}

        //public double Summary()
        //{
        //    double sum = 0;

        //    sum += ceremonie.Sum(item => item.price);
        //    sum += cloth.Sum(item => item.price);
        //    sum += car.Sum(item => item.price);
        //    return sum;
        //}

        //public order DescendingPrice()
        //{
        //    double sum = 0;
        //    List<Services> orders = new List<Services>();
        //    orders.AddRange(cloth);
        //    orders.AddRange(car);
        //    orders.AddRange(ceremonie);
        //    orders.OrderByDescending(item => item.price);
        //    return this;
        //}
    }
}
