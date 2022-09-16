using EbaySearcher.EbayRepository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EbaySearcher.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            EbayClient ebayClient = new EbayClient();
            var results = ebayClient.GetEbayItems("findItemsAdvanced", "1.0.0", "CalebVan-Advanced-PRD-13c512375-e37d59f6", "JSON", true, 2, "tolkien").Result;
        }
    }
}