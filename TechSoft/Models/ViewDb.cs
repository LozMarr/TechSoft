using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class ViewDb
{
    public string? PriorityName { get; set; }

    public string? ProjectName { get; set; }

    public string? FullName { get; set; }

    public string? StatusTaskName { get; set; }

    public string? Description { get; set; }

    public string? TaskName { get; set; }

    public DateOnly? DateCreate { get; set; }

    public DateOnly? Deadline { get; set; }

    public string? PhotoUrl { get; set; }
}
