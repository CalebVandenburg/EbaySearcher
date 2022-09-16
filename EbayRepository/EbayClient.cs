using System.Net;
using Newtonsoft.Json;
namespace EbaySearcher.EbayRepository
{
    public class EbayClient
    {
        private string AppID;
        private string DevID;
        private string CertID;
        public EbayClient(string AppID, string DevID, string CertID)
        {
            this.AppID = AppID;
            this.DevID = DevID;
            this.CertID = CertID;
        }
        public async Task<SearchResponseData> GetEbayItems(string operationName, string serviceVersion, string responseDataFormat, bool restPayload, int entriesPerPage, string keywords)
        {
            var url = $"https://svcs.ebay.com/services/search/FindingService/v1?OPERATION-NAME={operationName}&SERVICE-VERSION={serviceVersion}&SECURITY-APPNAME={AppID}&RESPONSE-DATA-FORMAT={responseDataFormat}&REST-PAYLOAD={restPayload}&paginationInput.entriesPerPage={entriesPerPage}&keywords={keywords}";
            SearchResponseData searchResult = null;
            HttpClient client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri(url),
            };

            var response = await client.SendAsync(request);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            searchResult = JsonConvert.DeserializeObject<SearchResponseData>(responseBody);
            return searchResult;
        }
    }
}
