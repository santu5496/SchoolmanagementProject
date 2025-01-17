using DatabaseOperations.Implimentations;
using DatabaseOperations.Interface;
using DatabaseOperations.Models;
using Microsoft.AspNetCore.Mvc;

namespace SchoolmanagementProject.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILevelService _schoolService;

        public ConfigurationController(ILogger<HomeController> logger, ISchoolService schoolService)
        {
            _logger = logger;
            _schoolService = schoolService;
        }


        public IActionResult Configuration()
           {
            
            return View();
        }
        //public IActionResult AddandUpdateAttendance(Attendance attendance)
        //{
        //    if (attendance == null)
        //    {
        //        return BadRequest("Attendance data cannot be null.");
        //    }

        //    // Check if attendance.Id is 0 or null (indicating it's a new entry)
        //    if (attendance.Id == 0 || attendance.Id == null)
        //    {
        //        var result = _DbConn.AddAttendance(attendance);

        //        if (result)
        //        {
        //            return Ok("Attendance added successfully.");
        //        }
        //        else
        //        {
        //            return StatusCode(500, "Error adding attendance.");
        //        }
        //    }
        //    else
        //    {
        //        var result = _DbConn.UpdateAttendance(attendance);

        //        if (result)
        //        {
        //            return Ok("Attendance updated successfully.");
        //        }
        //        else
        //        {
        //            return NotFound("Attendance record not found for update.");
        //        }
        //    }

        //}

        public IActionResult AddLevel(Levels levels)
        {
            _schoolService.AddData1(levels);

            return View();
        }
    }
}
