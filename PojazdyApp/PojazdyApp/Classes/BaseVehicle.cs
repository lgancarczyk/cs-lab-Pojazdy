using PojazdyApp.Enums;
using PojazdyApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PojazdyApp.Classes
{
    public abstract class BaseVehicle
    {

        public double CurrentSpeed { get; set; }
        //public List<Environments> PossibleEnvironments { get; set; }
        public Environments CurrentEnvironment { get; set; }
        public List<Environments> PossibleEnvironments { get; set; }
        public States State { get; set; }
        public double CurrentMaxSpeed => GetCurrentMaxSpeed();
        public double CurrentMinSpeed => GetCurrentMinSpeed();
        public SpeedUnits CurrentSpeedUnits => GetCurrentSpeedUnit();


        public BaseVehicle()
        {
            State = States.off;
        }


        public void TurnOff()
        {
            if (State == States.on)
            {
                if (CurrentEnvironment!= Environments.air)
                {
                    State = States.off;
                    CurrentSpeed = 0;
                    Console.WriteLine("Vehicle Turned Off (stopped)");
                }
                else
                {
                    Console.WriteLine("Can`t stop Vehicle in air!");
                }
            }
        }
        public void TurnOn() 
        {
            if (State == States.off)
            {
                State = States.on;
                CurrentSpeed = CurrentMinSpeed;
                Console.WriteLine("Vehicle Turned On (runs)");
            }
        }

        public double GetCurrentMaxSpeed()
        {
            switch (CurrentEnvironment)
            {
                case Environments.land:
                    return new LandVehicle().MaxSpeed;
                    //return _landVehicle.GetMaxSpeed();
                case Environments.water:
                    return new WaterVehicle().MaxSpeed;
                case Environments.air:
                    return new AirVehicle().MaxSpeed;
                default:
                    throw new Exception();
            }
        }

        public double GetCurrentMinSpeed()
        {
            switch (CurrentEnvironment)
            {
                case Environments.land:
                    return new LandVehicle().MinSpeed;
                case Environments.water:
                    return new WaterVehicle().MinSpeed;
                case Environments.air:
                    return new AirVehicle().MinSpeed;
                default:
                    throw new Exception();
            }
        }

        public SpeedUnits GetCurrentSpeedUnit() 
        {
            switch (CurrentEnvironment)
            {
                case Environments.land:
                    return SpeedUnits.KMpH;
                case Environments.water:
                    return SpeedUnits.Knots;
                case Environments.air:
                    return SpeedUnits.MpS;
                default:
                    throw new Exception();
            }
        }
        public void SetSpeed(double speed) 
        {
            if (State == States.on)
            {
                if (speed >= GetCurrentMinSpeed() && speed <= GetCurrentMaxSpeed())
                {
                    CurrentSpeed = speed;
                    Console.WriteLine($"Current Speed set to {speed} {GetCurrentSpeedUnit()}");
                }
                else
                {
                    Console.WriteLine($"Speed can`t be set over limits. Range: {CurrentMinSpeed} - {CurrentMaxSpeed}");
                }
            }
            else
            {
                Console.WriteLine("Vehicle is stopped! (Turn it on)");
            }
            
        }

        
    }
}
