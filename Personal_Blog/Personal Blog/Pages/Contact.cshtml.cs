using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Personal_Blog.Pages
{
    public class ContactModel : PageModel
    {
        [BindProperty]
        public string Name { get; set; }

        [BindProperty]
        public string Email { get; set; }

        [BindProperty]
        public string Message { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            // Handle the form submission logic here
            // For example, send the message via email or store it in a database
            // After handling, redirect to a confirmation page or display a success message

            return RedirectToPage("ContactConfirmation");
        }
    }
}