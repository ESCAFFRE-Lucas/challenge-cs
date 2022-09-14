using System;

namespace CSharpDiscovery.Quest03
{
    public class PointOfInterest
    {
        public double Latitude { get; set; } = 0;
        public double Longitude { get; set; } = 0;
        public string Name { get; set; } = "";

        public static string GoogleMapsUrlTemplate = "https://www.google.com/maps/place/{0}/@{1},{2},15z/";

        public PointOfInterest()
        {
            Latitude = 44.854186;
            Longitude = -0.5663056;
            Name = "Bordeaux Ynov Campus";
        }

        public PointOfInterest(string name, double latitude, double longitude)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
        }

        public string GetGoogleMapsUrl()
        {
            return ($"https://www.google.com/maps/place/{Name.Replace(" ","+")}/@{Latitude},{Longitude},15z/");
        }

        public string ToString()
        {
            return ($"{Name} (Lat={Latitude}, Long={Longitude})");
        }
    }
}

