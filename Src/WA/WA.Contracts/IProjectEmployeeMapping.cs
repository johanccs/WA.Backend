using System.Collections.Generic;
using WA.Data.Dtos;
using WA.Data.Entities;

namespace WA.Contracts
{
    public interface IProjectEmployeeMapping
    {
        List<ProjectEmployeeDto> Map(List<ProjectEmployeeEntity> source);
    }
}
