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

        public void OnPost([FromForm] double num1, [FromForm] double num2, [FromForm] string operation)
        {
            // call the method according to the radio button operation selected.
            // and show the result in the result input.

            if (operation.Equals("Add")) { 

            ViewData["result"] = Calculator.Add(num1, num2);
            }
            else if(operation.Equals("Subtract")) {

                ViewData["result"] = Calculator.Subtract(num1, num2);
            }
            else if (operation.Equals("Multiply"))
            {

                ViewData["result"] = Calculator.Multiply(num1, num2);
            }
            else if (operation.Equals("Divide"))
            {

                ViewData["result"] = Calculator.Divide(num1, num2);
            }

        }
    }
}
