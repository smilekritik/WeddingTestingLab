using System;

namespace WeddingTestingLab
{
    public sealed class Car : Services
    {
        public readonly string Name;

        public Car(string name, double price)
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
