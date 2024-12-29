using FashionClub.Domain.Enums;

namespace FashionClub.Domain.Models;

public class ReportBrand
{
    public long Id { get; set; }
    public long VisitReportId { get; set; }
    public virtual Brand Brand { get; set; }
    public BrandCategory Category { get; set; }
}