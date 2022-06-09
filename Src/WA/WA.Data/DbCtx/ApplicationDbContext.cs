using Microsoft.EntityFrameworkCore;
using WA.Data.Entities;

namespace WA.Data.DbCtx

{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions options):base(options)
        {
        }

        public DbSet<EmployeeEntity> Employee { get; set; }

        public DbSet<JobTitleEntity> JobTitle { get; set; }

        public DbSet<ProjectEmployeeEntity>ProjectEmployee{ get; set; }

        public DbSet<ProjectEntity> Project { get; set; }

        public DbSet<SkillEntity> Skill { get; set; }

        public DbSet<User> User { get; set; }

        public DbSet<ProjectLocationsEntity>ProjectLocations { get; set; }
    }
}
