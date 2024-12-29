namespace FashionClub.Core.Application.DTOs;

public class ConversationPartnerDTO
{
    public long Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool IsLastSpoken { get; set; }
    //dit is de gesprekspartner binnen de winkel. 
}