using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using Assignment2.Models;

namespace Assignment2.Pages
{
    public class PrivacyModel : PageModel
    {
        public PersonModel? Person { get; set; }

        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            _logger.LogInformation("Privacy OnGet");

            if (TempData["Name"] is string name &&
                TempData["Age"] is string ageStr &&
                int.TryParse(ageStr, out int age))
            {
                Person = new PersonModel
                {
                    Name = name,
                    Age = age
                };

                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }

        public void OnPost()
        {
            _logger.LogInformation("Privacy OnPost");

            if (Person is not null)
            {
                _logger.LogInformation($"Name={Person.Name}");
                _logger.LogInformation($"Age={Person.Age}");
            }
        }
    }
}
