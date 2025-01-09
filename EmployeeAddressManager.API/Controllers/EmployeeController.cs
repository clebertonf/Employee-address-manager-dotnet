using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Application.Interfaces;
using EmployeeAddressManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAddressManager.API.Controllers;

[ApiController]
[Route("api/")]
public class EmployeeController : ControllerBase
{
    private readonly IEmployeeService _employeeService;

    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("employees")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _employeeService.GetEmployeesAsync());
    }

    [HttpGet("employees/{id}")]
    public async Task<IActionResult> GetId(int id)
    {
        return Ok(await _employeeService.GetEmployeeByIdAsync(id));
    }
    

    [HttpPost("employees")]
    public async Task<IActionResult> Post([FromBody] EmployeeDto employee)
    {
        await _employeeService.CreateEmployeeAsync(employee);
        return CreatedAtAction(nameof(GetId), new { id = employee.Id }, employee);
    }

    [HttpPut("employees/{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] EmployeeDto employee)
    {
        if (id != employee.Id)
        {
            return BadRequest();
        }
        
        await _employeeService.UpdateEmployeeAsync(employee);
        return NoContent();
    }

    [HttpDelete("employees/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _employeeService.DeleteEmployeeAsync(id);
        return NoContent();
    }
}