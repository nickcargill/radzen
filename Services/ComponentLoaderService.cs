
using Destination.Components.Pages.BookingComponents;
using Destination.Components.Pages.ChannelComponents;
using Destination.Components.Pages.PropertyComponents;

public class ComponentLoaderService
{
    private readonly Dictionary<string, Type> _componentMap = new()
    {
        ["properties"] = typeof(Properties),
        ["bookings"] = typeof(Bookings),
        ["channels"] = typeof(Channels),
    };

    public Type GetComponentType(string componentName)
    {
        return _componentMap.TryGetValue(componentName, out var type) 
            ? type 
            : null;
    }
}