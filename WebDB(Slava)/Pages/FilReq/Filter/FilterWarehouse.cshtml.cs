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
    public class FilterWarehouseModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public FilterWarehouseModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }
        public IList<Warehouse> Warehouse { get; set; }
        public async Task<IActionResult> OnGetAsync(string? ing)
        {
            if (ing == null)
            {
                return NotFound();
            }
            Warehouse = await _context.Warehouse.Where(m => m.Producer == ing).ToListAsync();
            if (Warehouse == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
