using System;
using System.ComponentModel.DataAnnotations;

namespace AskConsoleApp1.Models;
internal class Person
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required]
    public DateOnly BirthDate { get; set; }
}
