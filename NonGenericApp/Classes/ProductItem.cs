namespace NonGenericApp.Classes;

#pragma warning disable CS8618
public class ProductItem
{
    public Product Product { get; }
    public int Index { get; }

    public ProductItem(Product item, int index)
    {
        this.Product = item;
        Index = index;
    }

    public override string ToString()
    {
        return $"{{ Item = {this.Product}, Index = {Index} }}";
    }
}