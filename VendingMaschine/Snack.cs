using System;

namespace VendingMachine
{
    class Snack : Produkt
    {
        public string CandyType { get; set; }

        public Snack(string name, int price, string candytype) : base(name, price)
        {
            CandyType = candytype;
        }
        public override void Info()
        {
            Console.Write("Which type of candy? " + CandyType);
            base.Info();

        }
    }
}
