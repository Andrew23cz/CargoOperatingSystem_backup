using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;
using CargoOperatingSystem.Server.IRepository;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class ChargesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChargesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Charges
        [HttpGet]
        public async Task<IActionResult> GetCharges()
        {
            var includes = new List<string> { "Currency" };
            var charges = await _unitOfWork.Charges.GetAll(includes: includes);
            return Ok(charges);
        }

        // GET: api/Charges/GetChargesByShipmentId/5
        [HttpGet("{GetChargesByShipmentId}/{shipmentId}")]
        public async Task<IActionResult> GetChargesByShipmentId(int shipmentId)
        {
            var includes = new List<string> { "Currency", "Supplier" };
            Expression<Func<Charge, bool>> hasShipmentId = s => s.ShipmentId == shipmentId;
            var charges = await _unitOfWork.Charges.GetAll(includes: includes, expression: hasShipmentId);
            return Ok(charges);
        }

        // GET: api/Charges/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharges(int id)
        {
            var includes = new List<string> { "Currency", "Supplier" };
            var charges = await _unitOfWork.Charges.Get(q => q.Id == id, includes);

            if (charges == null)
            {
                return NotFound();
            }

            return Ok(charges);
        }

        // PUT: api/Charges/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCharges(int id, Charge charge)
        {
            if (id != charge.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Charges.Update(charge);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ChargesExists(id))
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

        // POST: api/Charges
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Charge>> PostCharges(Charge charge)
        {
            await _unitOfWork.Charges.Insert(charge);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCharges", new { id = charge.Id }, charge);
        }

        // DELETE: api/Charges/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharges(int id)
        {
            var charge = await _unitOfWork.Charges.Get(q => q.Id == id);
            if (charge == null)
            {
                return NotFound();
            }

            await _unitOfWork.Charges.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ChargesExists(int id)
        {
            var charges = await _unitOfWork.Charges.Get(q => q.Id == id);
            return charges != null;
        }
    }
}
