
using System.ComponentModel;
using BindingListJsonSample.Classes;
using BindingListJsonSample.Models;

namespace BindingListJsonSample;

internal partial class Program
{
    private static BindingList<Customer> _customers;
    private static string _fileName => "customers.json";
    static void Main(string[] args)
    {
        var customers = BogusOperations.CustomersList();

        _customers = new BindingList<Customer>(customers);

        _customers.SaveToFile(_fileName);

        _customers.Clear();

        _customers.ReadFromFile(_fileName);

        var table = CreateTable();
        foreach (var cust in customers)
        {
            table.AddRow(cust.Id.ToString(), 
                cust.FirstName, cust.LastName, cust.BirthDay.ToString(), 
                cust.Email, cust.Gender.ToString()!);
        }
 
        AnsiConsole.Write(table);

        Console.ReadLine();
    }

    private static Table CreateTable()
    {
        var table = new Table();
        table.AddColumn("[cyan]Id[/]");
        table.AddColumn("[cyan]First[/]");
        table.AddColumn("[cyan]Last[/]");
        table.AddColumn("[cyan]Birth[/]");
        table.AddColumn("[cyan]Email[/]");
        table.AddColumn("[cyan]Gender[/]");
        table.BorderColor(color: Color.Grey);
        return table;
    }
}