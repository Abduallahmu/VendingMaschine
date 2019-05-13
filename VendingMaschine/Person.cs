using System.Collections.Generic;
using VendingMachine;

namespace VendingMaschine
{
    class Person
    {

        public double person { get; set; }
        public string Name { get; set; }

        List<Produkt> cart = new List<Produkt>();

        public void Perches(Produkt item)
        {
            cart.Add(item);
        }
    }
}
