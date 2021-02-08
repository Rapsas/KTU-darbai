using ISP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Backend
{
    public class UserControl
    {
        private static Database db = new Database();

        public static User CurrentUser { get; set; } = null;

        public static User FromID(string id)
        {
            List<User> users = db.Get<User>($"SELECT asmens_kodas, vardas, pavarde, slaptazodis, vartotojo_tipas FROM vartotojas WHERE asmens_kodas = {id}");

            if (users.Count > 0)
            {
                return users[0];
            } else
            {
                return null;
            }
        }

        public static bool Login(string user, string password)
        {
            CurrentUser = null;
            List<User> users = db.Get<User>("SELECT asmens_kodas, vardas, pavarde, slaptazodis, vartotojo_tipas FROM vartotojas");

            foreach(User u in users) {
                if (u.PersonalCode == user)
                {
                    if (u.Password == password)
                    {
                        CurrentUser = u;
                        break;
                    } else
                    {
                        return false;
                    }
                }
            }

            if (CurrentUser == null)
            {
                return false;
            }

            switch(CurrentUser.Type)
            {
                case 1:
                    PermissionControl.SetPermissionLevel(PermissionControl.Admin);
                    break;
                case 2:
                    PermissionControl.SetPermissionLevel(PermissionControl.Teacher);
                    break;
                case 3:
                    PermissionControl.SetPermissionLevel(PermissionControl.Student);
                    break;
            }

            return true;
        }

        public static void Logout()
        {
            CurrentUser = null;
            PermissionControl.SetPermissionLevel(PermissionControl.None);
        }
    }
}
