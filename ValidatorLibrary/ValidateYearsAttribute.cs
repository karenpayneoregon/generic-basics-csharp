using System.ComponentModel.DataAnnotations;
#pragma warning disable CS8765 // Nullability of type of parameter doesn't match overridden member (possibly because of nullability attributes).

namespace ValidatorLibrary;

/// <summary>
/// Validate year only of a <see cref="DateOnly"/>
/// </summary>

[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
public class ValidateYearsAttribute : ValidationAttribute
{

    public readonly DateOnly MinValue = DateOnly.FromDateTime(DateTime.Now.AddYears(-100));
    public readonly DateOnly MaxValue = DateOnly.FromDateTime(DateTime.Now);

    /// <summary>
    ///  Override of <see cref="ValidationAttribute.IsValid(object)" />
    /// </summary>
    public override bool IsValid(object sender)
    {
        var value = (DateOnly)sender;
        return value.Year >= MinValue.Year && value.Year <= MaxValue.Year;
    }


    public override string FormatErrorMessage(string name)
    {
        if (ErrorMessage is null && ErrorMessageResourceName is null)
        {
            ErrorMessage = "value is unacceptable";
        }

        return $"{name} must be greater than {MinValue} and not passed {MaxValue}";

    }
}
