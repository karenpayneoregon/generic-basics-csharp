namespace ValidatorLibrary;

public partial class Model
{
    /// <summary>
    /// Validate entity against validation rules
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="entity"></param>
    /// <returns><see cref="EntityValidationResult"/></returns>
    /// <remarks>
    /// Same as ValidationHelper.IsValidEntity in ValidatorLibrary project
    /// </remarks>
    public static EntityValidationResult Validate<T>(T entity) where T : class 
        => (new EntityValidator<T>()).Validate(entity);
}