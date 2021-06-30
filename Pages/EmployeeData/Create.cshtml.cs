using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Employees.Data;
using Employees.Models;

namespace Employees.Pages.EmployeeData
{
    public class CreateModel : PageModel
    {
        private readonly Employees.Data.EmployeesContext _context;

        public CreateModel(Employees.Data.EmployeesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public EmployeeInfo EmployeeInfo { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.EmployeeInfo.Add(EmployeeInfo);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
