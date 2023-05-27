using System;

namespace Ex04.Menus.Delegates
{
    public class MainMenuDelegate : SubMenuDelegate
    {
        public MainMenuDelegate(string i_Title) : base(i_Title)
        {
            base.MenuItems.Add(null); // In the main menu index 0 is null
        }

        public void Show()
        {
            Activate();
        }
        internal override void Activate()
        {
            int v_UserChoice;

            PrintSubMenuPart1();
            v_UserChoice = GetUserChoice();
            if (v_UserChoice != 0) 
            {
                base.MenuItems[v_UserChoice].Activate();
            }
            else
            {
                Console.WriteLine("Exiting Menu\n");
            }
        }
        protected override void PrintSubMenuPart2()
        {
            Console.WriteLine("0 -> Exit");
            Console.WriteLine(string.Format("Enter your request: (1 to {0} or press '0' to Exit)", base.MenuItems.Count - 1));
        }
    }
}
