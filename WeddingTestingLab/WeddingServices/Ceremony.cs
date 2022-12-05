using System;

namespace WeddingTestingLab
{
    public sealed class Ceremony : Services
    {
        public readonly string Place;

        public Ceremony(string place, double price)
        {
            Place = place;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine("Place = " + Place + ", price = " + Price);
        }
    }
}
