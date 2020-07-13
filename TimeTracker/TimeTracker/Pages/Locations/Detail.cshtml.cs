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
        [BindProperty]
        public Location Location { get; set; }
        public ILocationData LocationData { get; }

        public DetailModel(ILocationData locationData)
        {
            this.LocationData = locationData;
        }

        public IActionResult OnGet(long locationId)
        {
            if (locationId != 0)
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
            else
            {
                Location = new Location();
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return new BadRequestObjectResult(ModelState);
            }

            if (Location.Id == 0)
            {
                LocationData.Add(Location);
            }
            else
            {
                LocationData.Update(Location.Id, Location);
            }

            LocationData.Commit();
            return RedirectToPage("./Detail", new { locationId = Location.Id});
        }
    }
}