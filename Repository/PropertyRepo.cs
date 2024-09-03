using AssignmentJsonPatch.ApplicationContext;
using AssignmentJsonPatch.Entity;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace AssignmentJsonPatch.Repository
{
    public class PropertyRepo:IPropertyRepo
    {
        private readonly IApplicationDbContext _context;

        public PropertyRepo(IApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<PropteryEntity> AddProperty(PropteryEntity propteryEntity)
        {
            var resp=await _context.propteryEntities.AddAsync(propteryEntity);
           await _context.SaveChangesAsync();
            return propteryEntity;
        }
        public async Task<IEnumerable<PropteryEntity>> getAllProperties()
        {
            var resp=await _context.propteryEntities.ToListAsync();
            return resp;
        }
        public async Task<PropteryEntity> getsingleProperty(int id)
        {
            var resp = await _context.propteryEntities.Where(x => x.Id == id).FirstOrDefaultAsync();
            return resp;
        }
        public async Task getsinglePatchProperty(int id, JsonPatchDocument property)
        {
            var resp = await _context.propteryEntities.Where(x => x.Id == id).FirstOrDefaultAsync();
           if(resp!=null)
            {
                property.ApplyTo(resp);
                //_context.Entry(property) = EntityState.Modified;
                await _context.SaveChangesAsync();
            }
        }
    }
}
