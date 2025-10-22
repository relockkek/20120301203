using System;
using System.Collections.Generic;

namespace _20120301203.DB;

public partial class GroupApplicationContact
{
    public int Id { get; set; }

    public int? ApplicationId { get; set; }

    public string? ContactName { get; set; }

    public string? ContactEmail { get; set; }

    public string? ContactPhone { get; set; }

    public string? Organization { get; set; }

    public virtual Application? Application { get; set; }
}
