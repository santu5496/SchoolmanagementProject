﻿using Microsoft.AspNetCore.Mvc;

namespace SchoolmanagementProject.Controllers
{
    public class BranchController : Controller
    {
       
        public IActionResult branch()
        {
            return View();
        }
    }
}
