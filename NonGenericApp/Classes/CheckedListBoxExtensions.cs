#pragma warning disable CS8618

namespace NonGenericApp.Classes;

public static class CheckedListBoxExtensions
{
    /// <summary>
    /// Get checked items as <see cref="Company"/>
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    /// <returns>List if one or more items are checked</returns>
    public static List<Company> CheckedCompanies(this CheckedListBox sender)
        => sender.Items.Cast<Company>()
            .Where(( _ , index) => sender.GetItemChecked(index))
            .Select(item => item)
            .ToList();


    /// <summary>
    /// Get checked items as <see cref="Product"/>
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    /// <returns>List if one or more items are checked</returns>
    public static List<Product> CheckedProducts(this CheckedListBox sender)
    => sender.Items.Cast<Product>()
        .Where((item, index) => sender.GetItemChecked(index))
        .Select(item => item)
        .ToList();


    public static void CheckCurrentCompany(this CheckedListBox sender, string text, bool @checked)
    {
        var result = sender.Items.Cast<Company>().Select((item, index) => 
            new CompanyItem(item, index))
            .FirstOrDefault(x => string.Equals(x.Company.Name, text, StringComparison.CurrentCultureIgnoreCase));

        if (result != null)
        {
            sender.SetItemChecked(result.Index, @checked);
        }
    }

    public static void CheckCurrentProduct(this CheckedListBox sender, string text, bool @checked)
    {
        var result = sender.Items.Cast<Product>().Select((item, index) =>
                new ProductItem(item, index))
            .FirstOrDefault(x => string.Equals(x.Product.ProductName, text, StringComparison.CurrentCultureIgnoreCase));

        if (result != null)
        {
            sender.SetItemChecked(result.Index, @checked);
        }
    }
}