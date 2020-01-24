using System;

namespace fish_project {

    class Program {
        
        // valori di default utilizzabili per i costruttori dei pesci
        private const double SalmonWeight = 26.00;
        private const double PufferFishWeight = 6.50;
        private const double CatFishWeight = 2.00;

        private const string SalmonColor = "Salmone";
        private const string PufferFishColor = "Giallo";
        private const string CatFishColor = "Marrone";
        
        private const int SalmonSpeed = 7;
        private const int PufferFishSpeed = 4;
        private const int CatFishSpeed = 5;

        private const string SalmonRiver = "Sana";
        static void Main(string[] args) {
            
            Salmon salmon = new Salmon(SalmonWeight,SalmonColor,SalmonSpeed,SalmonRiver);
            PufferFish pufferFish = new PufferFish(PufferFishWeight,PufferFishColor,PufferFishSpeed);
            CatFish catFish = new CatFish(CatFishWeight, CatFishColor, CatFishSpeed);
            Console.WriteLine();

            Console.WriteLine("");
        }
    }
}