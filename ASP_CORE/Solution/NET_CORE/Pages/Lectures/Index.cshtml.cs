#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using NET_CORE.Data;
using NET_CORE.Models;

namespace NET_CORE.Pages.Lectures
{
    public class IndexModel : PageModel
    {
        private readonly NET_CORE.Data.NET_COREContext _context;

        public IndexModel(NET_CORE.Data.NET_COREContext context)
        {
            _context = context;
        }

        public IList<Lecture> Lecture { get;set; }

        public async Task OnGetAsync()
        {
            Lecture = await _context.Lecture.ToListAsync();
        }
    }
}
