using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Pages.TourCollections
{
    public class DeleteModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public DeleteModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public TourCollection TourCollection { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.ToursCollections == null)
            {
                return NotFound();
            }

            var tourcollection = await _context.ToursCollections.FirstOrDefaultAsync(m => m.TourCollectionID == id);

            if (tourcollection == null)
            {
                return NotFound();
            }
            else 
            {
                TourCollection = tourcollection;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.ToursCollections == null)
            {
                return NotFound();
            }
            var tourcollection = await _context.ToursCollections.FindAsync(id);

            if (tourcollection != null)
            {
                TourCollection = tourcollection;
                _context.ToursCollections.Remove(TourCollection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
