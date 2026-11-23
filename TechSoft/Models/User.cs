using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class User
{
    public int Id { get; set; }

    public int IdRole { get; set; }

    public string FullName { get; set; } = null!;

    public string Login { get; set; } = null!;

    public string Password { get; set; } = null!;

    public virtual ICollection<AssignmentProject> AssignmentProjects { get; set; } = new List<AssignmentProject>();

    public virtual Role IdRoleNavigation { get; set; } = null!;

    public virtual ICollection<Project> Projects { get; set; } = new List<Project>();

    public virtual ICollection<Task> Tasks { get; set; } = new List<Task>();
}
