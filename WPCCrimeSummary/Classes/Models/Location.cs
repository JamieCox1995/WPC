using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Models
{
    public class Location
    {
        public string Latitude { get; }

        public Street Street { get; }

        public string Longitude { get; }

        public Location(string latitude, Street street, string longitude)
        {
            Latitude = latitude;
            Street = street;
            Longitude = longitude;
        }
    }
}
