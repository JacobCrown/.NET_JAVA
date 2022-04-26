#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NET_CORE.Models;

namespace NET_CORE.Data
{
    public class NET_COREContext : DbContext
    {
        public NET_COREContext (DbContextOptions<NET_COREContext> options)
            : base(options)
        {
        }

        public DbSet<NET_CORE.Models.Game> Game { get; set; }
    }
}
