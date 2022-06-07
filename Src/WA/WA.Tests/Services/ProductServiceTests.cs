using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using WA.Data.DbCtx;
using Xunit;

namespace WA.Tests.Services
{
    public class ProductServiceTests
    {
        ApplicationDbContext _dbContext;
       

        public ProductServiceTests()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>().UseInMemoryDatabase("MockBETS")
                .Options;

            _dbContext = new ApplicationDbContext(options);
         
        }

        [Fact]
        public async Task Should_Retrieve_List_Of_Products()
        {
           
        }
    }
}
