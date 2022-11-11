using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;
using System.Collections.Generic;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class MawbsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public MawbsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Mawbs
        [HttpGet]
        public async Task<IActionResult> GetMawbs()
        {
            //var includes = new List<string> { "Shipper", "Consignee", "Hawbs" };
            var includes = new List<string> { "Hawbs" };
            var mawbs = await _unitOfWork.Mawbs.GetAll(includes: includes);
            return Ok(mawbs);
        }

        // GET: api/Mawbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMawb(int id)
        {
            //var includes = new List<string> { "Shipper", "Consignee", "Hawbs", "Shipment.Customer", "Shipment.AwbStock.Airline", "Shipment.Dimmensions" };
            var includes = new List<string> { "Hawbs" };
            var mawb = await _unitOfWork.Mawbs.Get(q => q.Id == id, includes);

            if (mawb == null)
            {
                return NotFound();
            }

            return Ok(mawb);
        }

        // PUT: api/Mawbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMawb(int id, Mawb mawb)
        {
            if (id != mawb.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Mawbs.Update(mawb);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await MawbExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return Ok(mawb);
        }

        // POST: api/Mawbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostMawb(Mawb mawb)
        {
            await _unitOfWork.Mawbs.Insert(mawb);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetMawb", new { id = mawb.Id }, mawb);
        }

        // DELETE: api/Mawbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMawb(int id)
        {
            var mawb = await _unitOfWork.Mawbs.Get(q => q.Id == id);
            if (mawb == null)
            {
                return NotFound();
            }

            await _unitOfWork.Mawbs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> MawbExists(int id)
        {
            var mawb = await _unitOfWork.Mawbs.Get(q => q.Id == id);
            return mawb != null;
        }
    }
}
