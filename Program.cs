using CSharpOOPCase;
using CSharpOOPCase.Structure;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IvehicleFactory ivehicleFactory = new VehicleFactory(); //callin interface and classimplements

            var suvHolder1 = new VehicleStruct  //define Suv with struct
            {
              NoReg="BA 2131 M",
              VehicleType=VehicleType.SUV,
              TransactionDate=new DateOnly(2023,1,10),
              DriverFee=140_00,
              Rent=400_00
            };

            var suvHolder2 = new VehicleStruct
            {
                NoReg = "BA 2132 M",
                VehicleType = VehicleType.SUV,
                TransactionDate = new DateOnly(2023, 1, 10),
                DriverFee = 140_00,
                Rent = 400_00
            };

            var taxiHolder1 = new VehicleRecord     //define Taxi with record
            {
                NoReg = "D 11 UK",
                VehicleType = VehicleType.Taxi,
                TransactionDate = new DateOnly(2023, 1, 12),
                Order = 45,
                OrderPerKm = 4_500
            };

            //creating defined vehicle and store into var
            var suv1 = ivehicleFactory.CreateSUV(suvHolder1);
            var suv2 = ivehicleFactory.CreateSUV(suvHolder2);
            var taxi1 = ivehicleFactory.CreateTaxi(taxiHolder1);

            //make list of vehicle
            List<VehicleBase> list = new List<VehicleBase>();
            list.Add(suv1);
            list.Add(suv2);
            list.Add(taxi1);

            ivehicleFactory.DisplayVehicle(list); //displaying list using interface

        }
    }
}