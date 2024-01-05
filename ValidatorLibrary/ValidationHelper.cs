
using System.ComponentModel.DataAnnotations;

#pragma warning disable CS8619 // Nullability of reference types in value doesn't match target type.
#pragma warning disable CS8601 // Possible null reference assignment.

namespace ValidatorLibrary;

public class ValidationHelper
{
    /// <summary>
    /// Validate entity against validation rules
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static EntityValidationResult ValidateEntity<T>(T entity) where T : class 
        => (new EntityValidator<T>()).Validate(entity);

    /// <summary>
    /// Assert entity is valid against data annotated properties
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <returns></returns>
    public static (bool success, List<ErrorContainer> container) IsValidEntity<T>(T entity) where T : class
    {
        List<ErrorContainer> list = new();

        var result = ValidateEntity(entity);

        if (result.IsNotValid)
        {
            if (result.Errors.Count == 1)
            {
                
                list.Add(new ErrorContainer()
                {
                    Name = result.Errors.FirstOrDefault()!.MemberNames.FirstOrDefault(),
                    Description = result.Errors.FirstOrDefault()!.ErrorMessage
                });

                return (false, list);
            }
            else
            {
                foreach (ValidationResult resultError in result.Errors)
                {
                    list.Add(new ErrorContainer()
                    {
                        Name = resultError.MemberNames.FirstOrDefault(),
                        Description = resultError.ErrorMessage
                    });
                }

                return (false,list);
            }

        }
        else
        {
            return (true, null);
        }
    }
}