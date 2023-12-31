using CommonLibrary.Models;

#pragma warning disable CS8618

namespace CommonLibrary.LanguageExtensions;

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
    /// Get all <typeparamref name="T"/> items
    /// </summary>
    /// <param name="sender">CheckedListBox</param>
    /// <returns></returns>
    public static List<CheckedData<T>> IndexList<T>(this CheckedListBox sender) =>
    (
        from item in sender.Items.Cast<T>()
            .Select(
                (model, index) =>
                    new CheckedData<T>
                    {
                        Index = index,
                        Model = model
                    }
            )
            .Where((x) 
                => sender.GetItemChecked(x.Index))
        select item
    ).ToList();

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
    /// Find item, set check state for <see cref="T"/>
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sender">CheckedListBox</param>
    /// <param name="text">text to locate case-insensitive</param>
    /// <param name="checked">set check state to</param>
    public static void SetChecked<T>(this CheckedListBox sender, string text, bool @checked)
    {
        var result = sender.Items.Cast<T>().Select((item, index) => 
            new
            {
                Item = item as IBase, 
                Index = index
            })
            .FirstOrDefault(@this => 
                string.Equals(@this.Item!.Name, text, StringComparison.CurrentCultureIgnoreCase));

        if (result != null)
        {
            sender.SetItemChecked(result.Index, @checked);
        }
    }
}

