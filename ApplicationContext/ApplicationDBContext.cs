using AssignmentJsonPatch.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace AssignmentJsonPatch.ApplicationContext
{
    public class ApplicationDBContext : DbContext, IApplicationDbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure AddressEntity as a keyless entity
            modelBuilder.Entity<PropteryEntity>()
            .OwnsOne(p => p.Address);

            modelBuilder.Entity<PropteryEntity>()
                .OwnsOne(p => p.Owner);

            // Optional: map it to a view or SQL query
            // modelBuilder.Entity<AddressEntity>().ToView("ViewName");
            // or
            // modelBuilder.Entity<AddressEntity>().ToSqlQuery("SELECT Street, City, PostalCode FROM SomeTable");
        }
        public async Task SaveChangesAsync()
        {
            await base.SaveChangesAsync();
        }
        public DbSet<PropteryEntity> propteryEntities { get; set; }


    }
}
