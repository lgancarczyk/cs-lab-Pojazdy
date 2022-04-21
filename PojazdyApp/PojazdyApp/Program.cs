using PojazdyApp.Classes;
using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using PojazdyApp.Vehicles;
using System;

namespace PojazdyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Car
                Car ford = new Car(130, FuelTypes.oil, 6);
                ford.TurnOn();
                ford.TurnOff();
                ford.TurnOn();
                Console.WriteLine(ford.GetCurrentMaxSpeed());
                Console.WriteLine(ford._engine.FuelType);
                ford.SetSpeed(200);
                ford.SetSpeed(400);
                Console.WriteLine(ford.CurrentSpeed);
                Car fiat = new Car();
                Console.WriteLine(fiat._engine.FuelType);
            #endregion

        }
    }
}
