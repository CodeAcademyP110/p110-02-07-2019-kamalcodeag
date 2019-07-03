using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class GroupController : Controller
    {
        public IActionResult Info(int id)
        {
            if(id == 0)
            {
                return NotFound();
            }

            GroupItem selectedGroup = Group.GetAllGroups().Where(g => g.Id == id).FirstOrDefault();


            return View(selectedGroup);

            //byMe
        }
    }
}