using CSharpOOPCase.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOOPCase
{
    internal interface IvehicleFactory
    {
        public SUV CreateSUV(VehicleStruct vehicleStruct);
        public Taxi CreateTaxi(VehicleRecord vehicleRecord);

        //T usue for generic type (can store list for VehicleBase,SUV,Taxi & JEt

        public void DisplayVehicle<T>(List<T> vehicles);
        public int GetTotalVehicle<T>(List<T> vehicles);
        public int GetTotalVehicle<T>(List<T> vehicles,VehicleType vehicleType);
    }
}
