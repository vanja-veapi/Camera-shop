namespace CameraShop.Application.Searches
{
    public class SearchLogsDto : PageSearch
    {
        public DateTime? From { get; set; }
        public DateTime? To { get; set; }
        public string Keyword { get; set; }
    }
}
