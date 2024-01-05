using System;
using System.ComponentModel.DataAnnotations;
using ValidatorLibrary;

namespace AskConsoleApp1.Models;
internal class Person
{
    [Required]
    public string FirstName { get; set; }
    [Required]
    public string LastName { get; set; }
    [Required(ErrorMessage = "{0} is required")]

    [ValidateYears]
    public DateOnly BirthDate { get; set; }


}
