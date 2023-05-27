using System;
using System.Collections.Generic;

namespace Ex04.Menus.Delegates
{
    public class SubMenuDelegate : MenuItemDelegate
    {
        private List<MenuItemDelegate> m_MenuItems;

        public List<MenuItemDelegate> MenuItems
        {
            get
            {
                return m_MenuItems;
            }
            set
            {
                m_MenuItems = value;
            }
        }

        public SubMenuDelegate(string i_Title) : base(i_Title)
        {
            m_MenuItems = new List<MenuItemDelegate>();
        }

        internal override void Activate()
        {
            int v_UserChoice;

            PrintSubMenuPart1();
            v_UserChoice = GetUserChoice();
            m_MenuItems[v_UserChoice].Activate();
        }
        protected void PrintSubMenuPart1()
        {
            Console.Clear();
            Console.WriteLine(string.Format("-- {0} --", base.Title));
            for(int i = 1; i <  m_MenuItems.Count; i++)
            {
                Console.WriteLine(string.Format("{0} -> {1}", i, m_MenuItems[i].Title));
            }

            PrintSubMenuPart2();
        }
        protected virtual void PrintSubMenuPart2() 
        {
            Console.WriteLine("0 -> Back");
            Console.WriteLine(string.Format("Enter your request: (1 to {0} or press '0' to Back)", m_MenuItems.Count - 1));
        }
        protected int GetUserChoice()
        {
            int v_UserChoice;
            string v_UserInput;
            bool v_NotValid = true;

            do
            {
                v_UserInput = Console.ReadLine();
                if (int.TryParse(v_UserInput, out v_UserChoice) && v_UserChoice < m_MenuItems.Count && v_UserChoice >= 0)
                {
                    v_NotValid = false;
                }
                else
                {
                    Console.WriteLine("Invalid Input! Please try again");
                }
            } while (v_NotValid);

            return v_UserChoice;
        }
        public void AddNewSubMenu(SubMenuDelegate i_SubMenuNew)
        {
            m_MenuItems.Add(i_SubMenuNew);
            i_SubMenuNew.MenuItems.Insert(0, this);
        }
        public void AddNewAcetionFromMenu(ActionFromMenuDelegate i_ActionFromMenuNew)
        {
            m_MenuItems.Add(i_ActionFromMenuNew);
            i_ActionFromMenuNew.Back = this;
        }
    }
}
