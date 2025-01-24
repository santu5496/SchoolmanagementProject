using DatabaseOperations.Implimentations;
using DatabaseOperations.Interface;
using DatabaseOperations.Models;
using Microsoft.AspNetCore.Mvc;

namespace SchoolmanagementProject.Controllers
{
    public class ConfigurationController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly ILevelService _ilevelservice;

        public ConfigurationController(ILogger<HomeController> logger, ILevelService _ilevelservice1)
        {
            _logger = logger;
            _ilevelservice = _ilevelservice1;
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
            if (levels == null)
            {
                return BadRequest("Level data cannot be null.");
            }

            if (_ilevelservice == null)
            {
                _logger.LogError("ILevelService is not initialized.");
                return StatusCode(500, "Internal server error.");
            }

            try
            {
                _ilevelservice.AddDataLevel(levels);
                return View();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error adding level data.");
                return StatusCode(500, "An error occurred while adding level data.");
            }
        }

    }
}
