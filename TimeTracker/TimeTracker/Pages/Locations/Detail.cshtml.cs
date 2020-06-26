using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeTracker.Data;
using TimeTracker.Data.Entities;

namespace TimeTracker.Pages
{
    public class DetailModel : PageModel
    {
        public Location Location { get; set; }
        public ILocationData LocationData { get; }

        public DetailModel(ILocationData locationData)
        {
            this.LocationData = locationData;
        }

        public IActionResult OnGet(uint locationId)
        {
            Location = LocationData.Get(locationId);
            if (Location == null)
            {
                return BadRequest("No Such Location Found");
            }
            else
            {
                return Page();
            }
        }
    }
}