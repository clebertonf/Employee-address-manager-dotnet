using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAddressManager.Application.DTOS;

public class AddressDto
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Street is required!")]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("Street")]
    public string? Street { get; set; }
    
    [Required(ErrorMessage = "City is required!")]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("City")]
    public string? City { get; set; }
    
    [Required(ErrorMessage = "State is required!")]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("State")]
    public string? State { get; set; }
    
    public int EmployeeId { get; set; }
}