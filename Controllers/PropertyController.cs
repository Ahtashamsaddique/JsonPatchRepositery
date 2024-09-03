using AssignmentJsonPatch.Entity;
using AssignmentJsonPatch.Repository;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace AssignmentJsonPatch.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PropertyController : ControllerBase
    {
        private readonly IPropertyRepo _propertyRepo;

        public PropertyController(IPropertyRepo propertyRepo)
        {
            _propertyRepo = propertyRepo;
        }

        // GET: api/<PropertyController>
        [HttpGet("GetAllProperties")]
        public async Task<IActionResult> GetAllProperties()
        {

            return Ok(await _propertyRepo.getAllProperties());
        }

        // GET api/<PropertyController>/5
        [HttpGet("GetSingleProperty")]
        public async Task<IActionResult> GetSingleProperty(int id)
        {
            return Ok(await _propertyRepo.getsingleProperty(id));
        }

        // POST api/<PropertyController>
        [HttpPost("AddProperty")]
        public async Task<IActionResult> AddProperty(PropteryEntity property)
        {
            return Ok(await _propertyRepo.AddProperty(property));
        }

        // PUT api/<PropertyController>/5
        [HttpPatch("AddPropertyPatch")]
        public async Task<IActionResult> AddPropertyPatch(int id, JsonPatchDocument property)
        {
            await _propertyRepo.getsinglePatchProperty(id, property);   
            return NoContent();
        }

    }
}
