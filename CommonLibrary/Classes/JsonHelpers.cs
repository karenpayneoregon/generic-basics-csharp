using System.Text.Json;

namespace CommonLibrary.Classes;

public class JsonHelpers
{
    private static readonly JsonSerializerOptions _options = new(JsonSerializerDefaults.Web)
    {
        WriteIndented = true
    };

    /// <summary>
    /// Read json from string with converter for reading decimal from string
    /// </summary>
    /// <typeparam name="T">Type to convert</typeparam>
    /// <param name="json">valid json string for <see cref="T"/></param>
    public static List<T>? Deserialize<T>(string json)
    {
        return JsonSerializer.Deserialize<List<T>>(json, _options);
    }
}





