using Microsoft.EntityFrameworkCore;
using таблица_пользователей.Models;

namespace таблица_пользователей.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
    }
}