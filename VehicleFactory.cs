using CSharpOOPCase.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPCase
{
    internal class VehicleFactory : IvehicleFactory
    {
        
        public SUV CreateSUV(VehicleStruct vehicleStruct)
        {
            return new SUV(
                vehicleStruct.NoReg,
                vehicleStruct.VehicleType,
                vehicleStruct.TransactionDate,
                vehicleStruct.Rent,
                vehicleStruct.DriverFee,
                vehicleStruct.Total
                );
        }

        public Taxi CreateTaxi(VehicleRecord vehicleRecord)
        {
            return new Taxi(
                vehicleRecord.NoReg,
                vehicleRecord.VehicleType,
                vehicleRecord.TransactionDate, 
                vehicleRecord.Order,
                vehicleRecord.OrderPerKm
                );
        }

        public void DisplayVehicle<T>(List<T> vehicles)
        {
            foreach (var item in vehicles)
            {
                Console.WriteLine(item);
            }
        }

        public int GetTotalVehicle<T>(List<T> vehicles)
        {
            return vehicles.Count;
        }

        public int GetTotalVehicle<T>(List<T> vehicles, VehicleType vehicleType)
        {
            int total = 0;
            switch (vehicleType)
            {
                case VehicleType.All:
                    total = vehicles.Count;
                    break;
                case VehicleType.SUV:
                    total = vehicles.OfType<VehicleBase>().Where(x => x.VehicleType == VehicleType.SUV).Count();
                    break;
                case VehicleType.Taxi:
                    total = vehicles.OfType<VehicleBase>().Where(x => x.VehicleType == VehicleType.Taxi).Count();
                    break;
                case VehicleType.Jet:
                    total = vehicles.OfType<VehicleBase>().Where(x => x.VehicleType == VehicleType.Jet).Count();
                    break;
                default:
                    break;
            }
            return total;
        }
    }
}
