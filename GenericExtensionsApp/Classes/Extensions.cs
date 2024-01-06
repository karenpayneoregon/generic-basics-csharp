using System.Globalization;
using System.Numerics;

namespace GenericExtensionsApp.Classes;
public static class Extensions
{
    // Get fractional part of a number as an integer
    public static int GetFractionalPart1<T>(this T sender) where T : INumber<T>
    {
        int value = (int)(decimal.CreateChecked(sender) % 1 * 100);
        return int.IsNegative(value) ? value.Invert() : value;
    }

    // Get fractional part of a number as an integer
    public static int GetFractionalPart2<T>(this T sender) where T : INumber<T>
    {
        var value = Convert.ToInt32((decimal.CreateChecked(sender) % 1).ToString(CultureInfo.InvariantCulture).Replace("0.", ""));
        return int.IsNegative(value) ? value.Invert() : value;
    }

    // Get fractional part of a number as an integer
    public static int GetFractionalPart3<T>(this T sender) where T : INumber<T>
    {
        var value = int.Parse((decimal.CreateChecked(sender) % 1).ToString(CultureInfo.InvariantCulture).Replace("0.", ""));
        return int.IsNegative(value) ? value.Invert() : value;
    }


    // Get fractional part of a number as a decimal
    public static decimal GetFractionalPart<T>(this T sender, int places) where T : INumber<T>
        => Math.Round(decimal.CreateChecked(sender) - Math.Truncate(decimal.CreateChecked(sender)), places);

    public static T Invert<T>(this T source) where T : INumber<T>
        => -source;
}