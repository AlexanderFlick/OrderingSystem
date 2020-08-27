using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OrderingSystem.Data;
using OrderingSystem.Models;

namespace OrderingSystem.Pages.Items
{
    public class IndexModel : PageModel
    {
        private readonly OrderingSystem.Data.OrderingSystemContext _context;

        public IndexModel(OrderingSystem.Data.OrderingSystemContext context)
        {
            _context = context;
        }

        public IList<Item> Item { get;set; }

        public async Task OnGetAsync()
        {
            Item = await _context.Items.ToListAsync();
        }
    }
}
