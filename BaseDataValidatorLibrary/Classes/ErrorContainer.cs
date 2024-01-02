namespace BaseDataValidatorLibrary.Classes;

public class ErrorContainer
{
    public string Name { get; set; }
    public string Description { get; set; }
    public override string ToString() => Name;

}