using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetCore.Models;

namespace NetCore.Data
{
    public class NetCoreContext : DbContext
    {
        public NetCoreContext (DbContextOptions<NetCoreContext> options)
            : base(options)
        {
        }

        public DbSet<NetCore.Models.Movie> Movie { get; set; }
    }
}
