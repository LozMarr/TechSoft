using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class StatusProject
{
    public int Id { get; set; }

    public string StatusProjectName { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();
}
