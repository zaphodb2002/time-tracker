﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TimeTracker.Data;
using TimeTracker.Data.Entities;

namespace TimeTracker.Pages
{
    public class RouteModel : PageModel
    {
        private readonly ILocationData locationData;

        public List<Location> Locations { get; set; }

        public RouteModel(ILocationData locationData)
        {
            this.locationData = locationData;
        }
        public void OnGet()
        {
            Locations = locationData.GetAll();
        }
    }
}