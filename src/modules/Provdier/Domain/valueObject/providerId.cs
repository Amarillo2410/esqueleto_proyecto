using Pomelo.EntityFrameworkCore.MySql.Metadata.Conventions;

namespace MyInventory2026.src.modules.Proviers.Domain.valueObject;

public sealed record class providerId
{
    public string Value { get; }

    private providerId (string value)
    {
        Value = value;
    }

    public static providerId create (string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentException("provider id cannot be empty.",nameof(value));
        }
        return new providerId(value.Trim());
 }

    public override string ToString() => Value;
 
}
