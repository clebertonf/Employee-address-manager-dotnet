using EmployeeAddressManager.Application.DTOS;
using EmployeeAddressManager.Application.Interfaces;
using EmployeeAddressManager.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeAddressManager.API.Controllers;

[ApiController]
[Route("api/")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpGet("addresses")]
    public async Task<IActionResult> Get()
    {
        return Ok(await _addressService.GetAddressesAsync());
    }

    [HttpGet("addresses/{id}")]
    public async Task<IActionResult> GetId(int id)
    {
        return Ok(await _addressService.GetAddressByIdAsync(id));
    }

    [HttpPost("addresses")]
    public async Task<IActionResult> Post([FromBody] AddressDto address)
    {
        await _addressService.CreateAddressAsync(address);
        return CreatedAtAction(nameof(GetId), new { id = address.Id }, address);
    }

    [HttpPut("addresses/{id}")]
    public async Task<IActionResult> Put(int id, [FromBody] AddressDto address)
    {
        if (id != address.Id)
        {
            return BadRequest();
        }
        
        await _addressService.UpdateAddressAsync(address);
        return NoContent();
    }

    [HttpDelete("addresses/{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        await _addressService.DeleteAddressAsync(id);
        return NoContent();
    }
}