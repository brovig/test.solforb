using Domain.Entities.Models;

namespace Domain.Contracts;
public interface IProviderRepository
{
    Task<IEnumerable<Provider>> GetAllProvidersAsync(bool trackChanges);
    Task<Provider> GetProviderByIdAsync(int id, bool trackChanges);
    Task<List<int>> GetProviderIdsByProviderNames(List<string> providerNames);
}
