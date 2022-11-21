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
            throw new NotImplementedException();
        }
    }
}
