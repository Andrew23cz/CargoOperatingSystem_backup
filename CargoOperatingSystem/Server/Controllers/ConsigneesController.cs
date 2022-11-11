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
    public class ConsigneesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ConsigneesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Consignees
        [HttpGet]
        public async Task<IActionResult> GetConsignees()
        {
            var consignees = await _unitOfWork.Consignees.GetAll();
            return Ok(consignees);
        }

        // GET: api/Consignees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetConsignee(int id)
        {
            var consignee = await _unitOfWork.Consignees.Get(q => q.Id == id);

            if (consignee == null)
            {
                return NotFound();
            }

            return Ok(consignee);
        }

        // PUT: api/Consignees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConsignee(int id, Consignee consignee)
        {
            if (id != consignee.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Consignees.Update(consignee);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ConsigneeExists(id))
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

        // POST: api/Consignees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostConsignee(Consignee consignee)
        {
            await _unitOfWork.Consignees.Insert(consignee);
            await _unitOfWork.Save(HttpContext);
            return CreatedAtAction("GetConsignee", new { id = consignee.Id }, consignee);
        }

        // DELETE: api/Consignees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteConsignee(int id)
        {
            var consignee = await _unitOfWork.Consignees.Get( q => q.Id == id);
            if (consignee == null)
            {
                return NotFound();
            }

            await _unitOfWork.Consignees.Delete(id);
            await _unitOfWork.Save(HttpContext);
            
            return NoContent();
        }

        private async Task<bool> ConsigneeExists(int id)
        {
            var consignee = await _unitOfWork.Consignees.Get(e => e.Id == id);

            return consignee != null;
        }
    }
}
