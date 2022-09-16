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
        public List<string> ItemId { get; set; }
        public List<string> Title { get; set; }
    }
}
