using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;

namespace WebDB_Slava_.Pages.FilReq.Request
{
    public class MenuModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public MenuModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }
        public IList<RESTAURANT.Models.Menu> Menu { get; set; }
        public IList<Warehouse> Warehouse { get; set; }
        public async Task OnGetAsync()
        {
            Menu = await _context.Menu.ToListAsync();
            Warehouse = await _context.Warehouse.ToListAsync();
        }
    }
}
