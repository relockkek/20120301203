using System;
using System.Collections.Generic;

namespace _20120301203.DB;

public partial class Department
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Code { get; set; }

    public virtual ICollection<Application> Applications { get; set; } = new List<Application>();

    public virtual ICollection<Employee> Employees { get; set; } = new List<Employee>();
}
