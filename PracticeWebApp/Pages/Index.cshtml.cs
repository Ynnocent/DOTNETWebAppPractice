using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PracticeWebApp.Data;
using PracticeWebApp.Models;

namespace PracticeWebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly PracticeWebApp.Data.PracticeWebAppContext _context;

        public IndexModel(PracticeWebApp.Data.PracticeWebAppContext context)
        {
            _context = context;
        }

        public IList<Pizza> Pizza { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Pizza != null)
            {
                Pizza = await _context.Pizza.ToListAsync();
            }
        }
    }
}
