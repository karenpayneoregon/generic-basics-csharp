#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
namespace ValidatorLibrary;

public class ErrorContainer
{
    public string Name { get; set; }
    public string Description { get; set; }
    public override string ToString() => Name;

}