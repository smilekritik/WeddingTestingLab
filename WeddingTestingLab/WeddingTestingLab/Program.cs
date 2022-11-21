using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeddingTestingLab
{

    public class order
    {
        public static void Main()
        {

        }

        public List<cars> car { get; set; } = new List<cars>();
        public List<clothes> cloth { get; set; } = new List<clothes>();
        public List<ceremonies> ceremonie { get; set; } = new List<ceremonies>();

        public bool AddCar(string Name, double Price)
        {
            if(string.IsNullOrEmpty(Name) || Price <= 0){
                return false;
            }
            cars temp = new cars(Name, Price);
            car.Add(temp);
            return true;
        }

        public bool RemoveCar(string Name, double Price)
        {
            var test = car.Single(r => r.name == Name);
            return car.Remove(test);
        }

        public bool AddCloth(string Name, double Price)
        {
            if (string.IsNullOrEmpty(Name) || Price <= 0)
            {
                return false;
            }
            clothes temp = new clothes(Name, Price);
            cloth.Add(temp);
            return true;
        }

        public bool RemoveCloth(string Name, double Price)
        {
            var test = cloth.Single(r => r.name == Name);
            return cloth.Remove(test);
        }
        public bool AddCeremonie(string Place, double Price)
        {
            if (string.IsNullOrEmpty(Place) || Price <= 0)
            {
                return false;
            }
            ceremonies temp = new ceremonies(Place, Price);
            ceremonie.Add(temp);
            return true;
        }

        public bool RemoveCeremonie(string Place, double Price)
        {
            var test = ceremonie.Single(r => r.place == Place);
            return ceremonie.Remove(test);
        }

        public double Summary()
        {
            double sum = 0;

            sum += ceremonie.Sum(item => item.price);
            sum += cloth.Sum(item => item.price);
            sum += car.Sum(item => item.price);
            return sum;
        }

        public order DescendingPrice()
        {
            throw new NotImplementedException();
        }
    }
}
