using System;
using System.Collections.Generic;

namespace BarberCompany.Models;

public partial class BarberShop
{
    public int IdBarberShop { get; set; }

    public string NameBarber { get; set; } = null!;

    public string Address { get; set; } = null!;

    public int AddressNumber { get; set; }

    public string City { get; set; } = null!;

    public virtual ICollection<Barber> Barbers { get; set; } = new List<Barber>();

    public virtual ICollection<ServiceUser> ServiceUsers { get; set; } = new List<ServiceUser>();
}
