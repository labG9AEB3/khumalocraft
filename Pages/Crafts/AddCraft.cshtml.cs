using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using KhumaloCraft.DataLayer;
using KhumaloCraft.Entity;

namespace KhumaloCraft.Pages.Crafts
{
    public class AddCraftModel : PageModel
    {
        public readonly CraftDbContext _context;

        [BindProperty]
        public CraftDetailsEntity CraftData { get; set; }

        public AddCraftModel(CraftDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            byte[] bytes = null;
            if (CraftData.ImageFile != null)
            {
                using (Stream fs = CraftData.ImageFile.OpenReadStream())
                {
                    using (BinaryReader br = new BinaryReader(fs))
                    {
                        bytes = br.ReadBytes((Int32)fs.Length);
                    }
                }
                CraftData.CraftData=Convert.ToBase64String(bytes,0,bytes.Length);
            }
            _context.CraftDetails.Add(CraftData);
            _context.SaveChanges(); 
            return RedirectToPage("./Index");
        }
    }
}
