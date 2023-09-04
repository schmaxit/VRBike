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

namespace VRBike.Tours
{
    public class EditModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public EditModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Tour Tour { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tours == null)
            {
                return NotFound();
            }

            var tour =  await _context.Tours.FirstOrDefaultAsync(m => m.TourID == id);
            if (tour == null)
            {
                return NotFound();
            }
            Tour = tour;
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

            _context.Attach(Tour).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourExists(Tour.TourID))
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

        private bool TourExists(int id)
        {
          return _context.Tours.Any(e => e.TourID == id);
        }
    }
}
