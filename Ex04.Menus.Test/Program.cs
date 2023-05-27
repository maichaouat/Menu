using System;
using System.Collections.Generic;
using Ex04.Menus.Delegates;
using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class Program
    {
        public static void Main() 
        {
            // Delegates version
            MainMenuDelegate v_MainMenuDelegate = new MainMenuDelegate("Delegates Main Menu");
            SubMenuDelegate v_DateAndTimeDelegate = new SubMenuDelegate("Show Date/Time");
            SubMenuDelegate v_VersionAndSpacesDelegate = new SubMenuDelegate("Version and Spaces");
            ActionFromMenuDelegate v_ShowDateDelegate = new ActionFromMenuDelegate("Show Date");
            ActionFromMenuDelegate v_ShowTimeDelegate = new ActionFromMenuDelegate("Show Time");
            ActionFromMenuDelegate v_ShowVersionDelegate = new ActionFromMenuDelegate("Show Version");
            ActionFromMenuDelegate v_CountSpacesDelegate = new ActionFromMenuDelegate("CountSpaces");
            v_ShowDateDelegate.ChosenNotifier += ApplicationDelegate.ShowDate_Chosen;
            v_ShowTimeDelegate.ChosenNotifier += ApplicationDelegate.ShowTime_Chosen;
            v_ShowVersionDelegate.ChosenNotifier += ApplicationDelegate.ShowVersion_Chosen;
            v_CountSpacesDelegate.ChosenNotifier += ApplicationDelegate.CountSpaces_Chosen;
            v_MainMenuDelegate.AddNewSubMenu(v_DateAndTimeDelegate);
            v_MainMenuDelegate.AddNewSubMenu(v_VersionAndSpacesDelegate);
            v_DateAndTimeDelegate.AddNewAcetionFromMenu(v_ShowDateDelegate);
            v_DateAndTimeDelegate.AddNewAcetionFromMenu(v_ShowTimeDelegate);
            v_VersionAndSpacesDelegate.AddNewAcetionFromMenu(v_ShowVersionDelegate);
            v_VersionAndSpacesDelegate.AddNewAcetionFromMenu(v_CountSpacesDelegate);
            v_MainMenuDelegate.Show();

            // Interface version
            ApplicationInterface.ShowDate v_ShowDateMethod = new ApplicationInterface.ShowDate();
            ApplicationInterface.ShowTime v_ShowTimeMethod = new ApplicationInterface.ShowTime();
            ApplicationInterface.ShowVersion v_ShowVersionMethod = new ApplicationInterface.ShowVersion();
            ApplicationInterface.CountSpaces v_CountSpacesMethod = new ApplicationInterface.CountSpaces();
            MainMenuInterface v_MainMenuInterface = new MainMenuInterface("Interface Main Menu");
            SubMenuInterface v_DateAndTimeInterface = new SubMenuInterface("Show Date/Time");
            SubMenuInterface v_VersionAndSpacesInterface = new SubMenuInterface("Version and Spaces");
            ActionFromMenuInterface v_ShowDateInterface = new ActionFromMenuInterface("Show Date", v_ShowDateMethod);
            ActionFromMenuInterface v_ShowTimeInterface = new ActionFromMenuInterface("Show Time", v_ShowTimeMethod);
            ActionFromMenuInterface v_ShowVersionInterface = new ActionFromMenuInterface("Show Version", v_ShowVersionMethod);
            ActionFromMenuInterface v_CountSpacesInterface = new ActionFromMenuInterface("CountSpaces", v_CountSpacesMethod);
            v_MainMenuInterface.AddNewSubMenu(v_DateAndTimeInterface);
            v_MainMenuInterface.AddNewSubMenu(v_VersionAndSpacesInterface);
            v_DateAndTimeInterface.AddNewAcetionFromMenu(v_ShowDateInterface);
            v_DateAndTimeInterface.AddNewAcetionFromMenu(v_ShowTimeInterface);
            v_VersionAndSpacesInterface.AddNewAcetionFromMenu(v_ShowVersionInterface);
            v_VersionAndSpacesInterface.AddNewAcetionFromMenu(v_CountSpacesInterface);
            v_MainMenuInterface.Show();
        }
    }
}
