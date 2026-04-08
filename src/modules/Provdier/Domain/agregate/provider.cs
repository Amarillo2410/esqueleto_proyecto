using System;
using MyInventory2026.src.modules.Proviers.Domain.valueObject;

namespace MyInventory2026.src.modules.Proviers.Domain.agregate;

public class provider
{
    public providerld ID {get;private set;}
    public ProviderName Name {get; private set;}

    private provider(providerld id, ProviderName Name)
    {
        Id=id;
        Name=name;
    }

    public static provider create(string id, string name)
    {
        return new provider(
            providerId.Create(id),
            ProviderName.Create(name) 
        );
    }
}
