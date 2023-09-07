using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VRBike.Models;

namespace VRBike.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly VRBike.Data.VRBikeContext _context;

        public string DistanzaSort { get; set; }
        public string SalitaSort { get; set; }
        public string DifficultySort { get; set; }
        
        public string PageTitleSort { get; set; }
        public string CurrentSort { get; set; }
        public string CurrentFilter { get; set; }


        public IndexModel(VRBike.Data.VRBikeContext context,ILogger<IndexModel> logger)
        {
            _logger = logger;
            _context = context;
        }

        public IList<Tour> Tours { get; set; } = default!;

        public async Task OnGetAsync(string sortOrder, string searchString, string currentFilter)
        {
            PageTitleSort = sortOrder == "PageTitle" ? "pageTitle_desc" : "PageTitle";
            DistanzaSort = sortOrder == "Distanza" ? "distanza_desc" : "Distanza";
            SalitaSort = sortOrder == "Salita" ? "salita_desc" : "Salita";
            DifficultySort = sortOrder == "Difficulty" ? "difficulty_desc" : "Difficulty";

            if (searchString != null)
            {
               // pageIndex = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            CurrentFilter = searchString;

            if (_context.Tours != null)
            {
                IQueryable<Tour> tourIQ = from t in _context.Tours
                                          .Include(m => m.TourMarkers)
                                          select t;

                if (!String.IsNullOrEmpty(searchString))
                {
                    tourIQ = tourIQ.Where(s => s.Percorso.Contains(searchString)
                    || s.PageTitle.Contains(searchString)
                    || s.Raccolta.Contains(searchString)
                    || s.Difficulty.Contains(searchString)
                    );
                };

              
                switch (sortOrder)
                {
                    case "PageTitle":
                        tourIQ = tourIQ.OrderBy(t => t.PageTitle); break;
                    case "pageTitle_desc":
                        tourIQ = tourIQ.OrderByDescending(t => t.PageTitle); break;
                    case "Distanza":
                        tourIQ = tourIQ.OrderBy(t => t.Distanza); break;
                    case "distanza_desc":
                        tourIQ = tourIQ.OrderByDescending(t => t.Distanza); break;
                    case "Salita":
                        tourIQ = tourIQ.OrderBy(t => t.Salita); break;
                    case "salita_desc":
                        tourIQ = tourIQ.OrderByDescending(t => t.Salita); break;
                    case "Difficulty":
                        tourIQ = tourIQ.OrderBy(t => t.Difficulty); break;
                    case "difficulty_desc":
                        tourIQ = tourIQ.OrderByDescending(t => t.Difficulty); break;
                    default:
                        tourIQ = tourIQ.OrderBy(t => t.PageTitle); break;

                }



                Tours = await tourIQ.AsNoTracking().ToListAsync();
            }
        }
    }
}