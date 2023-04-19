using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using iOrder.Models;

namespace iOrder.Data
{
    public class iOrderUserContext : DbContext
    {
        public iOrderUserContext (DbContextOptions<iOrderUserContext> options)
            : base(options)
        {
        }

        public DbSet<iOrder.Models.User> User { get; set; } = default!;
    }
}
