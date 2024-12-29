using System.ComponentModel.DataAnnotations.Schema;

namespace FashionClub.Domain.Models;

public class Report
{
    public long Id { get; set; }
    public long CustomerId { get; set; }
    public List<ConversationPartner> ConversationPartners { get; set; } = new List<ConversationPartner>();
    public DateOnly Date { get; set; }
    public string? TrendsAndNeeds { get; set; }
    public string? Feedback { get; set; }
    public string Reason { get; set; }
    public virtual ICollection<Brand>? Brands { get; set; } = new List<Brand>();
    public virtual ICollection<CompetitorBrand>? CompetitorBrands { get; set; } = new List<CompetitorBrand>();
    public virtual ICollection<BrandOverview> BrandOverviews { get; set; } = new List<BrandOverview>();
    public virtual ICollection<InterestingBrand> InterestingBrands { get; set; } = new List<InterestingBrand>();
}