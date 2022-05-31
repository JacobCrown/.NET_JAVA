#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using NET_CORE.Data;
using NET_CORE.Models;

namespace NET_CORE.Pages.Lectures
{
    public class EditModel : PageModel
    {
        private readonly NET_CORE.Data.NET_COREContext _context;

        public EditModel(NET_CORE.Data.NET_COREContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Lecture).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LectureExists(Lecture.ID))
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

        private bool LectureExists(int id)
        {
            return _context.Lecture.Any(e => e.ID == id);
        }
    }
}
