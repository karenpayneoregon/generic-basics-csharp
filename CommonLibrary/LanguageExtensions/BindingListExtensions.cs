using CommonLibrary.JsonConverters;
using System.ComponentModel;
using System.Text.Json;

namespace CommonLibrary.LanguageExtensions;

/// <summary>
/// Not used in the example but think it can be useful in rate cases
/// </summary>
public static class BindingListExtensions
{
    /// <summary>
    /// Add range of <see cref="T"/> with RaiseListChangedEvents turned off while adding items then RaiseListChangedEvents turned back on.
    /// </summary>
    /// <typeparam name="T">Model</typeparam>
    /// <param name="list">List of <see cref="T"/></param>
    /// <param name="data">Add to add</param>
    public static void AddRange<T>(this BindingList<T> list, IEnumerable<T> data)
    {
        if (list is null || data is null)  { return; }

        try
        {
            list.RaiseListChangedEvents = false;
            foreach (T item in data)
            {
                list.Add(item);
            }
        }
        finally
        {
            list.RaiseListChangedEvents = true;
        }
    }

    public static void SaveToFile<T>(this BindingList<T> sender, string FileName)
    {
        File.WriteAllText(FileName, JsonSerializer.Serialize(sender, new JsonSerializerOptions
        {
            WriteIndented = true,
            Converters = { new FixedDecimalJsonConverter() }
        }));
    }

    public static void SaveToFile1<T>(this BindingList<T> sender, string FileName)
    {

        JsonSerializerOptions options = new()
        {
            WriteIndented = true,
            Converters = { new FixedDecimalJsonConverter() }
        };

        File.WriteAllText(FileName, JsonSerializer.Serialize(sender, options));
    }
}