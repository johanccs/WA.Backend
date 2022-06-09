using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WA.Contracts;
using WA.Data.DbCtx;
using WA.Data.Entities;

namespace WA.Services
{
    public class EmployeeService: IEmployeeService
    {
        #region Private Readonly Fields

        private readonly ApplicationDbContext _dbContext;

        #endregion

        #region Constructor

        public EmployeeService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Methods

        public async Task<EmployeeEntity> Create(EmployeeEntity user)
        {
            try
            {
                _dbContext.Employee.Add(user);

                _dbContext.SaveChanges();

                return await Task.FromResult(user);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<EmployeeEntity>> GetAll()
        {
            return await _dbContext.Employee.AsNoTracking().ToListAsync();
        }

        public async Task<EmployeeEntity> GetUser(int id)
        {
            return await _dbContext.Employee.FirstAsync(x => x.Id == id);
        }

        #endregion
    }
}
