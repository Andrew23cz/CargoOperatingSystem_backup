using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class PickupsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public PickupsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Pickups
        [HttpGet]
        public async Task<IActionResult> GetPickups()
        {
            //var includes = new List<string> { "Shipment" };
            var pickups = await _unitOfWork.Pickups.GetAll();
            return Ok(pickups);
        }

        // GET: api/Pickups/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPickup(int id)
        {
            //var includes = new List<string> { "Shipment" };
            var pickup = await _unitOfWork.Pickups.Get(q => q.Id == id);

            if (pickup == null)
            {
                return NotFound();
            }

            return Ok(pickup);
        }

        // PUT: api/Pickups/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPickup(int id, Pickup pickup)
        {
            if (id != pickup.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Pickups.Update(pickup);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await PickupExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pickups
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Pickup>> PostPickup(Pickup pickup)
        {
            await _unitOfWork.Pickups.Insert(pickup);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetPickup", new { id = pickup.Id }, pickup);
        }

        // DELETE: api/Pickups/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePickup(int id)
        {
            var pickup = await _unitOfWork.Pickups.Get(q => q.Id == id);
            if (pickup == null)
            {
                return NotFound();
            }

            await _unitOfWork.Pickups.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> PickupExists(int id)
        {
            var pickup = await _unitOfWork.Pickups.Get(q => q.Id == id);
            return pickup != null;
        }
    }
}
