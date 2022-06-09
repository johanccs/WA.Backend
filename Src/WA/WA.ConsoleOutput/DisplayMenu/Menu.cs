using System;
using System.Threading.Tasks;
using WA.Common.Helpers;
using WA.Contracts;
using WA.Data.Entities;

namespace WA.ConsoleOutput.DisplayMenu
{
    public static class Menu
    {

        public async static Task<int> DisplayMenu()
        {
            Output.PrintHeader();

            Console.Write(" Answer: ");

            return await Task.FromResult(Convert.ToInt32(Console.ReadLine()));
        }

        public async static Task DisplayByMenuItem(int answer, IEmployeeService empService)
        {
            switch (answer)
            {
                case 0:
                    Environment.Exit(0);
                    break;
                case 1:
                    PrintAndClearEmptyLine();
                    await GetEmployeeData(empService);

                    break;

                default:
                    Console.Clear();
                    await DisplayMenu();
                    
                    break;
            } 
        }

        private async static Task GetEmployeeData(IEmployeeService empService)
        {
            var newEmployee = new EmployeeEntity();

            Console.WriteLine(" Please provide the following employee details");
            Console.Write(" Name: ");
            newEmployee.Name = Console.ReadLine();

            Console.Write(" Surname: ");
            newEmployee.Surname = Console.ReadLine();

            Console.WriteLine(" Job Title");
            Console.WriteLine("   1 -> Developer: ");
            Console.WriteLine("   2 -> DBA: ");
            Console.WriteLine("   3 -> Test: ");
            Console.WriteLine("   4 -> Business Analyst: ");
            Console.Write(" Select between 1, 2, 3, 4: ");
            newEmployee.JobTitleId = Convert.ToInt32(Console.ReadLine());

            Console.Write(" Date Of Birth (dd/MM/yyyy): ");
            newEmployee.DateOfBirth = new DateTime().GetDate(Console.ReadLine());

            Output.PrintConfirmationMessage();
            var ans = Console.ReadLine();

            if(ans.ToLower().Equals("y"))
            {
                var result = await empService.Create(newEmployee);
                Output.PrintFooter($" Employee {result.Id} is created successfully");
            }
            else
            {
                Output.PrintCanceledMessage(" Canceled by user");
            }
        }

        private static void PrintAndClearEmptyLine()
        {
            Console.Clear();
            Console.WriteLine("");
        }
    }
}
