#pragma warning disable CS8618
namespace NonGenericApp.Classes;

public class Company
{
    public int Id { get; set; }
    public string Name { get; set; }
    public override string ToString() => Name;

    public Company()
    {
        
    }
    // for Bogus
    public Company(int id)
    {
        Id = id;
    }

}