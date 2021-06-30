using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employees.Data;
using Employees.Models;

namespace Employees.Pages.EmployeeData
{
    public class DeleteModel : PageModel
    {
        private readonly Employees.Data.EmployeesContext _context;

        public DeleteModel(Employees.Data.EmployeesContext context)
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            EmployeeInfo = await _context.EmployeeInfo.FindAsync(id);

            if (EmployeeInfo != null)
            {
                _context.EmployeeInfo.Remove(EmployeeInfo);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
