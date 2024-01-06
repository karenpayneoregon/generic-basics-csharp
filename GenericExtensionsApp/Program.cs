using GenericExtensionsApp.Classes;

namespace GenericExtensionsApp;

internal partial class Program
{
    static void Main(string[] args)
    {
        List<ValueType> list = [1, 12.34, 14.39, 12.56f];

        foreach (var valueType in list)
        {
            Utilities.Decide(valueType);
        }
        SpectreConsoleHelpers.ExitPrompt();
    }
}