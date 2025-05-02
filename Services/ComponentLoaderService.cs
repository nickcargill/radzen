
using Destination.Components.Pages;

public class ComponentLoaderService
{
    private readonly Dictionary<string, Type> _componentMap = new()
    {
        ["properties"] = typeof(Properties),
    };

    public Type GetComponentType(string componentName)
    {
        return _componentMap.TryGetValue(componentName, out var type) 
            ? type 
            : null;
    }
}