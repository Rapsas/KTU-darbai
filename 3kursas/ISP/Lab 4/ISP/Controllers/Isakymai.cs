using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Isakymai : Controller
    {
        const int tabID = 5;

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
            return View("Orders");
        }

        public IActionResult Orders()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Contracts()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Payments()
        {
            GenericViewBag();
            return View();
        }
    }
}
