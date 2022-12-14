using System;

namespace CSharpDiscovery.Quest04
{
    public class Truck : Vehicule
    {
        public int Tonnage { get; set; } = 0;

        public Truck()
        {
            Tonnage = 0;
        }

        public Truck(int tonnage, string brand, string color, int currentSpeed = 0)
        {
            Tonnage = tonnage;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Tonnage}T Truck";
        }
        
        public override void Accelerate(int Speed)
        {
            if (CurrentSpeed + Speed > 100)
            {
                CurrentSpeed = 100;
            }
            else
            {
                CurrentSpeed += Speed;
            }
        }

        public override void Brake(int BrakePower)
        {
            if (CurrentSpeed - BrakePower < 0)
            {
                CurrentSpeed = 0;
            }
            else
            {
                CurrentSpeed -= BrakePower;
            }
        }
    }
}