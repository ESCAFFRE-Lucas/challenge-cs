﻿using System;

namespace CSharpDiscovery.Quest03
{
    public class HistoricalMonument : PointOfInterest
    {
        public int BuildYear { get; set; } = 0;

        public HistoricalMonument(string name, double latitude, double longitude, int buildYear)
        {
            Name = name;
            Latitude = latitude;
            Longitude = longitude;
            BuildYear = buildYear;
        }

        public override string ToString()
        {
            base.ToString();
            return $"{Name} is a historical monument built in {BuildYear}";
        }
    }
}