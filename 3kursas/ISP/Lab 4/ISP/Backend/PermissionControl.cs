using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ISP.Backend
{
    /// <summary>
    /// Don't even bother
    /// </summary>
    public class PermissionControl
    {
        public const int Admin = 3;
        public const int Teacher = 2;
        public const int Student = 1;
        public const int None = 0;

        static int CurrentLevel = None;

        public static int GetPermissionLevel()
        {
            return CurrentLevel;
        }

        public static void SetPermissionLevel(int level)
        {
            CurrentLevel = level;
        }

        public static string GetPermissionLevelString()
        {
            switch (CurrentLevel)
            {
                case Admin:
                    return "Administratorius";
                case Teacher:
                    return "Dėstytojas";
                case Student:
                    return "Studentas";
                case None:
                    return "Neprisijungęs";
            }

            return "";
        }
    }
}
