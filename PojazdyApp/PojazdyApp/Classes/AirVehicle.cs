using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdyApp.Classes
{
    internal class AirVehicle 
    {
        public readonly double MaxSpeed = 200;
        public readonly double MinSpeed = 20;
        public readonly Environments environment = Environments.air;
    }
}
