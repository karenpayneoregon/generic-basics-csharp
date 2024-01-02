
using Bogus;
using NonGenericApp.Classes;

namespace CheckedListBoxExtensionsApp.Classes;

public class BogusOperations 
{
    /// <summary>
    /// Generate a list of <see cref="Company"/> which defaults to 15 unless a value is passed
    /// </summary>
    /// <param name="count">How many items to generate</param>
    public static List<Company> Companies(int count = 15)
    {
        int identifier = 1;

        Faker<Company> fake = new Faker<Company>()
                .CustomInstantiator(f => new Company(identifier++))
                .RuleFor(c => c.Name, f => f.Company.CompanyName());

        return fake.Generate(count).OrderBy(c => c.Name).ToList();

    }
    /// <summary>
    /// Generate a list of <see cref="Product"/> which defaults to 10 unless a value is passed
    /// </summary>
    /// <param name="count">How many items to generate</param>
    /// <returns></returns>
    public static List<Product> Products(int count = 10)
    {
        int identifier = 1;
        Faker<Product> fake = new Faker<Product>()
            .CustomInstantiator(f => new Product(identifier++))
            .RuleFor(p => p.ProductName, f => f.Commerce.ProductName())
            .RuleFor(p => p.UnitPrice, f => f.Random.Decimal(10, 45))
            .RuleFor(p => p.UnitsInStock, f => f.Random.Short(1, 5));

        return fake.Generate(count).OrderBy(p => p.ProductName).ToList();
    }
}