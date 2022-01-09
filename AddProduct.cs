using System;

namespace DEMO_ASM2
{
    public class AddProduct: Menu
    {
        protected override void PrintMenu()
        {
            Console.WriteLine("1. Summer");
            Console.WriteLine("2. Winter");
            Console.WriteLine("0. Exit");

        }
        protected override void DoTask(int choice)
        {
            switch (choice)
            {
                case 1: Summer(); break;

                case 2: Winter(); break;

                case 3: Console.WriteLine("Exit"); break;

                default: Console.WriteLine("Invalid choice"); break;

            }

        }
        private void Summer()
        {
            
        }
    }

}