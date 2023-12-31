# About

This Visual Studio solution is about reuse of code in a class project along with working with generic methods and extension methods. Who is the target audience? All levels of developers but more directed at novice developers because in many cases they do not take time to read documentation and learn best practices for coding.

## Why Windows Forms

If a web project were used this does not help a desktop developer but a web developer can learn how to use generics and if a console project were used it gets complicated, a menu would need to be created possibly with sub menus which takes to long for the time I wanted to devote to this code.

## ASP.NET Core/Razor pages

Let's look at an example for generics. The follow code are extension methods for working with temp data using the same idea done in Window Forms.

```csharp
public static class TempDataHelper
{
    /// <summary>
    /// Put an item into TempData
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    /// <param name="sender">TempData</param>
    /// <param name="key">Used to retrieve value with <see cref="Get{T}"/> </param>
    /// <param name="value">Value to store</param>
    public static void Put<T>(this ITempDataDictionary sender, string key, T value) where T : class
    {
        sender[key] = JsonConvert.SerializeObject(value);
    }
    /// <summary>
    /// Get value by key in TempData
    /// </summary>
    /// <typeparam name="T">Item type</typeparam>
    /// <param name="sender">TempData</param>
    /// <param name="key">Used to retrieve value</param>
    /// <returns>Item</returns>
    public static T Get<T>(this ITempDataDictionary sender, string key) where T : class
    {
        sender.TryGetValue(key, out var unknown);
        return unknown == null ? null : JsonConvert.DeserializeObject<T>((string)unknown);
    }
}
```

**Simple Usage**

```csharp
public void OnGet()
{
    Message = "";
    if (TempData.Count == 1 && TempData.ContainsKey("container"))
    {
        Message = TempData.Get<string>("container");
        TempData.Clear();
    }
}
public class OtherPageModel : PageModel
{
    public void OnGet()
    {
        TempData.Put("container", "Back from Other page");
    }
}
```

Hopefully the point is made that generics can be used in any project type.


## Requires

- Microsoft Visual Studio 2022 edition 17.8.x
- NET8 Framework installed

## NuGet packages
- [Bogus](https://www.nuget.org/packages/Bogus/34.0.2?_src=template) for generation data used to populate various controls
- [ObjectSumper.NET](https://www.nuget.org/packages/ObjectDumper.NET/4.1.3?_src=template) for dumping the contents of a list

## Separating of responsibility

In all the frontend projects only necessary code in placed in a form while any code that can be abstracted to a class with specific intent is done. For example, a novice developer will be tasked with writing the contents of a list box to a file, they will write the code in a button click event. A better path is to write a method in a class as shown below.

```csharp
public static void SaveToFile(this ListBox.ObjectCollection sender, string FileName)
{
    File.WriteAllLines(FileName, sender.Cast<string>().Select(Row => Row).ToArray());
}
```

:stop_sign: See the problem with the above method? We are passing a control, a better method is to use a BindingList&lt;T> to set the DataSource of the control write as json (we could also write comma-delimited also).

```csharp
public static void SaveToFile<T>(this BindingList<T> sender, string FileName)
{
    File.WriteAllText(FileName, JsonSerializer.Serialize(sender, new JsonSerializerOptions
    {
        WriteIndented = true,
        Converters = { new FixedDecimalJsonConverter() }
    }));
}
```

:heavy_check_mark: Now only the data is passed to the method which is a lighter load, on what is needed is passed.

> **Note**
> In ListBoxExtensions class there are the above and several other iterations for writing to a file in the event the reader does not care for the last method shown.


## CheckedListBox

Over the years of answering questions on forums, questions arise for how to get checked items, check/uncheck items. So the class CheckedListBox contains generic extension methods, for example how to get checked items from a CheckedListBox that has the DataSource load with a known model.

**Usage**

```csharp
List<Company> result = CompaniesCheckedListBox.CheckedList<Company>();
```

**Extension method**

```csharp
public static List<T> CheckedList<T>(this CheckedListBox sender)
    => sender.Items.Cast<T>()
        .Where((item, index) => sender.GetItemChecked(index))
        .Select(item => item)
        .ToList();
```


## Extension method and generics

Using extension methods has many benefits, for example using extension methods all for method based code, no different than a Framework extension such as .FirstOrDefault which is the reasoning behind the code presented. Do not like extension methods, they can be called as a normal method call and note that some Visual Studio extensions will prompt to use them as extension methods which can be stopped by remove “this” key word from the method signature.

## Using breakpoints

If something does not make sense, set a [breakpoint](https://learn.microsoft.com/en-us/visualstudio/debugger/using-breakpoints?view=vs-2022) and traverse the code and/or use Visual Studio output and local windows to examine results of a method call results of the value of a variable.

