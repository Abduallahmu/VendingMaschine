
namespace VendingMachine
{
    class Pengar
    {

        public int FemHundra { get; }
        public int TvåHundra { get; }
        public int EttHundra { get; }
        public int Femtio { get; }
        public int Tjogo { get; }
        public int Tio { get; }
        public int Fem { get; }
        public int Två { get; }
        public int Ett { get; }

        public Pengar(double price)
        {

            FemHundra = (int)(price / 500);
            price %= 500;

            TvåHundra = (int)(price / 200);
            price %= 200;

            EttHundra = (int)(price / 100);
            price %= 100;

            Femtio = (int)(price / 50);
            price %= 50;

            Tjogo = (int)(price / 20);
            price %= 20;

            Tio = (int)(price / 10);
            price %= 10;

            Fem = (int)(price / 5);
            price %= 5;

            Ett = (int)(price / 1);
            price %= 1;



        }
    }

}
