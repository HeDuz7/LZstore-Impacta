using LZStore.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace LZStore.Models.Contexts
{
    public class LzStoreContext : DbContext
    {
        public DbSet<ClienteDto> Clientes { get; set; }

        public DbSet<ProdutoDto> Produto { get; set; }

        //public DbSet<UsuarioDto> Usuarios { get; set; }


        public LzStoreContext(DbContextOptions options)
            : base(options)
        {
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            ChangeTracker.AutoDetectChangesEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
