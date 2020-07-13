using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Data.Entities;

namespace TimeTracker.Data
{
    public class TimeTrackerDBContext : DbContext
    {
        public DbSet<Location> Locations { get; set; }
        //public DbSet<TimeEntry> TimeEntries { get; set; }

        public TimeTrackerDBContext(DbContextOptions<TimeTrackerDBContext> options) : base(options)
        {

        }
    }
}
