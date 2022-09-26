using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace EbaySearcher.EbayRepository
{
    public class EbaySearchResult
    {
        [JsonProperty("@count")]
        public int Count { get; set; }
        [JsonProperty("item")]
        public List<SearchItem> SearchItems { get; set; }
    }
    public class SearchItem
    {
        public List<string>? ItemId { get; set; }
        public List<string>? Title { get; set; }
        public List<string>? Subtitle { get; set; }
        public List<string>? GalleryURL { get; set; }
        public List<string>? ViewItemURL { get; set; }
        public List<string>? Location { get; set; }
    }
}
