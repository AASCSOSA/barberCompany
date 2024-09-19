using System;
using System.Collections.Generic;

namespace BarberCompany.Models;

public partial class ServiceBarber
{
    public int IdService { get; set; }

    public string NameService { get; set; } = null!;

    public string DescriptionService { get; set; } = null!;

    public decimal ServiceCost { get; set; }

    public virtual ICollection<ServiceUser> ServiceUsers { get; set; } = new List<ServiceUser>();
}
