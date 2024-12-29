using FashionClub.Core.Application.Abstractions.Repositories;
using FashionClub.Core.Application.DTOs;
using FashionClub.Domain.Models;
using FashionClub.Infrastructure.Data.Persistence;
using Microsoft.EntityFrameworkCore;

namespace FashionClub.Infrastructure.Data.Repositories;

public class FCRepository(FashionClubDbContext context) : IFCRepository 
{
    public DbSet<Customer> Customers => context.Customers;
    public DbSet<Contact> Contacts => context.Contacts;
    public DbSet<Address> Addresses => context.Addresses;
    public DbSet<Brand> Brands => context.Brands;
    public DbSet<ConversationPartner> ConversationPartners => context.ConversationPartners;
    public DbSet<CompetitorBrand> CompetitorBrands => context.CompetitorBrands;
    public DbSet<Report> Reports => context.Reports;

    public Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
    {
        return context.SaveChangesAsync(cancellationToken);  
    }
    
}