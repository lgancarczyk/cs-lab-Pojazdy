using PojazdyApp.Classes;
using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdyApp.Vehicles
{
    public class Airplane : EnginePoweredVehicle, ILandVehicle
    {
        private readonly int noOfWheels;
        public int NoOfWheels => noOfWheels;

        public Airplane(int horsePower, FuelTypes FuelType) : base(horsePower, FuelType)
        {

        }

        
    }
}
