using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Pages.TourMarkers
{
    public class EditModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public EditModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TourMarker TourMarker { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.TourMarkers == null)
            {
                return NotFound();
            }

            var tourmarker =  await _context.TourMarkers.FirstOrDefaultAsync(m => m.TourMarkerID == id);
            if (tourmarker == null)
            {
                return NotFound();
            }
            TourMarker = tourmarker;
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(TourMarker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourMarkerExists(TourMarker.TourMarkerID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool TourMarkerExists(int id)
        {
          return _context.TourMarkers.Any(e => e.TourMarkerID == id);
        }
    }
}
