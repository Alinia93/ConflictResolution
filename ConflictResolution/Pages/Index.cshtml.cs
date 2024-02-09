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

        public string Hej = "Alinia";
        public void OnGet()
        {
            int number = 5;
            string name = "Pelle";


        }
    }
}
