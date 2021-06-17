using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebSystem.Models;

namespace SalesWebSystem.Data
{
    public class SalesWebSystemContext : DbContext
    {
        public SalesWebSystemContext (DbContextOptions<SalesWebSystemContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebSystem.Models.Department> Department { get; set; }
        public DbSet<SalesWebSystem.Models.Seller> Seller { get; set; }
        public DbSet<SalesWebSystem.Models.SalesRecord> SalesRecord { get; set; }

    }
}
