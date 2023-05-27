using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main() 
        {
            MainMenuDelegate m_test = new MainMenuDelegate("Test main menu");
            ActionFromMenuDelegate m_MaiAction = new ActionFromMenuDelegate("Mai Action");
            SubMenuDelegate m_RonMenu = new SubMenuDelegate("Ron menu");
            ActionFromMenuDelegate m_RonFirstAction = new ActionFromMenuDelegate("RonFirstAction");
            ActionFromMenuDelegate m_RonSecondAction = new ActionFromMenuDelegate("RonSecondAction");
            ActionFromMenuDelegate m_RonThirdAction = new ActionFromMenuDelegate("RonThirdAction");

            m_RonFirstAction.ChosenNotifier += Test;

            m_test.AddNewSubMenu(m_RonMenu);
            m_test.AddNewAcetionFromMenu(m_MaiAction);
            m_RonMenu.AddNewAcetionFromMenu(m_RonFirstAction);
            m_RonMenu.AddNewAcetionFromMenu(m_RonSecondAction);
            m_RonMenu.AddNewAcetionFromMenu(m_RonThirdAction);

            m_test.Show();
        }

        public static void Test()
        {
            Console.WriteLine("This is a test :)");
        }
    }
}
