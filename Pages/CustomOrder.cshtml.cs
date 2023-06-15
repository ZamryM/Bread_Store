using BreadStore.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BreadStore.Pages
{
    public class CustomOrderModel : PageModel
    {
        [BindProperty]
        public BreadModel Bread { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            return RedirectToPage("/ThankYou", new {Bread.BreadName,Bread.ImageName,Bread.BreadSize});
        }
    }
}
