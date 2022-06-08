using System.Threading.Tasks;
using WA.Data.Dtos;
using WA.Data.Entities;

namespace WA.Contracts
{
    public interface IProjectService: IBaseService<ProjectEmployeeDto>
    {
        Task<ProjectEntity> Create(ProjectEntity entity);
    }
}
