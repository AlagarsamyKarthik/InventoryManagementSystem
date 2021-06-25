using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProductModule.Model;

namespace ProductModule.Data
{
    public class ProductModuleContext : DbContext
    {
        public ProductModuleContext (DbContextOptions<ProductModuleContext> options)
            : base(options)
        {
        }

        public DbSet<ProductModule.Model.Product> Product { get; set; }
    }
}
