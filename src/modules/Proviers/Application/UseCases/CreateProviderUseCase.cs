using System;
using esqueleto_proyecto.src.modules.Proviers.Domain.repositories;
using MyInventory2026.src.modules.Proviers.Domain.agregate;

namespace MyInventory2026.src.modules.Proviers.Application.UseCases;

public class CreateProviderUseCase
{
    private readonly IPproviderRepository _providerRepository;

    public CreateProviderUseCase(IPproviderRepository providerRepository)
    {
        _providerRepository = providerRepository;
    }

    public async task <provider> ExcuterAsync(string id, CancellationToken cancellationToken =default)
    {
        var providerId = CreateId.Create(Id);
        var existingProvider = await _providerRepository.FindAllAsync(providerId, cancellationToken);

        if (existingProvider is not null)
        {
            throw new InvalidOperationException($"provider with id '{provider}' already exist.");

        }

        var provider = provider.Create(id,name);
        await _providerRepository.AddAsync(provider,cancellationToken);
        return provider;
    }
}
