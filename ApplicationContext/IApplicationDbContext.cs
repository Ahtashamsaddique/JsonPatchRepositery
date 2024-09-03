using AssignmentJsonPatch.Entity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;

namespace AssignmentJsonPatch.ApplicationContext
{
    public interface IApplicationDbContext
    {
        DbSet<PropteryEntity> propteryEntities { get; set; }

        Task SaveChangesAsync();
    }
}
