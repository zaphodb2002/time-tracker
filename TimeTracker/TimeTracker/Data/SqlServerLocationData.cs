using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks.Dataflow;
using TimeTracker.Data.Entities;

namespace TimeTracker.Data
{
    public class SqlServerLocationData : ILocationData
    {
        private readonly TimeTrackerDBContext db;

        public SqlServerLocationData(TimeTrackerDBContext db)
        {
            this.db = db;
        }
        public Location Add(Location locationToAdd)
        {
            db.Add(locationToAdd);
            return locationToAdd;
        }

        public int Commit()
        {
            return db.SaveChanges();
        }

        public Location Delete(long idToDelete)
        {
            var locationToDelete = Get(idToDelete);
            if (locationToDelete != null)
            {
                db.Locations.Remove(locationToDelete);
            }
            return locationToDelete;
        }

        public Location Get(long id)
        {
            return db.Locations.Find(id);
        }

        public List<Location> GetAll()
        {
            return db.Locations.ToList();
        }

        public Location Update(long idToUpdate, Location updatedLocation)
        {
            var entity = db.Locations.Attach(updatedLocation);
            entity.State = EntityState.Modified;
            return updatedLocation;
        }
    }
}
