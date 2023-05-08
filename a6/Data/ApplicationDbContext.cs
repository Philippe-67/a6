using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using a6.Models;

namespace a6.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<a6.Models.Voiture> Voiture { get; set; } = default!;
        public DbSet<a6.Models.Reparation> Reparation { get; set; } = default!;
    }
}