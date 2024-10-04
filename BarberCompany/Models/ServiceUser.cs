using System;
using System.Collections.Generic;

namespace BarberCompany.Models;

public partial class ServiceUser
{
    public int IdServiceUser { get; set; }

    public int? IdBarber { get; set; }

    public int? IdService { get; set; }

    public int? IdCitation { get; set; }

    public int? IdBarberShop { get; set; }

    public virtual Barber? IdBarberNavigation { get; set; }

    public virtual BarberShop? IdBarberShopNavigation { get; set; }

    public virtual Citation? IdCitationNavigation { get; set; }

    public virtual ServiceBarber? IdServiceNavigation { get; set; }
}
