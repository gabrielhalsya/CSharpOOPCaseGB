using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPCase
{
    internal abstract class VehicleBase
    {
        protected VehicleBase(string? noReg, VehicleType? vehicleType, DateOnly? transactionDate)
        {
            NoReg = noReg;
            VehicleType = vehicleType;
            TransactionDate = transactionDate;
        }

        public string? NoReg { get; set; }
        public VehicleType? VehicleType { get; set; }
        public short? Year { get; set; }
        public double? Price { get; set; }
        public double? Tax { get; set; }
        public short? Seat { get; set; }
        public DateOnly? TransactionDate { get; set; }
        public double? Total { get; set; }

        public override string? ToString()
        {
            return $"NoReg          : {NoReg}\n" +
                   $"VehicleType    : {VehicleType}\n" +
                   //$"Year           : {Year}\n" +
                   //$"Price          : {Price}\n" +
                   //$"Tax            : {Tax}\n" +
                   //$"Seat           : {Seat}\n" +
                   $"TransacDate    : {TransactionDate}";
                   //$"Total          : {Total}\n";
        }
    }


}