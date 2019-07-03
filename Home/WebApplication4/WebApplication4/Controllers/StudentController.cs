using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Info(int id)
        {
            if (id == 0)
            {
                return NotFound();
            }

            //List<StudentItem> studentItems = Student.GetAllStudents();

            //var student = studentItems.Where(x => x.Id == id).FirstOrDefault();

            var student = Student.GetAllStudents().Where(x => x.Id == id).FirstOrDefault();


            if (student == null)
            {
                return NotFound();
            }
            ViewBag.GroupName = Group.GetAllGroups().Where(x => x.Id == student.GroupId).FirstOrDefault().Name;
            return View(student);
        }
    }
}