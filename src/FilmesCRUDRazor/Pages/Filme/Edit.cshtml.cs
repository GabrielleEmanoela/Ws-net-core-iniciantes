using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.Models;

namespace FilmesCRUDRazor.Pages.Filme
{
    public class EditModel : PageModel
    {
        private readonly FilmesCRUDRazor.Models.FilmContext _context;

        public EditModel(FilmesCRUDRazor.Models.FilmContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Film Film { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Film = await _context.Film.FirstOrDefaultAsync(m => m.FilmId == id);

            if (Film == null)
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

            _context.Attach(Film).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FilmExists(Film.FilmId))
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

        private bool FilmExists(int id)
        {
            return _context.Film.Any(e => e.FilmId == id);
        }
    }
}
