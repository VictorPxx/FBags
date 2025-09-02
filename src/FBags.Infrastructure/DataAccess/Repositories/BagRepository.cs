using FBags.Domain.Entities;
using FBags.Domain.Repositories.Bags;

namespace FBags.Infrastructure.DataAccess.Repositories;
internal class BagRepository : IBagsRepository
{
    private readonly FBagsDbContext _dbContext;

    public BagRepository(FBagsDbContext dbContext)
    {
        _dbContext = dbContext;
    }

    public void Add(Bag bag)
    {
        _dbContext.Bags.Add(bag);
    }
}
