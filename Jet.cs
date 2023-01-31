using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPCase
{
    internal class Jet : VehicleBase
    {
        public Jet(string? noReg, VehicleType? vehicleType, DateOnly? transactionDate, double rent,double driver, double total =0) 
            : base(noReg, vehicleType, transactionDate)
        {
            Rent= rent;
            Driver= driver;
            Total = rent + driver;
        }

        public double Rent { get; set; }
        public double Driver { get; set; }

        public override string ToString()
        {
            return $"{base.ToString()}\n"+
                $"Rent          : {Rent}\n"+
                $"Driver        : {Driver}\n"
                ;
        }
    }
}
