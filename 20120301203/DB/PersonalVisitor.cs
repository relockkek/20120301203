using System;
using System.Collections.Generic;

namespace _20120301203.DB;

public partial class PersonalVisitor
{
    public int Id { get; set; }

    public int? ApplicationId { get; set; }

    public string? LastName { get; set; }

    public string? FirstName { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? Organization { get; set; }

    public DateOnly? BirthDate { get; set; }

    public string? PassportSeries { get; set; }

    public string? PassportName { get; set; }

    public virtual Application? Application { get; set; }
}
