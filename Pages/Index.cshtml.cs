using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Runtime.InteropServices;

namespace dotnetcoresample.Pages;

public class IndexModel : PageModel
{

    public string OSVersion { get { return RuntimeInformation.OSDescription; }  }
    
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {        
    }
}

namespace YourNamespace.Controllers
{
    public class FormController : Controller
    {
        // [HttpGet]
        // public IActionResult Index()
        // {
        //     // Return the HTML form to the user
        //     return View();
        // }

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
