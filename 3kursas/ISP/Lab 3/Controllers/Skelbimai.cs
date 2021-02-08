using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Skelbimai : Controller
    {
        const int tabID = 4;

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
            return View("Notices");
        }

        public IActionResult Messages()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Notices()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Surveys()
        {
            GenericViewBag();
            return View();
        }

        public IActionResult Activities()
        {
            GenericViewBag();
            return View();
        }
    }
}
