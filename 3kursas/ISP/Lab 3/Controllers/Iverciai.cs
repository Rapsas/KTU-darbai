using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Iverciai : Controller
    {
        const int tabID = 1;

        private void GenericViewBag()
        {
            int permissionLevel = PermissionControl.GetPermissionLevel();

            this.ViewBag.ActiveTab = tabID;

            this.ViewBag.Admin = permissionLevel == PermissionControl.Admin;
            this.ViewBag.Teacher = (permissionLevel == PermissionControl.Teacher || permissionLevel == PermissionControl.Admin);
            this.ViewBag.Student = (permissionLevel == PermissionControl.Student || permissionLevel == PermissionControl.Teacher || permissionLevel == PermissionControl.Admin);
        }

        public IActionResult Index()
        {
            GenericViewBag();
            return View("Marks");
        }

        public IActionResult Marks()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Attendance()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Requirements()
        {
            GenericViewBag();
            return View();
        }
    }
}
