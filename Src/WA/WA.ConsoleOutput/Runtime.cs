using System.Threading.Tasks;
using WA.ConsoleOutput.DisplayMenu;
using WA.Contracts;

namespace WA.ConsoleOutput
{
    public class Runtime
    {
        #region Readonly Fields

        private readonly IEmployeeService _employeeService;

        #endregion

        #region Ctor
  
        public Runtime(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        #endregion

        #region Methods

        public async Task Run()
        {
            var answer = await Menu.DisplayMenu();

            await Menu.DisplayByMenuItem(answer, _employeeService);
        }

        #endregion
    }
}
