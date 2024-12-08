using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace Personal_Blog.Pages.Contact
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public ContactModel Contact { get; set; } = new ContactModel();

        public bool MessageSent { get; set; }

        public void OnGet()
        {
            // Initialize the Contact property if needed
           
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Process the contact form submission
            // For example, you could send an email, save the message to a database, etc.

            MessageSent = true;
            return Page();
        }
    }

    public class ContactModel
    {
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "Message")]
        public string Message { get; set; }
    }
}
