using WA.Data.Entities;

namespace WA.Contracts
{
    public interface IRecalcProjectCost<T>
    {
        decimal Calculate(decimal cost, T entity);
    }
}
