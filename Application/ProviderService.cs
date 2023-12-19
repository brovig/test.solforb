using AutoMapper;
using Domain.Contracts;
using Domain.Entities.Exceptions;
using Domain.Entities.Models;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;
internal sealed class ProviderService : IProviderService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public ProviderService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProviderDto>> GetProvidersAsync(bool trackChanges)
    {
        var providers = await _repository.Provider.GetAllProvidersAsync(trackChanges);
        var providersDto = _mapper.Map<IEnumerable<ProviderDto>>(providers);

        return providersDto;
    }

    public async Task<ProviderDto> GetProviderAsync(int id, bool trackChanges)
    {
        var provider = await GetProviderAndCheckIfExists(id, trackChanges);
        var providerDto = _mapper.Map<ProviderDto>(provider);

        return providerDto;
    }


    // helper methods
    private async Task<Provider> GetProviderAndCheckIfExists(int id, bool trackChanges)
    {
        var provider = await _repository.Provider.GetProviderByIdAsync(id, trackChanges);
        if (provider == null)
            throw new ProviderNotFoundException(id);

        return provider;
    }
}
