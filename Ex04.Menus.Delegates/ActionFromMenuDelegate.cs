using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class ActionFromMenuDelegate : MenuItemDelegate
    {
        private MenuItemDelegate m_Back = null;
        public event Action ChosenNotifier;

        internal MenuItemDelegate Back
        {
            set
            { 
                m_Back = value;
            }
        }

        public ActionFromMenuDelegate(string i_Title) : base(i_Title)
        {
        }

        internal override void Activate()
        {
            OnChosen();
            m_Back.Activate();
        }
        protected virtual void OnChosen()
        {
            if (ChosenNotifier != null)
            {
                ChosenNotifier.Invoke();
            }
        }
    }
}
