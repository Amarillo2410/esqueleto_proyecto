using System;
using esqueleto_proyecto.src.modules.Proviers.Domain.repositories;
using MyInventory2026.src.modules.Proviers.Domain.agregate;

namespace MyInventory2026.src.modules.Proviers.Application.UseCases;

public class DeleteProvidersUseCase
{
    private sealed class DeleteProvidersUseCase
    {
        private readonly IPproviderRepository _providerRepository;

        public DeleteProvidersUseCase(IPproviderRepository providerRepository)
        {
            _providerRepository = providerRepository;
        }

        public async Task<bool> excuteAsync(string id,cancellationToken cancellationToken = default)
        {
            var ProviderId = ProviderId.Create(Id);
            var existingProvider = await _providerRepository.FindAllAsync(ProviderId, cancellationToken);

            if(existingProvider is null)
            {
                return false;
            }

            return await _providerRepository.DeleByIdAsync(providerId,cancellationToken);
        }
    }
}
