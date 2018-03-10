using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MLGS;

namespace MLGS.Pages
{
    public class IndexModel : PageModel
    {
        private readonly MLGS.ParcelContext _context;

        public IndexModel(MLGS.ParcelContext context)
        {
            _context = context;
        }

        public IList<ParcelData> ParcelData { get;set; }

        public async Task OnGetAsync()
        {
            ParcelData = await _context.ParcelsData.ToListAsync();
        }
    }
}
