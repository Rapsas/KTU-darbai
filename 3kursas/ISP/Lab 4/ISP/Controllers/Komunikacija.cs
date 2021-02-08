using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Komunikacija : Controller
    {
        const int tabID = 3;

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
            return View("Mail");
        }

        public IActionResult Mail()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Chats()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Contacts()
        {
            GenericViewBag();
            return View();
        }
    }
}
