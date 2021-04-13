using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using FilmesCRUDRazor.Models;

namespace FilmesCRUDRazor.Pages.Filme
{
    public class IndexModel : PageModel
    {
        private readonly FilmesCRUDRazor.Models.FilmContext _context;

        public IndexModel(FilmesCRUDRazor.Models.FilmContext context)
        {
            _context = context;
        }

        public IList<Film> Film { get;set; }

        public async Task OnGetAsync()
        {
            Film = await _context.Film.ToListAsync();
        }
    }
}
