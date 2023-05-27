using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ActionFromMenuInterface(string i_Title) : base(i_Title)
        {
        }

        internal override void Activate()
        {
            m_ApplicationFunction.FuncInApplication();
            m_Back.Activate();
        }
    }
}
