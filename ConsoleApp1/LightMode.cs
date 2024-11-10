using System;

namespace FactoryPattern
{
    public class LightMode : ITheme
    {
        public string BackgroundColor => "#FFFFFF";
        public string TextColor => "#000000";
        public void ApplyTheme()
        {
            Console.WriteLine("Applying Light Mode...");
            
        }
    }
}
