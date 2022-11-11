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
    public class HawbsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public HawbsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Hawbs
        [HttpGet]
        public async Task<IActionResult> GetHawbs()
        {
            //var includes = new List<string> { "Shipper", "Consignee", "Mawb.Shipment.Customer" };
            var hawbs = await _unitOfWork.Hawbs.GetAll();
            return Ok(hawbs);
        }

        // GET: api/Hawbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetHawb(int id)
        {
            //var includes = new List<string> { "Shipper", "Consignee", "Mawb.Shipment.Customer" };
            var hawb = await _unitOfWork.Hawbs.Get(q => q.Id == id);

            if (hawb == null)
            {
                return NotFound();
            }

            return Ok(hawb);
        }

        // PUT: api/Hawbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutHawb(int id, Hawb hawb)
        {
            if (id != hawb.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Hawbs.Update(hawb);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await HawbExists(id))
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

        // POST: api/Hawbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostHawb(Hawb hawb)
        {
            await _unitOfWork.Hawbs.Insert(hawb);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetHawb", new { id = hawb.Id }, hawb);
        }

        // DELETE: api/Hawbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteHawb(int id)
        {
            var hawb = await _unitOfWork.Hawbs.Get(q => q.Id == id);
            if (hawb == null)
            {
                return NotFound();
            }

            await _unitOfWork.Hawbs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> HawbExists(int id)
        {
            var hawb = await _unitOfWork.Hawbs.Get(q => q.Id == id);
            return hawb != null;
        }
    }
}
