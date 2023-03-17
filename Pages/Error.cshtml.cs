using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace dotnetcoresample.Pages;

[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
[IgnoreAntiforgeryToken]
public class ErrorModel : PageModel
{
    public string? RequestId { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    private readonly ILogger<ErrorModel> _logger;

    public ErrorModel(ILogger<ErrorModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier;
    }
}

namespace YourNamespace.Controllers
{
    public class FormController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            // Return the HTML form to the user
            return View();
        }

        [HttpPost]
        public IActionResult SubmitForm(string name, string email)
        {
            // Here, you can write your code to handle the form submission.
            // You can access the form data through the 'name' and 'email' parameters.
            // For example, you could save the data to a database or send an email.

            // After handling the form submission, you can return a response to the user.
            return Content("Thanks for submitting the form!");
        }
    }
}