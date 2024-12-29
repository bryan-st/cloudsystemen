using FashionClub.Core.Application.DTOs;
using FashionClub.Domain.Models;
using Microsoft.EntityFrameworkCore;
using NetTopologySuite.Geometries;

namespace FashionClub.Core.Application.Abstractions.Repositories;

public interface IFCRepository
{
    
    DbSet<Customer> Customers { get; }
    DbSet<Contact> Contacts { get; }
    DbSet<Address> Addresses { get; }
    DbSet<Brand> Brands { get; }
    DbSet<ConversationPartner> ConversationPartners { get; }
    DbSet<CompetitorBrand> CompetitorBrands { get; }
    DbSet<Report> Reports { get; }
    Task<int> SaveChangesAsync(CancellationToken cancellationToken);
}