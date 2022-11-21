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

        List<cars> car = new List<cars>();
        public List<cars> Cars
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }
        public bool AddCar(string Name, double Price)
        {
            if(string.IsNullOrEmpty(Name) || Price <= 0){
                return false;
            }
            cars temp = new cars(Name, Price);
            car.Add(temp);
            return true;
        }
    }
}
