using Microsoft.EntityFrameworkCore;
using VosimeBlazor.Models;

namespace VosimeBlazor.Data
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Pizza> Pizzas { get; set; }
    }
}
