using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesEnvironment.Models;

namespace NaturalEnvironment.Pages_Environments
{
    public class DetailsModel : PageModel
    {
        private readonly RazorPagesNaturalEnvironmentContext _context;

        public DetailsModel(RazorPagesNaturalEnvironmentContext context)
        {
            _context = context;
        }

        public Environment Environment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Environment = await _context.Environment.FirstOrDefaultAsync(m => m.ID == id);

            if (Environment == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
