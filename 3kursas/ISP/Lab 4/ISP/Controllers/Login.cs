using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using ISP.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Login : Controller
    {
        [HttpPost]
        public StatusCodeResult LoginAction([FromBody] User user)
        {
            if (UserControl.Login(user.PersonalCode.Trim('"'), user.Password.Trim('"')))
            {
                return StatusCode(200);
            } else
            {
                return StatusCode(401);
            }
        }

        [HttpPost]
        public IActionResult Logout()
        {
            UserControl.Logout();
            return RedirectToAction("Index", "Home");
        }
    }
}
