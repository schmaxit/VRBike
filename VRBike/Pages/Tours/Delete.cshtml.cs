﻿using System;
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
    public class DeleteModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;
        private readonly ILogger<DeleteModel> _logger;

        public DeleteModel(VRBike.Data.VRBikeContext context, ILogger<DeleteModel> logger)
        {
            _context = context;
            _logger = logger;
        }

        [BindProperty]
      public Tour Tour { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Tours == null)
            {
                return NotFound();
            }

            var tour = await _context.Tours.FirstOrDefaultAsync(m => m.TourID == id);

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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null || _context.Tours == null)
            {
                return NotFound();
            }
            var tour = await _context.Tours.FindAsync(id);

            if (tour != null)
            {
                Tour = tour;
                _context.Tours.Remove(Tour);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
