﻿using System;
using System.Collections.Generic;

namespace BarberCompany.Models;

public partial class Barber
{
    public int IdBarber { get; set; }

    public string NameBarber { get; set; } = null!;

    public string FatherLastName { get; set; } = null!;

    public string? MotherLastName { get; set; }

    public string? ContactNumber { get; set; }

    public bool? AvailabilityBarber { get; set; }

    public int? IdBarberShop { get; set; }

    public virtual BarberShop? IdBarberShopNavigation { get; set; }

    public virtual ICollection<ServiceUser> ServiceUsers { get; set; } = new List<ServiceUser>();
}
