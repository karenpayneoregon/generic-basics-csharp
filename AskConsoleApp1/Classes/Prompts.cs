using System;
using System.Collections.Generic;
using Spectre.Console;
using static System.Globalization.DateTimeFormatInfo;

namespace AskConsoleApp1.Classes
{
    public class Prompts
    {

        public static string GetFirstName() =>
            AnsiConsole.Prompt(
                new TextPrompt<string>("[white]First name[/]?")
                    .PromptStyle("yellow")
                    .AllowEmpty());



        public static string GetLastName() =>
            AnsiConsole.Prompt(
                new TextPrompt<string>("[white]Last name[/]?")
                    .PromptStyle("yellow")
                    .AllowEmpty());


        public static DateOnly? GetBirthDate() =>
            AnsiConsole.Prompt(
                new TextPrompt<DateOnly>("What is your [white]birth date[/]?")
                    .PromptStyle("yellow")
                    .AllowEmpty());




        public static T GetInput<T>(string text) => 
            AnsiConsole.Prompt(new TextPrompt<T>($"[white]{text}[/]?")
                .AllowEmpty()
                .PromptStyle("yellow"));








        /// <summary>
        /// Get an int with validation rather than the default validation message
        /// </summary>
        public static int GetInt() =>
            AnsiConsole.Prompt(
                new TextPrompt<int>("Enter a [green]number[/] between [b]1[/] and [b]10[/]")
                    .PromptStyle("green")
                    .ValidationErrorMessage("[red]That's not a valid age[/]")
                    .Validate(age => age switch
                    {
                        <= 0 => ValidationResult.Error("[red]1 is min value[/]"),
                        >= 10 => ValidationResult.Error("[red]10 is max value[/]"),
                        _ => ValidationResult.Success(),
                    }));

        /// <summary>
        /// Present a list of months which allows one or more months to be selected
        /// Selections are optional by using .Required(false)
        /// </summary>
        /// <returns></returns>
        public static List<string> GetFavoriteMonths() => AnsiConsole.Prompt
        (
            new MultiSelectionPrompt<string>()
                .PageSize(12)
                .Required(false)
                .Title("What are your [cyan]favorite months[/]?")
                .InstructionsText("[grey](Press [yellow]<space>[/] to toggle a month, [yellow]<enter>[/] to accept)[/] or [red]Enter[/] w/o any selections to cancel")
                .AddChoices(CurrentInfo!.MonthNames[..^1])
                .HighlightStyle(new Style(Color.White, Color.Black, Decoration.Invert))
        );

    }
}
