using Microsoft.EntityFrameworkCore;
using Classnotes.Models;

namespace Classnotes.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Classnotes.Models.Professor> Professor { get; set; } = default!;

    }
}    