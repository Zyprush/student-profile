#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using student_profile.Data;
using student_profile.studentprof;

namespace student_profile.Pages.Profiles
{
#pragma warning disable CS8618
#pragma warning disable CS8604
    public class IndexModel : PageModel
    {
        private readonly student_profile.Data.student_profileContext _context;

        public IndexModel(student_profile.Data.student_profileContext context)
        {
            _context = context;
        }

        public IList<Class> Class { get;set; }

        public async Task OnGetAsync()
        {
            Class = await _context.Class.ToListAsync();
        }
    }
#pragma warning restore CS8618
#pragma warning restore CS8604
}
