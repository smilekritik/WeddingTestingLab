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
            throw new NotImplementedException();
        }

        public bool RemoveCloth(string Name, double Price)
        {
            throw new NotImplementedException();
        }
        public bool AddCeremonie(string Place, double Price)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCeremonie(string Place, double Price)
        {
            throw new NotImplementedException();
        }

    }
}
