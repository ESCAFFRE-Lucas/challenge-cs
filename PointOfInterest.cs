using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; } = 0;
        public double Longitude { get; } = 0;
        public string Name { get; } = "";
        public static string GoogleMapsUrlTemplate { get; }= "https://www.google.com/maps/place/{0}/@{1},{2},15z/";
    }
}

