namespace FashionClub.Domain.Models;

public partial class User
{
    public long Id { get; set; }

    public string Login { get; set; } = null!;

    public bool Blocked { get; set; }
}
