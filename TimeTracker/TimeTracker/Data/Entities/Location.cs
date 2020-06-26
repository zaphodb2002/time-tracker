using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TimeTracker.Data.Entities
{
    public class Location
    {
        public uint Id { get; set; }
        public string Name { get; set; }
        public List<TimeEntry> TimeEntries { get; set; }

        public Location()
        {
            TimeEntries = new List<TimeEntry>();
        }

        public TimeSpan? GetTimeEntryForToday()
        {
            if (TimeEntries.Count <= 0)
            {
                return null;
            }

            var latest = TimeEntries.Max(x => x.Arrival);
            if (latest.Date == DateTime.Now.Date)
            {
                return latest.TimeOfDay;
            }
            else
            {
                return null;
            }
            
        }

        public TimeSpan? GetAverageTime()
        {
            if (TimeEntries.Count <= 0)
            {
                return null;
            }

            var allTimes = TimeEntries.Select(x => x.Arrival.TimeOfDay).ToList().Average(x => x.TotalMinutes);
            return TimeSpan.FromMinutes(allTimes);
        }

    }
}
