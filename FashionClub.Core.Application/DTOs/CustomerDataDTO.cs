using FashionClub.Domain.Models;

namespace FashionClub.Core.Application.DTOs;

public class CustomerDataDTO
{
    public Customer Klant { get; set; }
    public Contact? Contact { get; set; }
    public Address? Address { get; set; }
}
