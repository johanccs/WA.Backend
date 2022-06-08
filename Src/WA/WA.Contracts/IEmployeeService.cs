using System.Threading.Tasks;
using WA.Data.Entities;

namespace WA.Contracts
{
    public interface IEmployeeService: IBaseService<EmployeeEntity>
    {
        Task<EmployeeEntity> Create(EmployeeEntity entity);
    }
}
