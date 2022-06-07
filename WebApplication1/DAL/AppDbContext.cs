using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

             public DbSet<Slider> Sliders { get; set; }
             public DbSet<Feature> Features { get; set; }
              public DbSet<Product> Products { get; set; }
    }
}
