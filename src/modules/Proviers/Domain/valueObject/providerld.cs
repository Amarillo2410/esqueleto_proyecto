using Pomelo.EntityFrameworkCore.MySql.Metadata.Conventions;

namespace MyInventory2026.src.modules.Proviers.Domain.valueObject;

public sealed record class providerld
{
    public string Value { get; }

    private providerld (string value)
    {
        Value = value;
    }

    public static providerld create (string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("provider id cannot be empty.",nameof(value));
        }
        return new providerld(value.Trim());
 }

    public override string ToString() => Value;
 
}
