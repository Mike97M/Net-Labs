using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ServiceReferenceMedia;

namespace Proiect3.Pages.Media
{
    public class IndexModel : PageModel
    {
        PostMediaClient client = new PostMediaClient();
        public List<Medias> MediaList { get; set; }
        public IndexModel()
        {
            this.MediaList = new List<Medias>();
        }
        public async Task OnGetAsync()
        {
            var medias = await client.GetAllPhotosAsync();
            this.MediaList = medias.ToList<Medias>();
        }
    }
}