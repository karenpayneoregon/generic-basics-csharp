using System.Runtime.CompilerServices;

// ReSharper disable once CheckNamespace
namespace BindingListJsonSample;
internal partial class Program
{
    [ModuleInitializer]
    public static void Init()
    {
        Console.Title = "BindingList generics code sample";
        WindowUtility.SetConsoleWindowPosition(WindowUtility.AnchorWindow.Center);
    }
}
