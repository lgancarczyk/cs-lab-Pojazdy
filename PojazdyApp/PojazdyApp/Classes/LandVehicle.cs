using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdyApp.Classes
{
    public class LandVehicle
    {
        public readonly double MaxSpeed = 350;
        public readonly double MinSpeed = 1;
        public readonly Environments environment = Environments.land;
    }
}
