using AssignmentJsonPatch.Entity;
using Microsoft.AspNetCore.JsonPatch;

namespace AssignmentJsonPatch.Repository
{
    public interface IPropertyRepo
    {
        Task<PropteryEntity> AddProperty(PropteryEntity propteryEntity);
        Task<IEnumerable<PropteryEntity>> getAllProperties();
        Task getsinglePatchProperty(int id, JsonPatchDocument property);
        Task<PropteryEntity> getsingleProperty(int id);
    }
}
