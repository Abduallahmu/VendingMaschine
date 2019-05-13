using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            pro();
        }
        static void pro()
        {

            List<Produkt> produkts = new List<Produkt>();

            produkts.Add(new Juice("Mountain Dew", 10, 0.33));
            produkts.Add(new Juice("Coca Cola", 10, 2));
            produkts.Add(new Juice("Red Bull", 20, 25));
            produkts.Add(new Juice("Merinda", 10, 0.33));
            produkts.Add(new Juice("Sprite", 10, 2));
            produkts.Add(new Juice("Looka", 10, 2));
            produkts.Add(new Juice("Fanta", 10, 0.33));
            produkts.Add(new Juice("Bravo", 25, 2));
            produkts.Add(new Juice("Pepsi", 10, 0.33));
            produkts.Add(new Juice("7Up", 10, 1.5));

            produkts.Add(new Snack("Snickers", 5, "Bar"));
            produkts.Add(new Snack("Skittles", 7, "Kollor"));
            produkts.Add(new Snack("MilkyWay", 5, "Bar"));
            produkts.Add(new Snack("Bounty", 5, "Bar"));
            produkts.Add(new Snack("Extra", 14, "tuggummi"));
            produkts.Add(new Snack("Orbit", 14, "tuggummi"));
            produkts.Add(new Snack("Oreo", 10, "Kex"));
            produkts.Add(new Snack("Twix", 5, "Bar"));
            produkts.Add(new Snack("Mars", 5, "Bar"));
            produkts.Add(new Snack("Kex", 5, "Bar"));

            produkts.Add(new Frukt("Granatäpple", 20, "ja"));
            produkts.Add(new Frukt("Apelsin", 10, "Ja"));
            produkts.Add(new Frukt("Kvitten", 10, "Nej"));
            produkts.Add(new Frukt("Citron", 10, "Ja"));
            produkts.Add(new Frukt("Ananas", 20, "ja"));
            produkts.Add(new Frukt("Äpple", 10, "Ibland"));
            produkts.Add(new Frukt("Mango", 15, "Nej"));
            produkts.Add(new Frukt("Päron", 10, "Nej"));
            produkts.Add(new Frukt("Banan", 10, "Nej"));
            produkts.Add(new Frukt("Kiwai", 10, "Ja"));

            VendingMachine vending = new VendingMachine(produkts);

            vending.StartMachine();
        }

    }
}