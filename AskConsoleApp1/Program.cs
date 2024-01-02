using System;
using static BaseDataValidatorLibrary.Helpers.ValidationHelper;
using AskConsoleApp1.Classes;
using AskConsoleApp1.Models;
using Spectre.Console;

namespace AskConsoleApp1;

partial class Program
{
    static void Main(string[] args)
    {

        var firstName = Prompts.GetInput<string>("First name");
        var lastName = Prompts.GetInput<string>("Last name");
        var birthDate = Prompts.GetInput<DateOnly>("Birth date");
        Person person = new Person() { FirstName = firstName, LastName = lastName, BirthDate = birthDate };
        var (success, container) = IsValidEntity(person);
        if (success)
        {
            AnsiConsole.MarkupLine("[yellow]Valid person");
        }
        else
        {
            foreach (var errorContainer in container)
            {
                Console.WriteLine(errorContainer.Description);
            }
        }
        AnsiConsole.MarkupLine("[white]Press ENTER to quit[/]");
        Console.ReadLine();
    }

    
}