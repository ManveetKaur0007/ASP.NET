using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesEnvironment.Models;

namespace NaturalEnvironment.Pages_Environments
{
    public class CreateModel : PageModel
    {
        private readonly RazorPagesEnvironmentContext _context;

        public CreateModel(RazorPagesEnvironmentContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Environment Environment { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Environment.Add(Environment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
