using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesEnvironment.Models;

namespace NaturalEnvironment.Pages_Environments
{
    public class EditModel : PageModel
    {
        private readonly RazorPagesEnvironmentContext _context;

        public EditModel(RazorPagesEnvironmentContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Environment).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EnvironmentExists(Environment.ID))
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

        private bool EnvironmentExists(int id)
        {
            return _context.Environment.Any(e => e.ID == id);
        }
    }
}
