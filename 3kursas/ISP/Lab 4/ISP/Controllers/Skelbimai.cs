using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ISP.Backend;
using ISP.Models;
using Microsoft.AspNetCore.Mvc;

namespace ISP.Controllers
{
    public class Skelbimai : Controller
    {
        Database db = new Database();

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
            // Automatically redirect
            return Redirect(Url.Action("Notices"));
        }

        public IActionResult Messages()
        {
            GenericViewBag();
            return View(GetMessages());
        }

        public IActionResult Notices()
        {
            GenericViewBag();
            return View(GetNotices());
        }

        public IActionResult Surveys()
        {
            GenericViewBag();
            return View(GetSurveys());
        }

        public IActionResult Activities()
        {
            GenericViewBag();
            return View(Tuple.Create(GetMentors(), GetActivities()));
        }

        /*
         * NOTICES
         */
        
        [HttpPost]
        public StatusCodeResult NewNotice([FromBody] Notice notice)
        {
            try
            {
                notice.CreatorID = UserControl.CurrentUser.PersonalCode;
                notice.Date = DateTime.Now.ToString();
                db.Insert<Notice>("INSERT INTO irasas (data, pavadinimas, fk_Vartotojas) VALUES (@Date, @Name, @CreatorID); INSERT INTO pranesimas (turinys, fk_Irasas) VALUES (@Content, LAST_INSERT_ID())", notice);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult EditNotice([FromBody] Notice notice)
        {
            try
            {
                db.Edit<Notice>("UPDATE pranesimas SET turinys = @Content WHERE fk_Irasas = @ID; UPDATE irasas SET data = @Date, pavadinimas = @Name WHERE id = @ID", notice);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult DeleteNotice([FromBody] Notice notice)
        {
            try
            {
                db.Delete<Notice>("DELETE FROM pranesimas WHERE fk_Irasas = @ID; DELETE FROM irasas WHERE id = @ID", notice);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        public List<Notice> GetNotices()
        {
            return db.Get<Notice>("SELECT p.turinys, i.pavadinimas, p.fk_Irasas, i.data, i.fk_Vartotojas FROM pranesimas p LEFT JOIN irasas i ON p.fk_Irasas = i.id", null);
        }

        /*
         * MESSAGES
         */

        [HttpPost]
        public StatusCodeResult NewMessage([FromBody] Message message)
        {
            try
            {
                message.CreatorID = UserControl.CurrentUser.PersonalCode;
                message.Date = DateTime.Now.ToString();
                db.Insert<Message>("INSERT INTO irasas (data, pavadinimas, fk_Vartotojas) VALUES (@Date, @Name, @CreatorID); INSERT INTO skelbimas (turinys, fk_Irasas) VALUES (@Content, LAST_INSERT_ID())", message);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult EditMessage([FromBody] Message message)
        {
            try
            {
                db.Edit<Message>("UPDATE skelbimas SET turinys = @Content WHERE fk_Irasas = @ID; UPDATE irasas SET data = @Date, pavadinimas = @Name WHERE id = @ID", message);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult DeleteMessage([FromBody] Message message)
        {
            try
            {
                db.Delete<Message>("DELETE FROM skelbimas WHERE fk_Irasas = @ID; DELETE FROM irasas WHERE id = @ID", message);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        public List<Message> GetMessages()
        {
            return db.Get<Message>("SELECT s.turinys, i.pavadinimas, s.fk_Irasas, i.data, i.fk_Vartotojas, v.vardas, v.pavarde FROM skelbimas s LEFT JOIN irasas i ON s.fk_Irasas = i.id LEFT JOIN vartotojas v ON i.fk_Vartotojas = v.asmens_kodas", null);
        }

        /*
         * SURVEYS
         */

        [HttpPost]
        public StatusCodeResult NewSurvey([FromBody] Survey survey)
        {
            try
            {
                survey.CreatorID = UserControl.CurrentUser.PersonalCode;
                survey.Date = DateTime.Now.ToString();
                db.Insert<Survey>("INSERT INTO irasas (data, pavadinimas, fk_Vartotojas) VALUES (@Date, @Name, @CreatorID); INSERT INTO apklausa (nuoroda, fk_Irasas) VALUES (@Link, LAST_INSERT_ID())", survey);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult EditSurvey([FromBody] Survey survey)
        {
            try
            {
                db.Edit<Survey>("UPDATE apklausa SET nuoroda = @Link WHERE fk_Irasas = @ID; UPDATE irasas SET data = @Date, pavadinimas = @Name WHERE id = @ID", survey);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult DeleteSurvey([FromBody] Survey survey)
        {
            try
            {
                db.Delete<Survey>("DELETE FROM apklausa WHERE fk_Irasas = @ID; DELETE FROM irasas WHERE id = @ID", survey);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        public List<Survey> GetSurveys()
        {
            string user = UserControl.CurrentUser.PersonalCode;
            return db.Get<Survey>($"SELECT a.nuoroda, i.pavadinimas, a.fk_Irasas, i.data, i.fk_Vartotojas, v.vardas, v.pavarde, (v.asmens_kodas = '{user}') as kurejas FROM apklausa a LEFT JOIN irasas i ON a.fk_Irasas = i.id LEFT JOIN vartotojas v ON i.fk_Vartotojas = v.asmens_kodas", null);
        }

        /*
         * ACTIVITIES
         */

        [HttpPost]
        public StatusCodeResult NewMentor([FromBody] Mentor mentor)
        {
            try
            {
                mentor.CreatorID = UserControl.CurrentUser.PersonalCode;
                db.Insert<Mentor>("INSERT INTO konsultacija (tema, dalykas, laikas, vieta, fk_Vartotojas) VALUES (@Subject, @Name, @Date, @Location, @CreatorID)", mentor);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult EditMentor([FromBody] Mentor mentor)
        {
            try
            {
                db.Edit<Mentor>("UPDATE konsultacija SET tema = @Subject, dalykas = @Name, laikas = @Date, vieta = @Location WHERE id = @ID", mentor);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult DeleteMentor([FromBody] Mentor mentor)
        {
            try
            {
                string user = UserControl.CurrentUser.PersonalCode;
                db.Delete<Mentor>("DELETE FROM konsultacija WHERE id = @ID", mentor);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult RegisterMentor([FromBody] Mentor mentor)
        {
            try
            {
                string user = UserControl.CurrentUser.PersonalCode;
                db.Delete<Mentor>($"INSERT INTO eina_i_konsultacija (fk_Konsultacija, fk_Vartotojas) VALUES (@ID, '{user}')", mentor);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult UnregisterMentor([FromBody] Mentor mentor)
        {
            try
            {
                string user = UserControl.CurrentUser.PersonalCode;
                db.Delete<Mentor>($"DELETE FROM eina_i_konsultacija WHERE fk_Vartotojas = '{user}' AND fk_Konsultacija = @ID;", mentor);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        public List<Mentor> GetMentors()
        {
            string user = UserControl.CurrentUser.PersonalCode;
            return db.Get<Mentor>($"SELECT k.dalykas, k.tema, k.vieta, k.laikas, k.id, k.fk_Vartotojas, " +
                $"v.vardas, v.pavarde, " +
                $"(k.fk_Vartotojas = '{user}') as kurejas, " +
                $"(SELECT COUNT(fk_Konsultacija) as kiekis FROM eina_i_konsultacija WHERE fk_Vartotojas = '{user}' AND fk_Konsultacija = k.id) as uzregistruotas " +
                $"FROM konsultacija k LEFT JOIN vartotojas v ON v.asmens_kodas = k.fk_Vartotojas", null);
        }

        [HttpPost]
        public StatusCodeResult NewActivity([FromBody] Activity activity)
        {
            try
            {
                activity.CreatorID = UserControl.CurrentUser.PersonalCode;
                db.Insert<Activity>("INSERT INTO burelis (aprasas, pavadinimas, laikas, vieta, fk_Vartotojas) VALUES (@Description, @Name, @Date, @Location, @CreatorID)", activity);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult EditActivity([FromBody] Activity activity)
        {
            try
            {
                db.Edit<Activity>("UPDATE burelis SET aprasas = @Description, pavadinimas = @Name, laikas = @Date, vieta = @Location WHERE id = @ID", activity);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult DeleteActivity([FromBody] Activity activity)
        {
            try
            {
                string user = UserControl.CurrentUser.PersonalCode;
                db.Delete<Activity>("DELETE FROM burelis WHERE id = @ID", activity);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult RegisterActivity([FromBody] Activity activity)
        {
            try
            {
                string user = UserControl.CurrentUser.PersonalCode;
                db.Delete<Activity>($"INSERT INTO eina_i_mentorius (fk_Burelis, fk_Vartotojas) VALUES (@ID, '{user}')", activity);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpPost]
        public StatusCodeResult UnregisterActivity([FromBody] Activity activity)
        {
            try
            {
                string user = UserControl.CurrentUser.PersonalCode;
                db.Delete<Activity>($"DELETE FROM eina_i_mentorius WHERE fk_Vartotojas = '{user}' AND fk_Burelis = @ID;", activity);
                return StatusCode(200);
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }

        public List<Activity> GetActivities()
        {
            string user = UserControl.CurrentUser.PersonalCode;
            return db.Get<Activity>($"SELECT b.pavadinimas, b.aprasas, b.vieta, b.laikas, b.id, b.fk_Vartotojas, " +
                $"v.vardas, v.pavarde, " +
                $"(b.fk_Vartotojas = '{user}') as kurejas, " +
                $"(SELECT COUNT(fk_Burelis) as kiekis FROM eina_i_mentorius WHERE fk_Vartotojas = '{user}' AND fk_Burelis = b.id) as uzregistruotas " +
                $"FROM burelis b LEFT JOIN vartotojas v ON v.asmens_kodas = b.fk_Vartotojas", null);
        }
    }
}
