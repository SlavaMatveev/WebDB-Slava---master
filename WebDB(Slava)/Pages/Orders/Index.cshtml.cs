﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;
using WebDB_Slava_.Data;

namespace WebDB_Slava_.Pages.Orders
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public IndexModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }

        public IList<Order> Order { get;set; }
        public IList<Employee> Employee { get;set; }
        public IList<RESTAURANT.Models.Menu> Menu { get;set; }

        public async Task OnGetAsync()
        {
            Order = await _context.Order.ToListAsync();
            Employee = await _context.Employee.ToListAsync();
            Menu = await _context.Menu.ToListAsync();
        }
    }
}
