
using System;

namespace Ex04.Menus.Interfaces
{
    public class ActionFromMenuInterface : MenuItemInterface
    {
        private MenuItemInterface m_Back = null;
        IApplicationFunction m_ApplicationFunction;

        internal MenuItemInterface Back
        {
            set
            {
                m_Back = value;
            }
        }

        public ActionFromMenuInterface(string i_Title, IApplicationFunction i_ApplicationFunction) : base(i_Title)
        {
            m_ApplicationFunction = i_ApplicationFunction;
        }

        internal override void Activate()
        {
            m_ApplicationFunction.FuncInApplication();
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
            m_Back.Activate();
        }
    }
}
