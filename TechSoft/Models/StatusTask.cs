using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class StatusTask
{
    public int Id { get; set; }

    public string? StatusTaskName { get; set; }

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
