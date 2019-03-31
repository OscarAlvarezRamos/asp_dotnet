using Microsoft.EntityFrameworkCore;
using SecurityProject.API.Models;

namespace SecurityProject.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}
        public DbSet<Role> Roles { get; set;}
    }
}