using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace WebDB_Slava_.Pages.FilReq
{
    public class IndexModel : PageModel
    {
        private readonly WebDB_Slava_.Data.WebDB_Slava_Context _context;
        public IndexModel(WebDB_Slava_.Data.WebDB_Slava_Context context)
        {
            _context = context;
        }

        public List<SelectListItem> SelPosition { get; set; }
        public List<SelectListItem> SelFind { get; set; }
        public List<SelectListItem> SelWare { get; set; }
        public async Task OnGetAsync()
        {
            SelPosition = _context.Position.Select(p =>
            new SelectListItem
            {
                Value = p.ID.ToString(),
                Text = p.Name_Positions
            }).ToList();
            SelFind = new List<SelectListItem>
                        {
                           new SelectListItem{ Value = "True", Text = "Выполнен"},
                           new SelectListItem{ Value = "False", Text = "Не выполнен"}
                        };
            SelWare = _context.Warehouse.Select(p =>
            new SelectListItem
            {
                Value = p.Producer.ToString(),
                Text = p.Producer
            }).ToList();
        }
    }
}
