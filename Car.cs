using System;

namespace CSharpDiscovery.Quest04
{
    public class Car : Vehicule
    {
        public string Model { get; set; } = "";

        public Car()
        {
            Model = "Unknown";
            Brand = "Unknown";
        }

        public Car(string model, string brand, string color, int currentSpeed = 0)
        {
            Model = model;
            Brand = brand;
            Color = color;
            CurrentSpeed = currentSpeed;
        }

        public override string ToString()
        {
            return $"{Color} {Brand} {Model}";
        }

        public override void Accelerate(int Speed)
        {
            if (CurrentSpeed + Speed > 180)
            {
                CurrentSpeed = 180;
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