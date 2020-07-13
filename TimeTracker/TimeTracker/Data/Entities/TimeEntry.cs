using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TimeTracker.Data.Entities
{
    public class TimeEntry
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        public DateTime Arrival { get; set; }
        public DateTime Departure { get; set; }
        public Location Location { get; set; }
        public long LocationId { get; set; }
    }
}
