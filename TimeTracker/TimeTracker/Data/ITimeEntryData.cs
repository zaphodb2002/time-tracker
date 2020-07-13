using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TimeTracker.Data.Entities;

namespace TimeTracker.Data
{
    public interface ITimeEntryData
    {
        public List<TimeEntry> GetAll();
        public TimeEntry Get(long id);
        public TimeEntry Update(long idToUpdate, TimeEntry updatedTimeEntry);
        public uint Delete(TimeEntry timeEntryToDelete);
    }
}
