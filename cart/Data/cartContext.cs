using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using cart.Models;

namespace cart.Data
{
    public class cartContext : DbContext
    {
        public cartContext (DbContextOptions<cartContext> options)
            : base(options)
        {
        }

        public DbSet<cart.Models.Product> Product { get; set; } = default!;
        public DbSet<cart.Models.Category> Category { get; set; } = default!;

    }
}
