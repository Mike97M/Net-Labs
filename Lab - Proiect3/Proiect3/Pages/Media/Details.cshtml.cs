using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedia;
namespace Proiect3.Pages.Media
{
    public class DetailsModel : PageModel
    {
        PostMediaClient client = new PostMediaClient();
        public Medias Media { get; set; }
        public DetailsModel()
        {
            Media = new Medias();
        }
        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();
            Media = await client.GetMediaByIdAsync(id.Value);
            if (Media == null)
                return NotFound();
            return Page();
        }
    }
}