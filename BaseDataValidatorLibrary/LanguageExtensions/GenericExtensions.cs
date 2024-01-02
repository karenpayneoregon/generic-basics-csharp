namespace BaseDataValidatorLibrary.LanguageExtensions;

public static class GenericExtensions
{
    /// <summary>
    /// Determine if a value is within a specified range
    /// </summary>
    /// <typeparam name="T">type</typeparam>
    /// <param name="value">value to determine if between lowerValue and upperValue</param>
    /// <param name="lowerValue">lower value</param>
    /// <param name="upperValue">upper value</param>
    /// <returns>bool</returns>
    public static bool Between<T>(this T value, T lowerValue, T upperValue) where T : struct, IComparable<T>
        => Comparer<T>.Default.Compare(value, lowerValue) >= 0 &&
           Comparer<T>.Default.Compare(value, upperValue) <= 0;
}