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

        public ParcelData ParcelData { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ParcelData = await _context.ParcelsData.SingleOrDefaultAsync(m => m.ParcelDataId == id);

            if (ParcelData == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
