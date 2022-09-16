namespace EbaySearcher.EbayRepository
{
    public class EbaySearchResults
    {
        public string ACK { get; set; }
        public List<EbaySearchResult> results { get; set; }
    }
    public class EbaySearchResult
    {
        public int ItemId  { get; set; }
        public string Title { get; set; }
    }
}
