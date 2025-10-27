using System;
using System.Collections.Generic;

namespace _20120301203.DB;

public partial class Application
{
    public int Id { get; set; }

    public string? ApplicationType { get; set; }

    public string? Status { get; set; }

    public string? RejectionReason { get; set; }

    public DateOnly? StartDate { get; set; }

    public DateOnly? EndDate { get; set; }

    public string? Purprose { get; set; }

    public int DepartmentId { get; set; }

    public int EmployeeId { get; set; }

    public string? ApplicantEmail { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Department Department { get; set; } = null!;

    public virtual Employee Employee { get; set; } = null!;

    public virtual ICollection<GroupApplicationContact> GroupApplicationContacts { get; set; } = new List<GroupApplicationContact>();

    public virtual ICollection<PersonalVisitor> PersonalVisitors { get; set; } = new List<PersonalVisitor>();
}
