using System.Collections.Generic;
using System.Threading.Tasks;

namespace WA.Contracts
{
    public interface IBaseService<T> where T: class
    {
        Task<T> Create(T entity);

        Task<IEnumerable<T>> GetAll();
    }
}
