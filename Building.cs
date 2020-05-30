using System;

namespace Planner
{

    public class Building
    {
        private string _designer ="Shady";
        private DateTime _dateConstructed;
        private string _address;
        private string _owner;
        public int Stories { get; set; } 
        public double Width { get; set; }
        public double Depth { get; set; }
        public double Volume
        {
            get
            {
                return Width * Depth * (3 * Stories);
            }
        }

        public Building(string address)
        {
            address = _address;

        }

        public void Construct()
        {
            _dateConstructed = DateTime.Now;
        }

        public void Purchase(string buyerName)
        {
            buyerName = _owner;
        }

        public void getDetails()
        {
            Console.WriteLine($"");
        }

    }
}