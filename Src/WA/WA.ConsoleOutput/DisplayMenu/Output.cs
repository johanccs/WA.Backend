using System;

namespace WA.ConsoleOutput.DisplayMenu
{
    public static class Output
    {
        public static void PrintHeader()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(" Please select an action from the menu");
            Console.WriteLine(" -------------------------------------");
            Console.WriteLine(" 1. Add new Employee");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Exit");
            Console.WriteLine("");
        }

        public static void PrintFooter(string footer)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine(footer);
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("");
        }
    
        public static void PrintCanceledMessage(string exceptionMessage)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("");
            Console.WriteLine(exceptionMessage);
            Console.WriteLine(" ----------------------------------------");
            Console.WriteLine("");
        }

        public static void PrintConfirmationMessage()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(" Are you sure you want add the employee [Y/N]: ? ");
        }
    }
}
