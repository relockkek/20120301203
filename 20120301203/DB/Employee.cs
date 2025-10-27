using System;
using System.Collections.Generic;

namespace _20120301203.DB;

public partial class Employee
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public int DepartmentId { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual Department Department { get; set; } = null!;
}
