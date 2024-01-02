namespace NonGenericApp.Classes;

#pragma warning disable CS8618
public class CompanyItem
{
    public Company Company { get; }
    public int Index { get; }

    public CompanyItem(Company item, int index)
    {
        this.Company = item;
        Index = index;
    }

    public override string ToString()
    {
        return $"{{ Item = {this.Company}, Index = {Index} }}";
    }
}