﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Identity.NetCore.Controllers
{
    [Authorize(Roles ="Admin,Developer")]
    public class DeveloperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}