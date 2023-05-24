using ControleGlicemia_002.Models;

using Microsoft.EntityFrameworkCore;

namespace ControleGlicemia_002.Context
{
    public class GlicemiaContext : DbContext
    {
        public GlicemiaContext(DbContextOptions<GlicemiaContext> options) : base(options)
        {

        }

        public DbSet<GlicemiaViewModel> GLICEMIAS { get; set; }

        internal Task SaveChangesAsync(GlicemiaViewModel glicemia)
        {
            throw new NotImplementedException();
        }
    }
}
