using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using CargoOperatingSystem.Server.IRepository;
using Microsoft.AspNetCore.Authorization;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser, CustomerUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class AirlinesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AirlinesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Airlines
        [HttpGet]
        public async Task<IActionResult> GetAirline()
        {
            var includes = new List<string> { "AwbStocks" };
            var airlines = await _unitOfWork.Airlines.GetAll(includes: includes);
            return Ok(airlines);
        }

        // GET: api/Airlines/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAirline(int id)
        {
            var includes = new List<string> { "AwbStocks" };
            var airline = await _unitOfWork.Airlines.Get(q => q.Id == id, includes);

            if (airline == null)
            {
                return NotFound();
            }

            return Ok(airline);
        }

        // GET: api/Airlines/297
        [HttpGet("{GetAirlineByPrefix}/{awbPrefix}")]

        public async Task<IActionResult> GetAirline(string awbPrefix)
        {
            var includes = new List<string> { "AwbStocks" };
            var airline = await _unitOfWork.Airlines.Get(q => q.Prefix == awbPrefix, includes);

            if (airline == null)
            {
                return NotFound();
            }

            return Ok(airline);
        }

        // PUT: api/Airlines/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PutAirline(int id, Airline airline)
        {
            if (id != airline.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Airlines.Update(airline);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AirlineExists(id))
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

        // POST: api/Airlines
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //[Authorize(Roles = "Administrator")]
        public async Task<IActionResult> PostAirline(Airline airline)
        {
            await _unitOfWork.Airlines.Insert(airline);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAirline", new { id = airline.Id }, airline);
        }

        // DELETE: api/Airlines/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrator")]
        public async Task<IActionResult> DeleteAirline(int id)
        {
            var airline = await _unitOfWork.Airlines.Get(q => q.Id == id);
            if (airline == null)
            {
                return NotFound();
            }

            await _unitOfWork.Airlines.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AirlineExists(int id)
        {
            var airline = await _unitOfWork.Airlines.Get(q => q.Id == id);
            return airline != null;
        }
    }
}
