using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPCase.Structure
{
    internal class VehicleStruct
    {
        public string? NoReg { get; set; }
        public VehicleType? VehicleType { get; set; }
        public short? Year { get; set; }
        public double? Price { get; set; }
        public double? Tax { get; set; }
        public short? Seat { get; set; }
        public DateOnly? TransactionDate { get; set; }

        public double Rent { get; set; }
        public double DriverFee { get; set; }
        public short Order { get; set; }
        public double OrderPerKm { get; set; }
        public double Total { get; set; }

    }
}
