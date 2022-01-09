using System;

namespace DEMO_ASM2
{
    class Program
    {
        static void Main(string[] args)
        {
            Store app = new Store();
            app.GetName();
            app.GetSize();
            app.GetColor();

            System.Console.WriteLine("Change them:");
            System.Console.WriteLine("1. Winter");
            System.Console.WriteLine("2. Summer");
            System.Console.Write("Your choice: ");

            string theme = Console.ReadLine();
            app.ChangeTheme(theme);
        }
    }
}
