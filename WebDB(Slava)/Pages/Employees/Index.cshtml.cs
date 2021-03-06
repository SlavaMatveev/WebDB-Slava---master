﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RESTAURANT.Models;
using WebDB_Slava_.Data;

namespace WebDB_Slava_.Pages.Empoyees
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;

        public IndexModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }

        public IList<Employee> Employee { get;set; }
        public IList<Position> Position { get; set; }

        public async Task OnGetAsync()
        {
            Employee = await _context.Employee.ToListAsync();
            Position = await _context.Position.ToListAsync();
        }
    }
}
