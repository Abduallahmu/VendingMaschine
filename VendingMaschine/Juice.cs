using System;

namespace VendingMachine
{
    class Juice : Produkt
    {

        public double Volume { get; set; }

        public Juice(int id, string name, int price, double volume) : base(id, name)
        {
            Price = price;
            Volume = volume;

        }

        public Juice(string name, int price, double volume) : base(name, price)
        {
            Volume = volume;
        }

        public void Drink()
        {
            Console.WriteLine();
        }
        public override void Info()
        {
            Console.Write("Volume: Liter - " + Volume);
            base.Info();
        }

    }
}
