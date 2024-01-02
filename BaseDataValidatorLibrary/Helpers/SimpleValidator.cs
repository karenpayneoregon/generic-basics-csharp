using System.ComponentModel.DataAnnotations;

namespace BaseDataValidatorLibrary.Helpers;

/// <summary>
/// Provides an alternate to code in ValidatorLibrary.ValidationHelper.IsValidEntity and Model.Validate
/// </summary>
public static class SimpleValidator
{
    /// <summary>
    /// Validate the model and return a response, which includes any validation messages and an IsValid bit.
    /// </summary>
    public static ValidationResponse Validate(object model)
    {
        var results = new List<ValidationResult>();
        var context = new ValidationContext(model);

        var isValid = Validator.TryValidateObject(model, context, results, true);

        return new ValidationResponse()
        {
            IsValid = isValid,
            Results = results
        };
    }

    /// <summary>
    /// Validate model
    /// </summary>
    /// <param name="model">Class instance to validate</param>
    /// <returns></returns>
    public static bool IsModelValid(object model)
    {
        var response = Validate(model);

        return response.IsValid;
    }
}