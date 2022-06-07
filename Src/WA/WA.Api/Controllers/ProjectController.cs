using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using WA.Contracts;
using WA.Data.Dtos;
using WA.Data.Entities;

namespace WA.Api.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        #region Readonly Fields

        private readonly IProjectService _projectService;

        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        public ProjectController(IProjectService projectService, IMapper mapper)
        {
            _projectService = projectService;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpPost()]
        [ResponseCache(Duration = 120)]
        public async Task<IActionResult> CreateProject(NewProjectDto newproject)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid parameter");
                }

                var mappedproject = _mapper.Map<ProjectEntity>(newproject);

                var result = await _projectService.Create(mappedproject);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

    }
}
