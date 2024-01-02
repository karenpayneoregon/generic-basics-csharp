using System.ComponentModel.DataAnnotations;
// ReSharper disable ConvertConstructorToMemberInitializers

namespace BaseDataValidatorLibrary.Helpers;

/// <summary>
/// Helper for <see cref="SimpleValidator"/>
/// </summary>
public class ValidationResponse
{
    public List<ValidationResult> Results { get; set; }
    public bool IsValid { get; set; }

    public ValidationResponse()
    {
        Results = new List<ValidationResult>();
        IsValid = false;
    }
}