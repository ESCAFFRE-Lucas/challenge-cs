using System;

namespace CSharpDiscovery.Quest04
{
    interface IThermalCar
    {
        public int FuelLevel { get; set; }
        public void FillUp();
        public int GetFuelLevel();
    }

    interface IElectricCar
    {
        public int BatteryLevel { get; set; }
        public void Recharge();
        public int GetBatteryLevel();
    }
}