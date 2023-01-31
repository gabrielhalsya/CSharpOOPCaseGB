using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSharpOOPCase
{
    internal class Taxi : VehicleBase 
    {
        public Taxi(
            string? noReg,
            VehicleType? vehicleType,
            DateOnly? transactionDate,
            short? order,
            double? orderPerkm
            ) : 
            base(noReg, vehicleType, transactionDate)
        {
            Order = (short)order;
            OrderPerKm = (double)orderPerkm;
            Total = order * orderPerkm;

        }

        public short? Order { get; set; }
        public double? OrderPerKm { get; set; }

        public override string? ToString()
        {
            return  $"{base.ToString()}\n"+
                    $"Order          : {Order} \n"+
                    $"OrderPerKm     : {OrderPerKm} \n";

        }
    }
}
