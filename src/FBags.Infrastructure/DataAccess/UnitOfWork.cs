using FBags.Domain;

namespace FBags.Infrastructure.DataAccess;
internal class UnitOfWork : IUnitOfWork
{
    private readonly FBagsDbContext _dbContext;

    public UnitOfWork(FBagsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Commit()
    {
        _dbContext.SaveChanges();
    }
}
