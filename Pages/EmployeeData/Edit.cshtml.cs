using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Employees.Data;
using Employees.Models;

namespace Employees.Pages.EmployeeData
{
    public class EditModel : PageModel
    {
        private readonly Employees.Data.EmployeesContext _context;

        public EditModel(Employees.Data.EmployeesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public EmployeeInfo EmployeeInfo { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeInfo = await _context.EmployeeInfo.FirstOrDefaultAsync(m => m.EmployeeID == id);

            if (EmployeeInfo == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(EmployeeInfo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmployeeInfoExists(EmployeeInfo.EmployeeID))
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

        private bool EmployeeInfoExists(int id)
        {
            return _context.EmployeeInfo.Any(e => e.EmployeeID == id);
        }
    }
}
