using _20120301203.DB;

namespace _20120301203.CQRS.CommandList
{
    public class ApplicationDto
    {
        public int Id { get; set; }
        public string ApplicationType { get; set; } 
        public string Status { get; set; }
        public string? RejectionReason { get; set; }
        public DateOnly? StartDate { get; set; }
        public DateOnly? EndDate { get; set; }
        public Department Department { get; set;  }
        public string Purpose { get; set; }
        public string DepartmentName { get; set; }
        public string EmployeeName { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
