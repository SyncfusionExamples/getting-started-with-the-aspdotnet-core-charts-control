using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mycoreproject.Pages
{
    public class LayoutData
    {
        public string? Period { get; set; }
        public double? OnlinePercentage { get; set; }
        public double? RetailPercentage { get; set; }
    }
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
