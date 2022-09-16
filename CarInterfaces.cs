using System;

namespace CSharpDiscovery.Quest04
{
    interface IThermalCar
    {
        public int FuelLevel { get; set; } = 0;
        void FillUp();
        int GetFuelLevel();
    }

    interface IElectricCar
    {
        public int BatteryLevel { get; set; } = 0;
        void Recharge();
        int GetBatteryLevel();
    }
}