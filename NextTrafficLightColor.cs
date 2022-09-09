using CSharpDiscovery.Models;

namespace CSharpDiscovery.Quest01
{
    public class NextTrafficLightColor_Exercice
    {
        public static TrafficLightColor GetNextTrafficLightColor(TrafficLightColor currentColor)
        {
            return currentColor == TrafficLightColor.None ? TrafficLightColor.None :
                currentColor == TrafficLightColor.Green ? TrafficLightColor.Orange :
                currentColor == TrafficLightColor.Orange ? TrafficLightColor.Red : TrafficLightColor.Green;
        }
    }
}