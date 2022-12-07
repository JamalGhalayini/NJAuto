using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using NJAuto.Server.Data;
using NJAuto.Server.Services;
using NJAuto.Shared.Models;

namespace NJAuto.Server.Controllers
{
    [Route("/Employees")]
    [ApiController]
    public class EmployeeController : Controller
    {
        private readonly IEmployeesService _employeesService;
        private readonly UserManager<UserEntity> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public EmployeeController(IEmployeesService employeesService, UserManager<UserEntity> userManager,
          RoleManager<IdentityRole> roleManager)
        {
            _employeesService = employeesService;
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] CreateEmployee request)
        {
            var existingUser = await _userManager.FindByNameAsync(request.Username);
            if (existingUser is not null)
            {
                return BadRequest("Username is already taken");
            }

            if (await _roleManager.FindByNameAsync("User") is null)
            {
                await _roleManager.CreateAsync(new()
                {
                    Name = "User"
                });
            }

            var user = new UserEntity()
            {
                UserName = request.Username,
            };

            var result = await _userManager.CreateAsync(user, request.Password);

            await _userManager.AddToRoleAsync(user, "User");

            if (!result.Succeeded)
            {
                return BadRequest(result.Errors);
            }
            else
            {
                await _employeesService.AddEmployee(request);
                return Ok("User created");
            }

        }

        [HttpPut("{id}")]
        public async Task<ActionResult> EditEmployee([FromBody] Employee employee, [FromRoute] int id)
        {
            if (ModelState.IsValid)
            {
                var result = await _employeesService.EditEmployee(employee, id);
                return Ok(result);
            }

            return BadRequest();
        }

        [HttpGet]
        public async Task<List<Employee>> GetEmployee()
        {
            var result = await _employeesService.GetEmployee();
            return result;
        }


        [HttpDelete("{employeeId}")]
        public async Task<ActionResult> RemoveEmployee(int employeeId)
        {
            var result = await _employeesService.FindEmployee(employeeId);
            if (result != null)
            {
                var existingUser = await _userManager.FindByNameAsync(result.Username);
                if (existingUser is not null)
                {
                    await _userManager.DeleteAsync(existingUser);

                }
                await _employeesService.RemoveEmployee(result);
                return Ok();
            }
            return NotFound();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee([FromRoute] int id )
        {
            var result = await _employeesService.FindEmployee(id);
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

    }
}
