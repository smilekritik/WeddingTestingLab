using System;

namespace WeddingTestingLab
{
    public sealed class Cloth : Services
    {
        public readonly string Name;

        public Cloth(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override void Print()
        {
            Console.WriteLine("Name = " + Name + ", price = " + Price);
        }
    }
}
