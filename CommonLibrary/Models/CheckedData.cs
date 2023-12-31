#pragma warning disable CS8618
namespace CommonLibrary.Models;
public class CheckedData<TModel>
{
    /// <summary>
    /// Model
    /// </summary>
    public TModel Model { get; set; }
    /// <summary>
    /// CheckedListBox index
    /// </summary>
    public int Index { get; set; }
}
