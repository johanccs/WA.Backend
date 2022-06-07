using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WA.Data.DbCtx;
using Xunit;

namespace BE.Tests.Services
{

    public class AuthServiceTests
    {
        ApplicationDbContext _dbContext;
       
        public AuthServiceTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("MockBETS")
                .Options;

            _dbContext = new ApplicationDbContext(options);
        
        }

        [Fact]
        public async Task Should_Add_New_User_NotNull()
        {
            

        }
    }
}
