using System;
using System.Collections.Generic;

namespace BarberCompany.Models;

public partial class Citation
{
    public int IdCitation { get; set; }

    public DateOnly DateCitation { get; set; }

    public TimeOnly HourCitation { get; set; }

    public virtual ICollection<ServiceUser> ServiceUsers { get; set; } = new List<ServiceUser>();
}
