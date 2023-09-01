using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Tours
{
    public class DetailsModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public DetailsModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

      public Tour Tour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tours == null)
            {
                return NotFound();
            }

            var tour = await _context.Tours.FirstOrDefaultAsync(m => m.ID == id);
            if (tour == null)
            {
                return NotFound();
            }
            else 
            {
                Tour = tour;
            }
            return Page();
        }
    }
}
