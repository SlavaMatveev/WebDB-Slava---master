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
    public class OrderModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public OrderModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }
        public IList<Order> Order { get; set; }
        public IList<RESTAURANT.Models.Menu> Menu { get; set; }
        public IList<Employee> Employee { get; set; }
     


        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
            Menu = await _context.Menu.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
           

        }
    }
}
