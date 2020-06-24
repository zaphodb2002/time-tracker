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
        public Location Get(uint id);
        public Location Add(Location locationToAdd);
        public Location Update(uint idToUpdate, Location updatedLocation);
        public uint Delete(Location LocationToDelete);
    }
}
