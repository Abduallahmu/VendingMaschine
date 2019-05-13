using System;

namespace VendingMachine
{
    class Frukt : Produkt
    {
        public string cigarette { get; set; }


        public Frukt(int id, string name, int prise, string sour) : base(id, name)
        {

            Price = prise;
            cigarette = sour;

        }
        public Frukt(string name, int price, string sour) : base(name, price)
        {

            Price = price;
            Name = name;
            cigarette = sour;
        }
        public override void Info()
        {
            Console.Write("Does it cigarette? " + cigarette);
            base.Info();

        }


    }
}
