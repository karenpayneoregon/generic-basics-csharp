namespace GenericExtensionsApp.Classes;
internal class Utilities
{
    public static void Decide(ValueType? sender)
    {
        if (sender is int number1)
        {
            AnsiConsole.MarkupLine($"    [cyan]int[/] Value {sender,-10}" +
                                   $"{number1.GetFractionalPart1(),-5:D2}" +
                                   $"{number1.GetFractionalPart2(),-5:d2}" +
                                   $"{number1.GetFractionalPart(2),-5:f2}");
        }
        else if (sender is long number2)
        {
            AnsiConsole.MarkupLine($" [cyan]long[/] Value {sender,-10}" +
                                   $"{number2.GetFractionalPart1(),-5}" +
                                   $"{number2.GetFractionalPart2(),-5}" +
                                   $"{number2.GetFractionalPart(2)}");
        }
        else if (sender is decimal number3)
        {
            AnsiConsole.MarkupLine($" [cyan]decimal[/] Value {sender,-10}" +
                                   $"{number3.GetFractionalPart1(),-5}" +
                                   $"{number3.GetFractionalPart2(),-5}" +
                                   $"{number3.GetFractionalPart(2)}");
        }
        else if (sender is float number4)
        {
            AnsiConsole.MarkupLine($"  [cyan]float[/] Value {sender,-10}" +
                                   $"{number4.GetFractionalPart1(),-5}" +
                                   $"{number4.GetFractionalPart2(),-5}" +
                                   $"{number4.GetFractionalPart(2)}");
        }
        else if (sender is double number5)
        {
            AnsiConsole.MarkupLine($" [cyan]double[/] Value {sender,-10}" +
                                   $"{number5.GetFractionalPart1(),-5}" +
                                   $"{number5.GetFractionalPart2(),-5}" +
                                   $"{number5.GetFractionalPart(2)}");
        }
        else if (sender == null)
        {
            AnsiConsole.MarkupLine("[white]val[/] is a nullable type with the null value");
        }
        else
        {
            Console.WriteLine($"[red]Could not convert[/] [white]{sender}[/]");
        }
    }
}
