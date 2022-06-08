using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WA.Contracts;
using WA.Data.DbCtx;
using WA.Data.Dtos;
using WA.Data.Entities;
using WA.Data.Helpers;

namespace WA.Services
{
    public class ProjectService : IProjectService
    {
        #region Private Readonly Fields

        private readonly ApplicationDbContext _dbContext;
        private readonly IProjectEmployeeMapping _projectMapping;

        #endregion

        #region Constructor

        public ProjectService(ApplicationDbContext dbContext, IProjectEmployeeMapping projectMapping)
        {
            _dbContext = dbContext;
            _projectMapping = projectMapping;
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

        public async Task<IEnumerable<ProjectEmployeeDto>> GetAll()
        {
            var unmappedProjects = await GetInternalList();

            return _projectMapping.Map(unmappedProjects.ToList());
            
        }

        #endregion

        #region Private Methods

        private async Task<IEnumerable<ProjectEmployeeEntity>>GetInternalList()
        {

            var result = await _dbContext.ProjectEmployee.Include(x => x.Employee).Include(x => x.Project).ToListAsync();

            return result;
        }

        

        #endregion
    }
}
