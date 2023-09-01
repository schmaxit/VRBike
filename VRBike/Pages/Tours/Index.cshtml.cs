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
    public class IndexModel : PageModel
    {
        private readonly VRBike.Data.VRBikeContext _context;

        public IndexModel(VRBike.Data.VRBikeContext context)
        {
            _context = context;
        }

        public IList<Tour> Tour { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Tours != null)
            {
                Tour = await _context.Tours.ToListAsync();
            }
        }
    }
}
