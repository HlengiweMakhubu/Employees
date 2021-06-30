using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Employees.Data;
using Employees.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Employees.Pages.EmployeeData
{
    public class IndexModel : PageModel
    {
        private readonly Employees.Data.EmployeesContext _context;

        public IndexModel(Employees.Data.EmployeesContext context)
        {
            _context = context;
        }

        public IList<EmployeeInfo> EmployeeInfo { get; private set; }
        [BindProperty(SupportsGet = true)]
        public string SearchString { get; set; }
        public SelectList Names { get; set; }
        [BindProperty(SupportsGet = true)]
        public string EmployeeName { get; set; }
        public async Task OnGetAsync()
        {
            var name = from n in _context.EmployeeInfo select n;

            if (!string.IsNullOrEmpty(SearchString))
            {
                name = name.Where(s => s.EmployeeName.Contains(SearchString));
            }

            EmployeeInfo = await name.ToListAsync();
        }
    }
}
