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

namespace VRBike.Pages.TourCollections
{
    public class EditModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public EditModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        [BindProperty]
        public TourCollection TourCollection { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ToursCollections == null)
            {
                return NotFound();
            }

            var tourcollection =  await _context.ToursCollections.FirstOrDefaultAsync(m => m.TourCollectionID == id);
            if (tourcollection == null)
            {
                return NotFound();
            }
            TourCollection = tourcollection;
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

            _context.Attach(TourCollection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TourCollectionExists(TourCollection.TourCollectionID))
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

        private bool TourCollectionExists(int id)
        {
          return _context.ToursCollections.Any(e => e.TourCollectionID == id);
        }
    }
}
