using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Tours
{
    public class IndexModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public string DistanzaSort { get; set; }
        public string SalitaSort { get; set; }
        public string PageTitleSort { get; set; }
        public string CurrentSort { get; set; }

        public IndexModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        public IList<Tour> Tours { get;set; } = default!;

        public async Task OnGetAsync(string sortOrder)
        {
            PageTitleSort = sortOrder == "PageTitle" ? "pageTitle_desc" : "PageTitle";
            DistanzaSort = sortOrder == "Distanza" ? "distanza_desc" : "Distanza";
            SalitaSort = sortOrder == "Salita" ? "salita_desc" : "Salita";


            if (_context.Tours != null)
            {
                IQueryable<Tour> tourIQ = from t in _context.Tours
                                       select t;

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
                default:
                    tourIQ = tourIQ.OrderBy(t => t.PageTitle); break;
                        
            }



                Tours = await tourIQ.AsNoTracking().ToListAsync();
            }
        }
    }
}
