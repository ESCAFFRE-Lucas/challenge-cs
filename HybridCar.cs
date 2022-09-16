using System;

namespace CSharpDiscovery.Quest04
{
    public class HybridCar : Car, IThermalCar, IElectricCar
    {
        public HybridCar() {}
        
        public HybridCar(string model, string brand, string color, int currentSpeed = 0):base(model,brand,color,currentSpeed){}

        public int FuelLevel
        {
            get { return 80; }
            set {}
        }
        
        public int GetFuelLevel()
        {
            return FuelLevel;
        }

        public void FillUp()
        {
            FuelLevel = 100;
        }
    
        public int BatteryLevel
        {
            get { return 60; }
            set {}
        }
        
        public int GetBatteryLevel()
        {
            return BatteryLevel;
        }
        
        public void Recharge()
        {
            BatteryLevel = 100;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Model}, Battery: {BatteryLevel}%, Fuel: {FuelLevel}%";
        }
    }
}