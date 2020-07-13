using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace TimeTracker.Data.Entities
{
    public class Location
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Required]
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
