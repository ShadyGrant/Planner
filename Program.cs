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

            churchBuilding.Width = 25.5;
            churchBuilding.Stories = 2;
            churchBuilding.Depth = 70.6;
            churchBuilding.Construct();
            churchBuilding.Purchase("John Hanna");

            FiveOneTwoEigth.getDetails();
            churchBuilding.getDetails();

        }
    }
}