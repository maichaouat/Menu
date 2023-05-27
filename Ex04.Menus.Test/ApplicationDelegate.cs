using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public static class ApplicationDelegate
    {
        public static void ShowTime_Chosen()
        {
            ApplicationMethods.ShowTime();
        }
        public static void ShowDate_Chosen()
        {
            ApplicationMethods.ShowDate();
        }
        public static void ShowVersion_Chosen()
        {
            ApplicationMethods.ShowVersion();
        }
        public static void CountSpaces_Chosen()
        {
            ApplicationMethods.CountSpaces();
        }
    }
}
