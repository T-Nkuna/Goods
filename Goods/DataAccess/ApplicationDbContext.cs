using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Goods.Models;
using Microsoft.EntityFrameworkCore;

namespace Goods.DataAccess
{
   
    public class ApplicationDbContext: DbContext
    {
        public DbSet<Good> Goods { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }
    }
}
