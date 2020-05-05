using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Asp_Mardari_Mihai_Rp.Models;

namespace Asp_Mardari_Mihai_Rp.Data
{
    public class Asp_Mardari_Mihai_RpContext : DbContext
    {
        public Asp_Mardari_Mihai_RpContext (DbContextOptions<Asp_Mardari_Mihai_RpContext> options)
            : base(options)
        {
        }

        public DbSet<Asp_Mardari_Mihai_Rp.Models.Movie> Movie { get; set; }
    }
}
