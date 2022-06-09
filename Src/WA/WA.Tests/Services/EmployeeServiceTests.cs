using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WA.Data.DbCtx;
using Xunit;

namespace BE.Tests.Services
{

    public class EmployeeServiceTests
    {
        ApplicationDbContext _dbContext;
       
        public EmployeeServiceTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("MockWA")
                .Options;

            _dbContext = new ApplicationDbContext(options);
        
        }

        [Fact]
        public async Task Should_Add_New_User_NotNull()
        {
            

        }
    }
}
