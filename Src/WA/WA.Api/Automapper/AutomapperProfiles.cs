using AutoMapper;
using WA.Data.Dtos;
using WA.Data.Entities;

namespace WA.Api.Automapper
{
    public class AutoMapperProfiles: Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<NewEmployeeDto,EmployeeEntity>().ReverseMap();

            CreateMap<NewProjectDto, ProjectEntity>().ReverseMap();
        }
    }
}
