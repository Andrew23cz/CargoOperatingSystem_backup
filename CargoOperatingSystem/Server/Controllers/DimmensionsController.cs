using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;
using System.Linq.Expressions;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class DimmensionsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public DimmensionsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Dimmensions
        [HttpGet]
        public async Task<IActionResult> GetDimmension()
        {
            //var includes = new List<string> { "Shipment" };
            var dimmensions = await _unitOfWork.Dimmensions.GetAll();
            return Ok(dimmensions);
        }

        // GET: api/Dimmensions/GetDimensionsByShipmentId/5
        [HttpGet("{GetDimensionsByShipmentId}/{shipmentId}")]
        public async Task<IActionResult> GetDimensionsByShipmentId(int shipmentId)
        {
            Expression<Func<Dimmension, bool>> hasShipmentId = s => s.ShipmentId == shipmentId;
            var dimmensions = await _unitOfWork.Dimmensions.GetAll(expression: hasShipmentId);
            return Ok(dimmensions);
        }

        // GET: api/Dimmensions/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetDimmension(int id)
        {
            var dimmension = await _unitOfWork.Dimmensions.Get(q => q.Id == id);

            if (dimmension == null)
            {
                return NotFound();
            }

            return Ok(dimmension);
        }

        // PUT: api/Dimmensions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimmension(int id, Dimmension dimmension)
        {
            if (id != dimmension.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Dimmensions.Update(dimmension);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await DimmensionExists(id))
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

        // POST: api/Dimmensions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Dimmension>> PostDimmension(Dimmension dimmension)
        {
            await _unitOfWork.Dimmensions.Insert(dimmension);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetDimmension", new { id = dimmension.Id }, dimmension);
        }

        // DELETE: api/Dimmensions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDimmension(int id)
        {
            var dimmension = await _unitOfWork.Dimmensions.Get(q => q.Id == id);
            if (dimmension == null)
            {
                return NotFound();
            }

            await _unitOfWork.Dimmensions.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> DimmensionExists(int id)
        {
            var dimmension = await _unitOfWork.Dimmensions.Get(q => q.Id == id);
            return dimmension != null;
        }
    }
}
