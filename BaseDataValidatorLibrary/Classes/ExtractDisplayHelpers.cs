using System.ComponentModel.DataAnnotations;
using System.Linq.Expressions;
using System.Reflection;
using BaseDataValidatorLibrary.LanguageExtensions;

namespace BaseDataValidatorLibrary.Classes;

public static class ExtractDisplayHelpers
{

    /// <summary>
    /// Generic method to get a value for a property by attribute
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="instance"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    public static T GetAttributeFrom<T>(this object instance, string propertyName) where T : Attribute
    {
        var attrType = typeof(T);
        var property = instance.GetType().GetProperty(propertyName);
        return (T)property?.GetCustomAttributes(attrType, false).First();
    }
    /// <summary>
    /// Return Display name if any
    /// </summary>
    /// <param name="propertyInfo"></param>
    /// <returns></returns>
    public static string TryGetDisplayName(PropertyInfo propertyInfo)
    {
        string result = null;
        try
        {
            var attrs = propertyInfo.GetCustomAttributes(typeof(DisplayAttribute), true);
            if (attrs.Any())
            {
                result = ((DisplayAttribute)attrs[0]).Name;
            }
        }
        catch (Exception)
        {
            //eat the exception
        }
        return result;
    }

    /// <summary>
    /// Return Display prompt if any
    /// </summary>
    /// <param name="propertyInfo"></param>
    /// <returns></returns>
    public static string TryGetDisplayPrompt(PropertyInfo propertyInfo)
    {
        string result = null;
        try
        {
            var attrs = propertyInfo.GetCustomAttributes(typeof(DisplayAttribute), true);
            if (attrs.Any())
            {
                result = ((DisplayAttribute)attrs[0]).Prompt;
            }
        }
        catch (Exception)
        {
            //eat the exception
        }
        return result;
    }

    /// <summary>
    /// PascalCase property name FirstName First Name
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="TV"></typeparam>
    /// <param name="source"></param>
    /// <param name="model"></param>
    /// <returns></returns>
    public static string GetNameForProperty<T, TV>(this T source, Expression<Func<T, TV>> model) where T : class
    {
        Tuple<PropertyInfo, DisplayAttribute> propAndAttr = GetPropAndAttr(model);
        return propAndAttr.Item2?.Name ?? propAndAttr.Item1.Name.SplitPascalCase();
    }
    private static Tuple<PropertyInfo, DisplayAttribute> GetPropAndAttr<T, TV>(Expression<Func<T, TV>> model) where T : class
    {
        var memberEx = (MemberExpression)model.Body;
        if (memberEx is null)
        {
            throw new ArgumentNullException(nameof(model), "You must supply a LINQ expression that is a property.");
        }

        var propInfo = typeof(T).GetProperty(memberEx.Member.Name);
        if (propInfo is null)
        {
            throw new ArgumentNullException(nameof(model), "The member you gave is not a property.");
        }

        var displayAttr = propInfo.GetCustomAttribute<DisplayAttribute>();
        return new Tuple<PropertyInfo, DisplayAttribute>(propInfo, displayAttr);
    }
}