using System;

namespace MyInventory2026.src.shared.context;

public class IUnitOfWorks
{
   Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
}
