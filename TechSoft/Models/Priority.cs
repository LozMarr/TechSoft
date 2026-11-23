using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class Priority
{
    public int Id { get; set; }

    public string? PriorityName { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
