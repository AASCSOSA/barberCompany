namespace BarberCompany.Models;

public partial class UserBarber
{
    public int IdUser { get; set; }

    public string NameUser { get; set; } = null!;

    public string FatherLastName { get; set; } = null!;

    public string? MotherLastName { get; set; }

    public string? ContactNumber { get; set; }

    public virtual ICollection<ServiceUser> ServiceUsers { get; set; } = new List<ServiceUser>();
}
