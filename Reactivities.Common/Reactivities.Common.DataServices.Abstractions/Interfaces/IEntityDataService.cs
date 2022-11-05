namespace Reactivities.Common.DataServices.Abstractions.Interfaces;

public interface IEntityDataService<TDomainEntity>
    where TDomainEntity : class
{
    public IQueryable<TDomainEntity> GetAsQueryable();

    public void Create(TDomainEntity activity);

    public void Update(TDomainEntity activity);

    public void Remove(TDomainEntity activity);

    Task SaveChangesAsync(CancellationToken token = default, string errorToShow = null);
}