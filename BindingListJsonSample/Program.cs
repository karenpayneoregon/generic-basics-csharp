
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using BindingListJsonSample.Classes;
using BindingListJsonSample.Models;

namespace BindingListJsonSample;

internal partial class Program
{
    #region Properties that would normally be needed in a class rather than one method

    private static BindingList<Customer> _customers;
    private static string _fileName => "customers.json";

    #endregion

    static void Main(string[] args)
    {

        var customers = BogusOperations.CustomersList();

        _customers = new BindingList<Customer>(customers);
        _customers.ListChanged += _customers_ListChanged;

        _customers.SaveToFile(_fileName);

        _customers.Clear();

        _customers.ReadFromFile(_fileName);

        var customer =_customers.AddNew();
        customer.Id = 11;
        customer.FirstName = "Karen";
        customer.LastName = "Payne";
        customer.BirthDay = new DateOnly(1980, 1, 1);
        customer.Email = "pain@pain.com";
        customer.Gender = Gender.Female;

        // edit new Customer
        customer.BirthDay = new DateOnly(1956, 9, 24);

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

    private static void _customers_ListChanged(object sender, ListChangedEventArgs e)
    {
        
        if (e.ListChangedType == ListChangedType.ItemChanged)
        {
            var current = _customers[e.NewIndex];
            AnsiConsole.MarkupLine($"[green]Changed on property[/] [cyan]{e.PropertyDescriptor.Name,-10}[/] " +
                                   $"[magenta3_2]{e.PropertyDescriptor.GetValue(current)}[/]");
        }
        else if (e.ListChangedType == ListChangedType.ItemAdded)
        {
            AnsiConsole.MarkupLine($"[yellow]New Customer[/]");
        }else if (e.ListChangedType == ListChangedType.Reset)
        {
            AnsiConsole.MarkupLine($"[red]Reset[/]");
        }
        
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