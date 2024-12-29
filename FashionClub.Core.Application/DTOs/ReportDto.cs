using FashionClub.Domain.Models;

namespace FashionClub.Core.Application.DTOs;

public class ReportDto
{
    // 1
    public long KlantId { get; set; }
    // 2
    //create a model to persist this conversationPartner
    public List<ConversationPartnerDTO> ConversationPartners { get; set; } = [];
    // 3 
    public string Reason { get; set; }
    // 4 + 6
    public BrandmixOverviewDTO? BrandMixOverview { get; set; }
    // 5
    public GeneralSituationDTO? GeneralSituation { get; set; }
    //7
    public List<BrandDTO>? InterestingBrands { get; set; }
    //8
    public string? TrendsRequirements { get; set; }
    //9
    public string? Feedback { get; set; }
}