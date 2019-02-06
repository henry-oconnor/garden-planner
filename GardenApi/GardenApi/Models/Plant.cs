using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GardenApi.Models
{
    public class Plant
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public string Genus { get; set; }
        public string Species { get; set; }
        // Minimum space plant needs to grow
        public int MinSpaceInches { get; set; }
        // Decimal value used in calculating expected yield in lbs
        public float YieldFactor { get; set; }

    }
}
