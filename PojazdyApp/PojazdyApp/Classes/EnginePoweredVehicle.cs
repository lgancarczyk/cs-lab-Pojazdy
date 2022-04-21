using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdyApp.Classes
{
    public abstract class EnginePoweredVehicle : BaseVehicle
    {
        public readonly Engine _engine;

        public EnginePoweredVehicle(int horsePower, FuelTypes FuelType)
        {
            //base.PossibleEnvironments.ForEach(e => (e == Environments.water ? [true]) ); 
            _engine = new Engine(horsePower, FuelType);
        }
        
    }
}
