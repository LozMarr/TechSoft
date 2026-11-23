using System;
using System.Collections.Generic;

namespace TechSoft.Models;

public partial class AssignmentProject
{
    public int Id { get; set; }

    public int IdUser { get; set; }

    public int IdProject { get; set; }

    public virtual Project IdProjectNavigation { get; set; } = null!;

    public virtual User IdUserNavigation { get; set; } = null!;
}
