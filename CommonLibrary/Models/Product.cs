#pragma warning disable CS8618
using System.Text.Json.Serialization;

namespace CommonLibrary.Models;

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