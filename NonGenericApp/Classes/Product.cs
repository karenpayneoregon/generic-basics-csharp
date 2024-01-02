#pragma warning disable CS8618
namespace NonGenericApp.Classes;

public class Product
{
    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public decimal? UnitPrice { get; set; }
    public short? UnitsInStock { get; set; }

    public Product(int id)    
    {
        ProductId = id;
    }

    public Product()
    {
        
    }
    public override string ToString() => ProductName;

    
}