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
    public class FilterOrderModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public FilterOrderModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }
        public IList<Order> Order { get; set; }
        public IList<RESTAURANT.Models.Menu> Menu { get; set; }




        public async Task<IActionResult> OnGetAsync(bool? find)
        {
            if (find == null)
            {
                return NotFound();
            }
            Order = await _context.Order.Where(m => m.check == find).ToListAsync();
            Menu = await _context.Menu.ToListAsync();
            if (Order == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
