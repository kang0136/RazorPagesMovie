using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie_kang.Data;
using RazorPagesMovie_kang.Models;

namespace RazorPagesMovie_kang.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMovie_kang.Data.RazorPagesMovie_kangContext _context;

        public IndexModel(RazorPagesMovie_kang.Data.RazorPagesMovie_kangContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
