using Microsoft.EntityFrameworkCore;
using xTestAutoMapper.Modules.DataService.Interfaces;

namespace xTestAutoMapper.Modules.DataService.Context
{
    public class XDbContext : DbContext, IXDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}