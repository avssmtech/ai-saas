namespace AiSaas.SharedKernel;

// Simple strong-typed ID base (expand later)
public readonly record struct StrongId(Guid Value)
{
    public static StrongId New() => new(Guid.NewGuid());
    public override string ToString() => Value.ToString();
}
