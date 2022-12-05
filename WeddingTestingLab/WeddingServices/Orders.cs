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
            var carsInOrder = ServicesInOrder.Where(e => e is Car)
                .Select(e => new Car((e as Car).Name, e.Price)).ToList();
            var availableCars = AvailableServices.Where(e => e is Car)
                .Select(e => new Car((e as Car).Name, e.Price)).ToList();

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

        public List<Ceremony> GetAvailableCeremonies()
        {
            var ceremoniesInOrder = ServicesInOrder.Where(e => e is Ceremony)
                .Select(e => new Ceremony((e as Ceremony).Place, e.Price)).ToList();
            var availableCeremonies = AvailableServices.Where(e => e is Ceremony)
                .Select(e => new Ceremony((e as Ceremony).Place, e.Price)).ToList();

            foreach (var ceremony in ceremoniesInOrder)
            {
                availableCeremonies.Remove(availableCeremonies.Where(e => e.Place == ceremony.Place).FirstOrDefault());
            }

            return availableCeremonies;
        }

        public bool AddCeremony(string place, double price)
        {
            if (string.IsNullOrEmpty(place) || price <= 0)
            {
                return false;
            }

            var ceremonyForAdd = new Ceremony(place, price);

            if (AvailableServices.Where(e => e is Ceremony &&
               (e as Ceremony).Place == ceremonyForAdd.Place && (e as Ceremony).Price == ceremonyForAdd.Price).FirstOrDefault() == null
               || ServicesInOrder.Where(e => e is Ceremony &&
               (e as Ceremony).Place == ceremonyForAdd.Place && (e as Ceremony).Price == ceremonyForAdd.Price).FirstOrDefault() != null)
            {
                return false;
            }

            ServicesInOrder.Add(ceremonyForAdd);

            return true;
        }

        public bool RemoveCeremony(string place, double price)
        {
            var ceremonyForRemove = (Ceremony)ServicesInOrder.Where(e => e is Ceremony &&
               (e as Ceremony).Place == place && (e as Ceremony).Price == price).FirstOrDefault();

            if (AvailableServices.Where(e => e is Ceremony &&
               (e as Ceremony).Place == ceremonyForRemove.Place && (e as Ceremony).Price == ceremonyForRemove.Price)
                .FirstOrDefault() == null
               || ceremonyForRemove == null)
            {
                return false;
            }

            return ServicesInOrder.Remove(ceremonyForRemove);
        }

        public List<Cloth> GetAvailableClothes()
        {
            var clothesInOrder = ServicesInOrder.Where(e => e is Cloth)
                .Select(e => new Cloth((e as Cloth).Name, e.Price)).ToList();
            var availableClothes = AvailableServices.Where(e => e is Cloth)
                .Select(e => new Cloth((e as Cloth).Name, e.Price)).ToList();

            foreach (var cloth in clothesInOrder)
            {
                availableClothes.Remove(availableClothes.Where(e => e.Name == cloth.Name).FirstOrDefault());
            }

            return availableClothes;
        }

        public bool AddCloth(string name, double price)
        {
            if (string.IsNullOrEmpty(name) || price <= 0)
            {
                return false;
            }

            var clothForAdd = new Cloth(name, price);

            if (AvailableServices.Where(e => e is Cloth &&
               (e as Cloth).Name == clothForAdd.Name && (e as Cloth).Price == clothForAdd.Price).FirstOrDefault() == null
               || ServicesInOrder.Where(e => e is Cloth &&
               (e as Cloth).Name == clothForAdd.Name && (e as Cloth).Price == clothForAdd.Price).FirstOrDefault() != null)
            {
                return false;
            }

            ServicesInOrder.Add(clothForAdd);

            return true;
        }

        public bool RemoveCloth(string name, double price)
        {
            var clothForRemove = (Cloth)ServicesInOrder.Where(e => e is Cloth &&
               (e as Cloth).Name == name && (e as Cloth).Price == price).FirstOrDefault();

            if (AvailableServices.Where(e => e is Cloth &&
               (e as Cloth).Name == clothForRemove.Name && (e as Cloth).Price == clothForRemove.Price).FirstOrDefault() == null
               || clothForRemove == null)
            {
                return false;
            }

            return ServicesInOrder.Remove(clothForRemove);
        }

        public double Summary()
        {
            return ServicesInOrder.Sum(e => e.Price);
        }

        public List<Services> DescendingPrice()
        {
            return ServicesInOrder.OrderByDescending(e => e.Price).ToList();
        }
    }
}
