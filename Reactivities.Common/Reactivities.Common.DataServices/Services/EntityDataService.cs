using Microsoft.EntityFrameworkCore;
using Reactivities.Common.DataServices.ErrorHandling;
using Reactivities.Common.DataServices.Interfaces;
using Reactivities.Common.ErrorHandling.Models;

namespace Reactivities.Common.DataServices.Services;

public class EntityDataService<TDomainEntity> : IEntityDataService<DbContext,TDomainEntity>
    where TDomainEntity : class, new ()
{
    protected readonly DbContext DataContext;
    protected readonly DbSet<TDomainEntity> DataSet;

    public EntityDataService(DbContext dataContext)
    {
        this.DataContext = dataContext;
        this.DataSet = dataContext.Set<TDomainEntity>();
    }

    public IQueryable<TDomainEntity> GetAsQueryable()
        => this.DataSet;

    public async Task SaveChangesAsync(CancellationToken token = default, string errorToShow = null)
    {
        if (await this.DataContext.SaveChangesAsync(token) > 0)
            return;

        throw new AppException(errorToShow ?? ErrorMessage.ForUnableToSaveChanges);
    }

    public void Create(TDomainEntity entity)
        => this.DataSet.Add(entity);

    public void Update(TDomainEntity entity)
        => this.DataSet.Update(entity);

    public void Remove(TDomainEntity entity)
        => this.DataSet.Remove(entity);
}