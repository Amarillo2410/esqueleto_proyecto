using System;
using esqueleto_proyecto.src.modules.Proviers.Domain.repositories;
using MyInventory2026.src.modules.Proviers.Domain.agregate;

namespace MyInventory2026.src.modules.Proviers.Application.UseCases;

public sealed class GetAllProvidersUseCase
{
    private readonly IPproviderRepository _providerRepository;

    public GetAllProvidersUseCase(IPproviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }

    public Task <IReadOnlyCollection<provider>>ExcuteAsync(cancellationToken cancellationToken = default)
    {
        return _providerRepository.FindAllAsync(cancellationToken);
    }
}

