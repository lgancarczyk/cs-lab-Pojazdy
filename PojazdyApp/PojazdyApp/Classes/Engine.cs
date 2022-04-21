using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdyApp.Classes
{
    public class Engine
    {
        public readonly int HorsePower;
        public readonly FuelTypes FuelType;



        public Engine(int horsePower, FuelTypes fuelType)
        {
            HorsePower = horsePower;
            FuelType = fuelType;
        }

        
    }
}
