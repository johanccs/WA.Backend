using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using WA.Contracts;
using WA.Data.DbCtx;
using WA.Data.Entities;

namespace WA.Services
{
    public class ProjectService : IProjectService
    {
        #region Private Readonly Fields

        private readonly ApplicationDbContext _dbContext;

        #endregion

        #region Constructor

        public ProjectService(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        #endregion

        #region Public Methods

        public async Task<ProjectEntity> Create(ProjectEntity entity)
        {
            try
            {
                await _dbContext.AddAsync<ProjectEntity>(entity);

                await _dbContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<IEnumerable<ProjectEntity>> GetAll()
        {
            return await _dbContext.Project.AsNoTracking().ToListAsync();
        }

        #endregion
    }
}
