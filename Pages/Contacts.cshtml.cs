using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KhumaloCraft.Pages
{
    public class ContactsModel : PageModel
    {
        [BindProperty]
        [Required (ErrorMessage ="The email-address is required")]
        public string email { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage ="The First is required")]
        public string firstName { get; set; } = "";
        [BindProperty]
        [Required(ErrorMessage = "The Last is required")]
        public string lastName { get; set; } = "";
        [BindProperty]
        public string? phone { get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "The Subject is required")]
        public string subject {  get; set; } = "";

        [BindProperty]
        [Required(ErrorMessage = "The Message is required")]
        public string message { get; set; } = "";

        public void OnGet()
        {
        }

        public string successmessage = "";
        public string errormessage = "";

        public void OnPost() 
        { 
            if(!ModelState.IsValid)
            {
                errormessage = "Data Validation Failed";
                return;
            }
            successmessage = "Your message has been received correctly";

            firstName=string.Empty; lastName=string.Empty;
            email = string.Empty; subject = string.Empty; message= string.Empty; phone = string.Empty;

            ModelState.Clear();
        }
    }
}
