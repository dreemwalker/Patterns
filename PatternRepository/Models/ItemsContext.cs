using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace PatternRepository.Models
{
    public class ItemsContext : DbContext
    {
        public ItemsContext(DbContextOptions<ItemsContext> options) 
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Item> Items { get; set; }
    }
}
