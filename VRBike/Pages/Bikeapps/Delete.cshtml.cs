using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Bikeapps
{
    public class DeleteModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public DeleteModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        [BindProperty]
      public Bikeapp Bikeapp { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Bikeapps == null)
            {
                return NotFound();
            }

            var bikeapp = await _context.Bikeapps.FirstOrDefaultAsync(m => m.BikeappID == id);

            if (bikeapp == null)
            {
                return NotFound();
            }
            else 
            {
                Bikeapp = bikeapp;
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Bikeapps == null)
            {
                return NotFound();
            }
            var bikeapp = await _context.Bikeapps.FindAsync(id);

            if (bikeapp != null)
            {
                Bikeapp = bikeapp;
                _context.Bikeapps.Remove(Bikeapp);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
