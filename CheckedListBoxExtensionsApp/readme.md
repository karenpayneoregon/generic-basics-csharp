# About


Example for selecting checked items in a CheckedListBox where data is a list of a model.

Notes 

- **Form1** That `CheckedListBoxExtensionsApp1` project has code to remove an item from the DataGridView on un-check in the CheckedListBox.
- **Form2** example to move companies from a CheckedListBox to a ListBox
- **Form3** example to move products from a CheckedListBox to a ListBox

```csharp
public static class CheckedListBoxExtensions
{
    /// <summary>
    /// Get checked items as <see cref="T"/>
    /// </summary>
    /// <typeparam name="T">Model</typeparam>
    /// <param name="sender">CheckedListBox</param>
    /// <returns>List if one or more items are checked</returns>
    public static List<T> CheckedList<T>(this CheckedListBox sender)
        => sender.Items.Cast<T>()
            .Where((item, index) => sender.GetItemChecked(index))
            .Select(item => item)
            .ToList();

    /// <summary>
    /// Uncheck all items
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    public static void UnCheckAll(this CheckedListBox sender)
    {
        foreach (int index in sender.CheckedIndices)
        {
            sender.SetItemCheckState(index, CheckState.Unchecked);
        }
    }

    /// <summary>
    /// Get all <typeparamref name="TModel"/> items
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    /// <returns></returns>
    public static List<CheckedData<TModel>> IndexList<TModel>(this CheckedListBox sender) =>
    (
        from item in sender.Items.Cast<TModel>()
            .Select(
                (model, index) =>
                    new CheckedData<TModel>
                    {
                        Index = index,
                        Model = model
                    }
            )
            .Where((x) => sender.GetItemChecked(x.Index))
        select item
    ).ToList();
}
```

**Model**

`TModel` in this case of type `Company` while since the property `Model` is generic a developer can use any class/model.

```csharp
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
```
