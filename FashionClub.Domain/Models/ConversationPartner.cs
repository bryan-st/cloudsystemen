namespace FashionClub.Domain.Models;

public class ConversationPartner
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsLastSpoken { get; set; }
    
    //navigationalProperty
    public long CustomerId { get; set; }
    public Customer? Customer { get; set; }
}