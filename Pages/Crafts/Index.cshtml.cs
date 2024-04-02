using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using KhumaloCraft.DataLayer;
using KhumaloCraft.Entity;

namespace KhumaloCraft.Pages.Crafts
{
    public class IndexModel : PageModel
    {
        private readonly CraftDbContext _context;

        public IndexModel(CraftDbContext context)
        {
            _context = context;
        }

        public IList<CraftDetailsEntity> CraftDetails { get; set; }
        public void OnGet()
        {
            CraftDetails = new List<CraftDetailsEntity>();  
            if (_context.CraftDetails != null)
            {
                CraftDetails = _context.CraftDetails.ToList();
            }
        }
    }
}
