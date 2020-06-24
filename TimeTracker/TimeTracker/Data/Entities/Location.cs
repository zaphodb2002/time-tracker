using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Data.Entities
{
    public class Location
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public List<TimeEntry> TimeEntries { get; set; }

    }
}
