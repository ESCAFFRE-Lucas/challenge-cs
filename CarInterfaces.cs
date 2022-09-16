using System;

namespace CSharpDiscovery.Quest04
{
    interface IThermalCar
    {
        public int FuelLevel;
        public void FillUp();
        public int GetFuelLevel();
    }

    interface IElectricCar
    {
        public int BatteryLevel;
        public void Recharge();
        public int GetBatteryLevel();
    }
}