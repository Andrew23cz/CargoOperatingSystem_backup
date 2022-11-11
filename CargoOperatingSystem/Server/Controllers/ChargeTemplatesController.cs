using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
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
    public class ChargeTemplatesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ChargeTemplatesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/ChargeTemplates
        [HttpGet]
        public async Task<IActionResult> GetChargeTemplates()
        {
            var includes = new List<string> { "Currency", "Airline" };
            var chargeTemplates = await _unitOfWork.ChargeTemplates.GetAll(includes: includes);
            return Ok(chargeTemplates);
        }

        // GET: api/ChargeTemplates/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetChargeTemplate(int id)
        {
            var includes = new List<string> { "Currency", "Supplier", "Airline" };
            var chargeTemplate = await _unitOfWork.ChargeTemplates.Get(q => q.Id == id, includes);

            if (chargeTemplate == null)
            {
                return NotFound();
            }

            return Ok(chargeTemplate);
        }

        // GET: api/GetChargeTemplateByAirlinePrefix/ChargeTemplates/297
        [HttpGet("{GetChargeTemplateByAirlinePrefix}/{awbPrefix}")]

        public async Task<IActionResult> GetChargeTemplate(string awbPrefix)
        {
            var includes = new List<string> { "Currency", "Supplier", "Airline" };
            var chargeTemplate = await _unitOfWork.ChargeTemplates.Get(q => q.Airline.Prefix == awbPrefix, includes);

            if (chargeTemplate == null)
            {
                return NotFound();
            }

            return Ok(chargeTemplate);
        }

        // PUT: api/ChargeTemplates/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutChargeTemplate(int id, ChargeTemplate chargeTemplate)
        {
            if (id != chargeTemplate.Id)
            {
                return BadRequest();
            }

            _unitOfWork.ChargeTemplates.Update(chargeTemplate);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ChargeTemplateExists(id))
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

        // POST: api/ChargeTemplates
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostChargeTemplate(ChargeTemplate chargeTemplate)
        {
            await _unitOfWork.ChargeTemplates.Insert(chargeTemplate);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCharges", new { id = chargeTemplate.Id }, chargeTemplate);
        }

        // DELETE: api/ChargeTemplates/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteChargeTemplate(int id)
        {
            var chargeTemplate = await _unitOfWork.ChargeTemplates.Get(q => q.Id == id);
            if (chargeTemplate == null)
            {
                return NotFound();
            }

            await _unitOfWork.ChargeTemplates.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ChargeTemplateExists(int id)
        {
            var chargeTemplate = await _unitOfWork.ChargeTemplates.Get(q => q.Id == id);
            return chargeTemplate != null;
        }
    }
}
