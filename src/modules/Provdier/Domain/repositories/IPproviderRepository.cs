using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyInventory2026.src.modules.Proviers.Domain.agregate;
using MyInventory2026.src.modules.Proviers.Domain.valueObject;

namespace esqueleto_proyecto.src.modules.Proviers.Domain.repositories
{
    public interface IPproviderRepository
    {
        Task AddAsync (Provider provider,CancellationToken cancellationToken= default);
        Task <provider> FindByAsync(providerId id,cacellationToken cacellationToken = default);
        Task <IReadOnlyCollection<provider>> FindAllAsync(CancellationToken cancellationToken = default);
        Task UpdateAsync(provider provider, cancellationToken cacellationToken = default);
        Task <bool> DeleByIdAsync(provider id,CancellationToken cancellationToken = default);
    }
}