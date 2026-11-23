using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class Project
{
    public int Id { get; set; }

    public string ProjectName { get; set; } = null!;

    public int IdManager { get; set; }

    public int IdStatusProject { get; set; }

    public string Description { get; set; } = null!;

    public DateOnly DateStart { get; set; }

    public DateOnly? DateComplete { get; set; }

    public string PhotoUrl { get; set; } = null!;

    public virtual ICollection<AssignmentProject> AssignmentProjects { get; set; } = new List<AssignmentProject>();

    public virtual User IdManagerNavigation { get; set; } = null!;

    public virtual StatusProject IdStatusProjectNavigation { get; set; } = null!;

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
