using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using WebApplication4.ViewModel;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            HomeVM homeVM = new HomeVM() {
                Students = Student.GetAllStudents(),
                Groups = Group.GetAllGroups(),
                Professions = Profession.GetAllProfessions()
            };
            return View(homeVM);
        }
    }
}