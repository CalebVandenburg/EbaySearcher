using System.Net;
using Newtonsoft.Json;
namespace EbaySearcher.EbayRepository
{
    public class EbayClient
    {
        public async Task<EbaySearchResult> GetEbayItems(string operationName, string serviceVersion, string securityAppName, string responseDataFormat, bool restPayload, int entriesPerPage, string keywords)
        {
            var url = $"https://svcs.ebay.com/services/search/FindingService/v1?OPERATION-NAME={operationName}&SERVICE-VERSION={serviceVersion}&SECURITY-APPNAME={securityAppName}&RESPONSE-DATA-FORMAT={responseDataFormat}&REST-PAYLOAD={restPayload}&paginationInput.entriesPerPage={entriesPerPage}&keywords={keywords}";
            EbaySearchResult searchResult = null;
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            var response = await client.SendAsync(request);
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return searchResult;
        }
    }
}
