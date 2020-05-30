using System;

namespace Planner
{
    class Program
    {
        static void Main(string[] args)
        {
            Building FiveOneTwoEigth = new Building("512 8th Avenue");
            Building churchBuilding = new Building("204 Mt View St");

            FiveOneTwoEigth.Width = 20.5;
            FiveOneTwoEigth.Stories = 10;
            FiveOneTwoEigth.Depth = 100.50;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("Shady Grant");

            FiveOneTwoEigth.Width = 25.5;
            FiveOneTwoEigth.Stories = 2;
            FiveOneTwoEigth.Depth = 70.6;
            FiveOneTwoEigth.Construct();
            FiveOneTwoEigth.Purchase("John Hanna");

        }
    }
}