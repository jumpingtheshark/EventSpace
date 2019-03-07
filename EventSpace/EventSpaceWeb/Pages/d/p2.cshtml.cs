using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EventSpaceWeb.Pages.d
{
    public class p2Model : PageModel
    {
        public void OnGet()
        {
            ViewData["message"] = "fuck you too";
        }
    }
}