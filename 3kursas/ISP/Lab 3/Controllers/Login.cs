using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Login : Controller
    {
        [HttpPost]
        public IActionResult LoginAdmin()
        {
            PermissionControl.SetPermissionLevel(PermissionControl.Admin);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult LoginTeacher()
        {
            PermissionControl.SetPermissionLevel(PermissionControl.Teacher);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult LoginStudent()
        {
            PermissionControl.SetPermissionLevel(PermissionControl.Student);
            return RedirectToAction("Index", "Home");
        }

        [HttpPost]
        public IActionResult Logout()
        {
            PermissionControl.SetPermissionLevel(PermissionControl.None);
            return RedirectToAction("Index", "Home");
        }
    }
}
