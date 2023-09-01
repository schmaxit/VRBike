﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using VRBike.Data;
using VRBike.Models;

namespace VRBike.Videos
{
    public class CreateModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public CreateModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Video Video { get; set; }
        

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
          if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Videos.Add(Video);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
