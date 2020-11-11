using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ExpensesTableApi.Models
{
    public class ExpensesTableApiContext : DbContext
    {
        public ExpensesTableApiContext (DbContextOptions<ExpensesTableApiContext> options)
            : base(options)
        {
        }

        public DbSet<ExpensesTableApi.Models.Product> Product { get; set; }
    }
}
