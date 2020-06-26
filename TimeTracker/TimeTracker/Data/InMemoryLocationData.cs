using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Data.Entities;

namespace TimeTracker.Data
{
    public class InMemoryLocationData : ILocationData
    {
        private List<Location> locations;

        public InMemoryLocationData()
        {
            locations = new List<Location>()
            {
                new Location {Id = 0, Name = "Begin Tour"},
                new Location {Id = 1, Name = "Location 1"},
                new Location {Id = 2, Name = "Location 2"},
                new Location {Id = 3, Name = "Location 3"},
                new Location {Id = 4, Name = "Location 4"},
                new Location {Id = 5, Name = "Location 5"},
                new Location {Id = 6, Name = "Location 6"},
                new Location {Id = 7, Name = "Location 7"}
            };

            
        }
        public Location Add(Location locationToAdd)
        {
            locationToAdd.Id = locations.Max(x => x.Id);  // Increment the ID
            locations.Add(locationToAdd);
            return locationToAdd;
        }

        public int Commit()
        {
            return 0;
        }

        public uint Delete(Location LocationToDelete)
        {
            throw new NotImplementedException();
        }

        public Location Get(uint id)
        {
            return locations.FirstOrDefault(x => x.Id == id);
        }

        public List<Location> GetAll()
        {
            return locations;
        }

        public Location Update(uint idToUpdate, Location updatedLocation)
        {
            var locationToUpdate = Get(idToUpdate);
            if (locationToUpdate != null)
            {
                locationToUpdate.Name = updatedLocation.Name;
                locationToUpdate.TimeEntries = updatedLocation.TimeEntries;
            }

            return locationToUpdate;
        }
    }
}
