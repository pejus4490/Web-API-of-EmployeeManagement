using System.ComponentModel.DataAnnotations;

namespace EmployeeManagment.Models;

public class Employee 
{
    [Key] 
    public int EmployeeId { get; set; }

    [Required]
    [MaxLength(30)]
    public String? EmployeeName { get; set; }

    [Required]
    [MaxLength(30)]
    public string? EmployeeCode { get; set; } 
    [Required]
    [MaxLength(50)]
    public string? EmployeeSalary { get; set; }

    [Required]
 
    public int SupervisorId { get; set; }
    

    
}



