using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CalculatorLibrary;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorWebApp.Pages
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

        }

        public void OnPost([FromForm]double num1,[FromForm] double num2)
        {
            // call the method according to the radio button selected.

            
            ViewData["result"] = CalculatorLibrary.Calculator.Add(num1, num2);

            // and show the result in the result input.



        }
    }
}
