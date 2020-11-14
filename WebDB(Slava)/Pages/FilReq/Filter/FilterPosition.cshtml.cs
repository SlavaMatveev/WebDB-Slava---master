using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;

namespace WebDB_Slava_.Pages.FilReq.Filter
{
    public class FilterPositionModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public FilterPositionModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }
        public Position Position { get; set; }
        public IList<Employee> Employee { get; set; }
       
        public async Task<IActionResult> OnGetAsync(long? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Position = _context.Position.First(m => m.ID == id);
            if(Position==null)
            {
                return NotFound();
            }
            Employee = await _context.Employee.Where(m => m.PositionsID == Position.ID).ToListAsync();
            return Page();
        }
    }
}
