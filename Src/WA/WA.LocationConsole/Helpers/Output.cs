using System;
using System.Diagnostics;
using WA.Data.Entities;

namespace WA.LocationConsole.Helpers
{
    public static class Output
    {
        public static void GetStartConfirmation()
        {
            Console.Write($"Start Read and Bulk Insert [Y/N]: ");
            var ans = Console.ReadLine();

            if (ans.ToLower().Equals("n"))
                Environment.Exit(0);
        }

        public static void WriteFooter(Stopwatch sw, RawProjectLocation result)
        {
            Console.WriteLine($"Bulk Insert completed: {result.Data.Count} Record(s) in {sw.Elapsed / 1000} second(s)");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
