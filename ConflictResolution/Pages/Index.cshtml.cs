using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ConflictResolution.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public string Name { get; set; }
        public void OnGet()
        {
            int id = 1;
        }
    }
}
