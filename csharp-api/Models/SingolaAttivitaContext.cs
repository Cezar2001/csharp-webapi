using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;

namespace csharp_api.Models
{
    public class SingolaAttivitaContext: DbContext
    {
        public SingolaAttivitaContext(DbContextOptions<SingolaAttivitaContext> options) : base(options)
        {

        }
        public DbSet<SingolaAttivita> ListaAttivita { get; set; } = null!;
    }
}
