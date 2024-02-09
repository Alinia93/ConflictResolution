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

<<<<<<< HEAD
        public string Name { get; set; }
        public void OnGet()
        {
            int id = 1;
=======
        public string Hej = "Alinia";
        public void OnGet()
        {
            int number = 5;
            string name = "Pelle";


>>>>>>> ad137042ac063ee52d13ff097c6ca1efbcf146e1
        }
    }
}
