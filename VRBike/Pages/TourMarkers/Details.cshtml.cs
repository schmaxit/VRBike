using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Pages.TourMarkers
{
    public class DetailsModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public DetailsModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

      public TourMarker TourMarker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TourMarkers == null)
            {
                return NotFound();
            }

            var tourmarker = await _context.TourMarkers.FirstOrDefaultAsync(m => m.TourMarkerID == id);
            if (tourmarker == null)
            {
                return NotFound();
            }
            else 
            {
                TourMarker = tourmarker;
            }
            return Page();
        }
    }
}
