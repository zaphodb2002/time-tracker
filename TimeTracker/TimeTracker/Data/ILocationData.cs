using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Data.Entities;

namespace TimeTracker.Data
{
    public interface ILocationData
    {
        public List<Location> GetAll();
        public Location Get(long id);
        public Location Add(Location locationToAdd);
        public Location Update(long idToUpdate, Location updatedLocation);
        public Location Delete(long idToDelete);
        public int Commit();
    }
}
