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
    public class EmployeeController : ControllerBase
    {
        #region Readonly Fields

        private readonly IEmployeeService _empService;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        public EmployeeController(IEmployeeService empService, IMapper mapper)
        {
            _empService = empService;
            _mapper = mapper;
        }

        #endregion

        #region Methods

        [HttpGet()]
        [ResponseCache(Duration = 120)]
        public async Task<IActionResult> Get()
        {
            try
            {
                var employees = _empService.GetAll();

                if (employees == null)
                    return NotFound("No employees found");


                return Ok(employees);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost()]
        [ResponseCache(Duration = 120)]
        public async Task<IActionResult> CreateCartItem(NewEmployeeDto newEmployee)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest("Invalid parameter");
                }

                var mappedEmployee = _mapper.Map<EmployeeEntity>(newEmployee);

                var result = await _empService.Create(mappedEmployee);

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
