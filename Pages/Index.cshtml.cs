using EbaySearcher.EbayRepository;
using EbaySearcher.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EbaySearcher.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private EbayClient EbayClient { get; set; }

        public IndexModel(ILogger<IndexModel> logger, EbayClient ebayClient)
        {
            _logger = logger;
            EbayClient = ebayClient;
        }

        public void OnGet()
        {
        }
        public PartialViewResult OnPostSearchAsync([FromForm] SearchFormInput searchInput)
        {

            var results = EbayClient.GetEbayItems("findItemsAdvanced", "1.0.0", "JSON", true, 2, searchInput.Keywords).Result;
            var partialData = Partial("Partials/_EbayItemsList", results);
            return partialData;
        }
        
    }
}