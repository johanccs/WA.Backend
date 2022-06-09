using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using WA.Contracts;
using WA.Data.DbCtx;
using WA.Data.Entities;
using WA.Services;
using Xunit;

namespace WA.Tests.Services
{

    public class EmployeeServiceTests
    {
        #region Readonly Fields

        private readonly ApplicationDbContext _dbContext;
        private readonly IEmployeeService _employeeService;
        
        #endregion



        #region Constructor

        public EmployeeServiceTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("MockWA")
                .Options;

            _dbContext = new ApplicationDbContext(options);

            _employeeService = new EmployeeService(_dbContext);
        }

        #endregion


        #region Methods

        [Fact]
        public async Task Should_Add_Employee_Success()
        {
            var employee = new EmployeeEntity()
            {
                Id = 0,
                JobTitleId = 1,
                Name = "Johan",
                Surname = "Potgieter",
                DateOfBirth = new DateTime(1974, 11, 01)
            };

            var result = await _employeeService.Create(employee);

            Assert.True(result != null);
            
        }

        [Fact]
        public async Task Should_List_Employee_NotNull()
        {
            var employee = new EmployeeEntity()
            {
                Id = 0,
                JobTitleId = 1,
                Name = "Johan",
                Surname = "Potgieter",
                DateOfBirth = new DateTime(1974, 11, 01)
            };

            await _employeeService.Create(employee);
            var list = await _employeeService.GetAll();

            Assert.True(list != null);
            Assert.True(list.ToList().Count == 1);

        }

        #endregion
    }
}
