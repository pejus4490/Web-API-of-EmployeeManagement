namespace EmployeeManagment.Models;

public class Attendance 
{
    public int Id {  get; set; }
    public int EmployeeId { get; set; }
    
    public DateTime AttendanceDate { get; set;}

    public int isPresent { get; set; }
    public int isAbsent { get; set; }
    public int isOffday { get; set; }

}

