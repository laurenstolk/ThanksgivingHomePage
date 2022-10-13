using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreWebService.Models
{
    public class ThanksgivingDBContext : DbContext
    {
        public ThanksgivingDBContext(DbContextOptions<ThanksgivingDBContext> options) : base(options)
        {

        }
        public DbSet<foods> foods { get; set; }
    }
}
