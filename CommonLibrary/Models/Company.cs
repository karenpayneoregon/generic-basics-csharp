#pragma warning disable CS8618
namespace CommonLibrary.Models;

public class Company : IBase
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString() => Name;

    // for Bogus
    public Company(int id)
    {
        Id = id;
    }

}