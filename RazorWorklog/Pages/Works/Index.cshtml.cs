using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorWorklog.Models;

namespace RazorWorklog.Pages.Works
{
    public class IndexModel : PageModel
    {
        private readonly WorkContext _context;

        public IndexModel(WorkContext context)
        {
            _context = context;
        }

        public IList<Work> Work { get;set; }

        public async Task OnGetAsync()
        {
            Work = await _context.Work.ToListAsync();
        }
    }
}
