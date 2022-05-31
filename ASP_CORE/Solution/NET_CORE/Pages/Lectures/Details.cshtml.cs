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
    public class DetailsModel : PageModel
    {
        private readonly NET_CORE.Data.NET_COREContext _context;

        public DetailsModel(NET_CORE.Data.NET_COREContext context)
        {
            _context = context;
        }

        public Lecture Lecture { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Lecture = await _context.Lecture.FirstOrDefaultAsync(m => m.ID == id);

            if (Lecture == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
