using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class Task
{
    public int Id { get; set; }

    public string TaskName { get; set; } = null!;

    public int IdPriority { get; set; }

    public int IdProject { get; set; }

    public int IdUser { get; set; }

    public int IdStatussTask { get; set; }

    public string Description { get; set; } = null!;

    public DateOnly DateCreate { get; set; }

    public DateOnly Deadline { get; set; }

    public virtual Priority IdPriorityNavigation { get; set; } = null!;

    public virtual Project IdProjectNavigation { get; set; } = null!;

    public virtual StatusTask IdStatussTaskNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
