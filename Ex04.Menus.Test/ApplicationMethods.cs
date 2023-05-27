using System;

namespace Ex04.Menus.Test
{
    public static class ApplicationMethods
    {
        public static void ShowTime()
        {
            DateTime currentTime = DateTime.Now;
            Console.WriteLine("Current time: " + currentTime.ToString("HH:mm:ss"));
        }
        public static void ShowDate()
        {
            DateTime currentDate = DateTime.Now.Date;
            Console.WriteLine("Current date: " + currentDate.ToString("yyyy-MM-dd"));
        }
        public static void ShowVersion()
        {
            Console.WriteLine("Version 23.2.4.9805");
        }
        public static void CountSpaces()
        {
            string v_UserInPut;
            int v_CountSpaces ;

            Console.WriteLine("Please enter your sentence:");
            v_UserInPut = Console.ReadLine();
            v_CountSpaces = v_UserInPut.Split(' ').Length - 1;
            Console.WriteLine(string.Format("There are {0} spaces in your sentence\n", v_CountSpaces));
        }
    }
}
