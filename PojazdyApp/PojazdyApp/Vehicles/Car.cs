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
    public class Car : EnginePoweredVehicle, ILandVehicle
    {
        private readonly int noOfWheels;
        public int NoOfWheels => noOfWheels;

        public Car(int horsePower = 110, FuelTypes FuelType =  FuelTypes.petrol, int NoOfWheels = 4) : base(horsePower, FuelType)
        {
            base.CurrentEnvironment = Environments.land;
            base.PossibleEnvironments = new List<Environments>();
            PossibleEnvironments.Add(Environments.land);
            noOfWheels = NoOfWheels;
        }

        
    }
}
