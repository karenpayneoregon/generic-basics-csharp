using System.ComponentModel;
using System.Data;
using System.Text.Json;
using CommonLibrary.Classes;
using CommonLibrary.JsonConverters;
using CommonLibrary.Models;
using static System.Net.Mime.MediaTypeNames;

#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type.

// ReSharper disable CoVariantArrayConversion

namespace CommonLibrary.LanguageExtensions;

public static class ListBoxExtensions
{
    /// <summary>
    /// Save unbound items to a file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="FileName">File to save items too</param>
    /// <remarks></remarks>
    public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName)
    {
        File.WriteAllLines(FileName, sender.Cast<string>().Select(Row => Row).ToArray());
    }

    private static readonly JsonSerializerOptions serializerWriteOptions = new()
    {
        WriteIndented = true,
        Converters = { new FixedDecimalJsonConverter() }
    };



    public static void Read<T>(string fileName)
    {
        var json = File.ReadAllText(fileName);
        var jsonOptions = new JsonSerializerOptions();
        jsonOptions.Converters.Add(new QuotedDecimalConverter());
        var root = JsonSerializer.Deserialize<List<T>>(json, jsonOptions);
    }

    public static void SaveToFile<T>(this Control sender, string fileName)
    {
        List<T>? list;
        if (sender.IsComboBox())
        {
            list = (List<T>)((ComboBox)sender).DataSource;
        }
        else if (sender.IsListBox())
        {
            list = (List<T>)((ListBox)sender).DataSource;
        }
        else
        {
            throw new Exception("Control must be a ComboBox or ListBox");
        }

        File.WriteAllText(fileName, JsonSerializer.Serialize(list, serializerWriteOptions));
        
    }

    /// <summary>
    /// Save unbound items to a file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="FileName">File to save items too</param>
    /// <param name="Append">Indicates whether new contents should be appended to existing file</param>
    /// <remarks></remarks>
    public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName, bool Append)
    {
        var Items = sender.Cast<string>().Select(Row => Row).ToList();

        if (Append)
        {
            if (File.Exists(FileName))
            {
                var CurrentFileLines = File.ReadAllLines(FileName).ToList();
                Items.AddRange(CurrentFileLines);
            }
        }

        File.WriteAllLines(FileName, Items.ToArray());

    }
    /// <summary>
    /// Save one column of a bound listbox to a file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="fileName">File to save items too</param>
    /// <param name="columnName">Name of column to write to disk</param>
    /// <remarks></remarks>
    public static void SaveToFile(this ListBox.ObjectCollection sender, string fileName, string columnName)
    {
        File.WriteAllLines(fileName, sender.Cast<DataRowView>().Select(Row => Convert.ToString(Row[columnName])).ToArray()!);
    }

    /// <summary>
    /// Save one column of a bound listbox to a file
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="FileName">File to save items too</param>
    /// <param name="ColumnIndex">Index of column to write to disk</param>
    /// <remarks></remarks>
    public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName, int ColumnIndex)
    {
        File.WriteAllLines(FileName, sender.Cast<DataRowView>().Select(Row => Convert.ToString(Row[ColumnIndex])).ToArray()!);
    }

    public static void LoadFromFile(this ListBox.ObjectCollection sender, string FileName)
    {
        if (File.Exists(FileName))
        {
            sender.AddRange(File.ReadAllLines(FileName));
        }
    }
}