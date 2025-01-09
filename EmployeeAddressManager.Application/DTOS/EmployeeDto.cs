using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace EmployeeAddressManager.Application.DTOS;

public class EmployeeDto
{
    public int Id { get; set; }
    
    [Required(ErrorMessage = "Name is required!")]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("Name")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Role is required!")]
    [MinLength(3)]
    [MaxLength(100)]
    [DisplayName("Role")]
    public string? Role { get; set; }
    
    [Required(ErrorMessage = "DateOfHiring is required!")]
    [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
    public DateTime  DateOfHiring { get; set; }
}