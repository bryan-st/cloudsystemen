namespace FashionClub.Domain.Models;

public partial class Employee
{
    public long Id { get; set; }

    public string? FirstName { get; set; }

    public int Order { get; set; }

    public long? UserId { get; set; }

    public string? TelNumber { get; set; }

    public bool HideForAgenda { get; set; }

    public string? Name { get; set; }

    public long UserCreatedId { get; set; }

    public DateTime DateCreated { get; set; }

    public byte[] Timestamp { get; set; } = null!;

    public long? RecurringAppointmentId { get; set; }

    public int Pin { get; set; }

    public long? AgentId { get; set; }

    public string? MobileNumber { get; set; }
}
