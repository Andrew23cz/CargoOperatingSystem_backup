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
    public class AfRatesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AfRatesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AfRates
        [HttpGet]
        public async Task<IActionResult> GetAfRates()
        {
            //var includes = new List<string> { "Airline" };
            var afRates = await _unitOfWork.AfRates.GetAll();
            return Ok(afRates);
            
        }

        // GET: api/AfRates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAfRates(int id)
        {
            //var includes = new List<string> { "Airline" };
            var afRates = await _unitOfWork.AfRates.Get(q => q.Id == id);
            
            if (afRates == null)
            {
                return NotFound();
            }

            return Ok(afRates);
        }

        // PUT: api/AfRates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAfRates(int id, AfRates afRates)
        {
            if (id != afRates.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AfRates.Update(afRates);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AfRatesExists(id))
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

        // POST: api/AfRates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAfRates(AfRates afRates)
        {
            await _unitOfWork.AfRates.Insert(afRates);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAfRates", new { id = afRates.Id }, afRates);
        }

        // DELETE: api/AfRates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAfRates(int id)
        {
            var afRates = await _unitOfWork.AfRates.Get(q => q.Id == id);
            if (afRates == null)
            {
                return NotFound();
            }

            await _unitOfWork.AfRates.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AfRatesExists(int id)
        {
            var afRates = await _unitOfWork.AfRates.Get(q => q.Id == id);
            return afRates != null;
        }
    }
}
