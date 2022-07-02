namespace NGCOREAPP.Models
{
    public class Link
    {
        public string LongUrl { get; set; } = "";
        public string ShortUrl { get; set; } = "";
        public int ClickCount { get; set; } = 0;
        public int ClickLimit { get; set; } = 5;
    }
}
