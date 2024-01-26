using Microsoft.EntityFrameworkCore;
using Classnotes.Models;

namespace Classnotes.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Professor { get; set; } = default!;
        public DbSet<Turma> Turma { get; set; } = default!;

    }
}    