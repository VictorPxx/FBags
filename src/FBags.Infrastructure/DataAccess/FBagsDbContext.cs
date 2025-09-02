using FBags.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace FBags.Infrastructure.DataAccess;
internal class FBagsDbContext : DbContext
{
    public FBagsDbContext(DbContextOptions options) : base(options){ }

    public DbSet<Bag> Bags { get; set; }
}
