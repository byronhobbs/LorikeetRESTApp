using System;
using System.Collections.Generic;

namespace LorikeetRESTApp.Database
{
    public partial class GeocodeCache
    {
        public int GeocodeCacheId { get; set; }
        public decimal Latitude { get; set; }
        public string Location { get; set; }
        public decimal Longitude { get; set; }
    }
}
