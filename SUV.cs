using CSharpOOPCase.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPCase
{
    internal class SUV : VehicleBase
    {

        public SUV(string? noReg, VehicleType? vehicleType, DateOnly? transactionDate, double driverFee, double rent, double total=0)
            : base(noReg, vehicleType, transactionDate)
        {
            DriverFee = driverFee;
            Rent = rent;
            Total = rent + driverFee;
        }

        public double DriverFee { get; set; }
        public double Rent { get; set; }

        public override string? ToString()
        {
            return  $"{base.ToString()}\n" +
                    $"Rent           : {Rent}\n" +
                    $"DriverFee      : {DriverFee}\n";
        }

    }
}