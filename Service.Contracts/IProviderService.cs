using Shared.DataTransferObjects;

namespace Service.Contracts;
public interface IProviderService
{
    Task<IEnumerable<ProviderDto>> GetProvidersAsync(bool trackChanges);
    Task<ProviderDto> GetProviderAsync(int id, bool trackChanges);
}
