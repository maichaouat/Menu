

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuItemInterface
    {
        private string m_Title;

        internal string Title
        {
            get
            {
                return m_Title;
            }
            set
            {
                m_Title = value;
            }
        }

        public MenuItemInterface(string i_Title)
        {
            m_Title = i_Title;
        }

        internal abstract void Activate();
    }
}
