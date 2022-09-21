using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWeb2022.Models;

namespace SalesWeb2022.Data
{
    public class SalesWeb2022Context : DbContext
    {
        public SalesWeb2022Context (DbContextOptions<SalesWeb2022Context> options)
            : base(options)
        {
        }

        public DbSet<SalesWeb2022.Models.Department> Department { get; set; } = default!;
        public DbSet<SalesWeb2022.Models.Seller> Seller { get; set; }
        public DbSet<SalesWeb2022.Models.SalesRecord> SalesRecord { get; set; }
    }
}
