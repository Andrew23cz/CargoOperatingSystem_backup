using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using CargoOperatingSystem.Server.IRepository;
using Microsoft.AspNetCore.Authorization;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class ArrivalsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ArrivalsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Arrivals
        [HttpGet]
        public async Task<IActionResult> GetArrival()
        {
            var includes = new List<string> { "Supplier" };
            var arrival = await _unitOfWork.Arrivals.GetAll(includes: includes);
            return Ok(arrival);
        }

        // GET: api/Arrivals/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetArrival(int id)
        {
            var includes = new List<string> { "Supplier" };
            var arrival = await _unitOfWork.Arrivals.Get(q => q.Id == id, includes);

            if (arrival == null)
            {
                return NotFound();
            }

            return Ok(arrival);
        }

        // PUT: api/Arrivals/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutArrival(int id, Arrival arrival)
        {
            if (id != arrival.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Arrivals.Update(arrival);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ArrivalExists(id))
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

        // POST: api/Arrivals
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostArrival(Arrival arrival)
        {
            await _unitOfWork.Arrivals.Insert(arrival);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetArrival", new { id = arrival.Id }, arrival);
        }

        // DELETE: api/Arrivals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteArrival(int id)
        {
            var arrival = await _unitOfWork.Arrivals.Get(q => q.Id == id);
            if (arrival == null)
            {
                return NotFound();
            }

            await _unitOfWork.Arrivals.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ArrivalExists(int id)
        {
            var arrival = await _unitOfWork.Arrivals.Get(q => q.Id == id);
            return arrival != null;
        }
    }
}
