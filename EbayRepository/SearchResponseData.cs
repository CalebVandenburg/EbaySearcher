namespace EbaySearcher.EbayRepository
{
    //all of ebays parameters in searches are encapsulated in arrays in json which makes it weird to interact with throughout the app
    public class SearchResponseData
    {
        public List<FindItemsAdvancedResponse> FindItemsAdvancedResponse { get; set; }
    }
    public class FindItemsAdvancedResponse
    {
        public List<string> ack { get; set; }
        public List<EbaySearchResult> SearchResult { get; set; }
    }
}
