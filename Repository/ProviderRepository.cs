using Domain.Contracts;
using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace Repository;
internal sealed class ProviderRepository : RepositoryBase<Provider>, IProviderRepository
{
    public ProviderRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }

    public async Task<IEnumerable<Provider>> GetAllProvidersAsync(bool trackChanges)
    {
        var providers = await FindAll(trackChanges).ToListAsync();

        return providers;
    }

    public async Task<Provider> GetProviderByIdAsync(int id, bool trackChanges)
    {
        var provider = await FindByCondition(p => p.Id.Equals(id), trackChanges).SingleOrDefaultAsync();

        return provider!;
    }
    
    public async Task<List<int>> GetProviderIdsByProviderNames(List<string> providerNames)
    {
        var providerIds = await FindByCondition(p => providerNames.Contains(p.Name!), trackChanges: false)
            .Select(p => p.Id)
            .ToListAsync();
        
        return providerIds;
    }
}