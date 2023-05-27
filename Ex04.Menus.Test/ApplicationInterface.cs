using Ex04.Menus.Interfaces;

namespace Ex04.Menus.Test
{
    public class ApplicationInterface
    {
        public class ShowDate : IApplicationFunction
        {
            public void FuncInApplication()
            {
                ApplicationMethods.ShowDate();
            }
        }
        public class ShowTime : IApplicationFunction
        {
            public void FuncInApplication()
            {
                ApplicationMethods.ShowTime();
            }
        }
        public class ShowVersion : IApplicationFunction
        {
            public void FuncInApplication()
            {
                ApplicationMethods.ShowVersion();
            }
        }
        public class CountSpaces : IApplicationFunction
        {
            public void FuncInApplication()
            {
                ApplicationMethods.CountSpaces();
            }
        }
    }
}
