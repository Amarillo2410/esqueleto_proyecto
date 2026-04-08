using System;
using esqueleto_proyecto.src.modules.Proviers.Domain.repositories;
using MyInventory2026.src.modules.Proviers.Domain.agregate;

namespace MyInventory2026.src.modules.Proviers.Application.UseCases;

public sealed class UpDateProviderByidUseCase
{
    private readonly IPproviderRepository _providerRepository;

    public UpDateProviderByidUseCase(IPproviderRepository pproviderRepository)
    {
        _providerRepository = _providerRepository;
    }

    public async Task<Provider>ExcuteAsync(string id, string name, cancellationToken cancellationToken = default)
    {
        var providerId = providerId.Create(id);
        var existingProvider = await _providerRepository.FindByIdAsync(providerId, cancellationToken);

        if(existingProvider is null)
        {
            throw new KeyNotFoundException($"Provider with id '{providerId}'was not found");
        }

        var UpdateProvider = provider.create(id,name);
        await _providerRepository.UpdateAsync(UpdateProvider,cancellationToken);
        return UpdateProvider;
    }
}

