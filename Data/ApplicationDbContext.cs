using Atividade_Avaliativa_fase_6_front.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Atividade_Avaliativa_fase_6_front.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<AlugueCarro> AlugueCarro { get; set; }
        public DbSet<Cultura> Cultura { get; set; }
        public DbSet<DicasUteis> DicasUteis { get; set; }
        public DbSet<Entretenimento> Entretenimento { get; set; }
        public DbSet<Gastronomia> Gastronomia { get; set; }
        public DbSet<Historia> Historia { get; set; }
        public DbSet<OndeHospedar> OndeHospedar { get; set; }
        public DbSet<Parques> Parques { get; set; }
        public DbSet<VidaNoturna> VidaNoturna { get; set; }
    }
}