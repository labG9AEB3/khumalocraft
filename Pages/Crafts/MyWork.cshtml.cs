using KhumaloCraft.DataLayer;
using KhumaloCraft.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;


namespace KhumaloCraft.Pages.Crafts
{
    public class MyWorkModel : PageModel
    {
        private readonly CraftDbContext _context;

        public MyWorkModel(CraftDbContext context)
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
