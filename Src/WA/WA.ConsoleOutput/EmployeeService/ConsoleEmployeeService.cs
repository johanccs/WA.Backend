using System;
using WA.Contracts;
using WA.Data.Entities;

namespace WA.ConsoleOutput.EmployeeService
{
    public class ConsoleEmployeeService
    {
        #region Readonly Fields

        private readonly IEmployeeService _employeeService;

        #endregion

        #region Ctor

        public ConsoleEmployeeService(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }

        #endregion

        #region Methods

        public EmployeeEntity Create(EmployeeEntity entity)
        {
            try
            {
                _employeeService.Create(entity);

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}
