# About

An example for obtaining the selected RadioButton in a group box.

## Descendants

In the CommonLibrary.ControlHelpers class there is a base method shown below to get all controls of a specfic type in a form or a specific control like a panel or group-box.

```csharp
public static IEnumerable<T> Descendants<T>(this Control control) where T : class
{
    foreach (Control child in control.Controls)
    {
        if (child is T thisControl)
        {
            yield return (T)thisControl;
        }

        if (child.HasChildren)
        {
            foreach (T descendant in Descendants<T>(child))
            {
                yield return descendant;
            }
        }
    }
}
```

To make life easier there are several methods that use Descendants in the same class. For instance to get all buttons on a form and also in child conrol such as panels and group-boxes use the followin extension method.

```csharp
public static List<Button> ButtonList(this Control control) 
    => control.Descendants<Button>().ToList();
```

Usage

```csharp
var buttons = this.ButtonList()l
```

The lesson here is to learn to use generics.