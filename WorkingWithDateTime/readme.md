# About

For this Visual Studio solution, shows how to use temp data using two generic language extension methods in the class project RazorLibrary.

Without these two extension methods each time a container needs to pass information a developer needs to create a Put and Get for each type.


> **Note**
> Provides examples for showing DateTime and TimeOnly in various formats.

```csharp
public static class TempDataHelper
{
    public static void Put<T>(this ITempDataDictionary sender, string key, T value) where T : class
    {
        sender[key] = JsonConvert.SerializeObject(value);
    }
    public static T Get<T>(this ITempDataDictionary sender, string key) where T : class
    {
        sender.TryGetValue(key, out var unknown);
        return unknown == null ? null : JsonConvert.DeserializeObject<T>((string)unknown);
    }
}

```

# Requires

RazorLibrary in this solution for working with TempData.
