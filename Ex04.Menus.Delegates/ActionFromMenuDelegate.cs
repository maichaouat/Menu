using System;

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
            Console.WriteLine("\nPress any key to continue");
            Console.ReadLine();
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
