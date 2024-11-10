using System;

namespace FactoryPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Select the UI theme (Dark, Light, Blue): ");
            string themeName = Console.ReadLine();
            try
            {
                ITheme theme = ThemeFactory.CreateTheme(themeName);
                theme.ApplyTheme();  
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
