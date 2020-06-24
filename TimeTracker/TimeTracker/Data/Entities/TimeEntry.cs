using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Data.Entities
{
    public class TimeEntry
    {
        public uint Id { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public Location Location { get; set; }
        public uint LocationId { get; set; }
    }
}
