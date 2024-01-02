#pragma warning disable CS8618
namespace GenericsWithInterfaceApp.Models;

public class Company
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