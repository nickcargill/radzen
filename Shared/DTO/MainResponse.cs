namespace Destination.Shared.DTO
{
    public static class MainResponse
    {
        public class PagedResult<T>
        {
            public List<T> Items { get; set; }
            public int Count { get; set; }
        }
    }
}
