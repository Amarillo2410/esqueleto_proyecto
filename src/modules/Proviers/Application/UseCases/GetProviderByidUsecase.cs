using System;

namespace MyInventory2026.src.modules.Proviers.Application.UseCases;

public class GetProviderByidUsecase
{
    private readonly IPproviderRepository _providerRepository;

    public GetAllProvidersUseCase(IPproviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }

    public Task <IPproviderRepository <provider>>ExcuteAsync(cancellationToken cancellationToken = default)
    {
        return _providerRepository.FindAllAsync(cancellationToken);
    }
}
