using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Assignment2.Models;

namespace Assignment2.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public PersonModel? Person { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Index OnGet");

            if (Person is not null)
            {
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }

        public IActionResult OnPost()
        {
            _logger.LogInformation("Index OnPost");

            if (Person is not null)
            {
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");

                TempData["Name"] = Person.Name;
                TempData["Age"] = Person.Age.ToString();
            }

            // Redirect using GET (TempData passes the data)
            return RedirectToPage("/Privacy");
        }
    }
}

