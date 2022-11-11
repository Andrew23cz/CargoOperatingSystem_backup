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
    public class ShippersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public ShippersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Shippers
        [HttpGet]
        public async Task<IActionResult> GetShippers()
        {
            var shippers = await _unitOfWork.Shippers.GetAll();
            return Ok(shippers);
        }

        // GET: api/Shippers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetShipper(int id)
        {
            var shipper = await _unitOfWork.Shippers.Get(q => q.Id == id);

            if (shipper == null)
            {
                return NotFound();
            }

            return Ok(shipper);
        }

        // PUT: api/Shippers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShipper(int id, Shipper shipper)
        {
            if (id != shipper.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Shippers.Update(shipper);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ShipperExists(id))
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

        // POST: api/Shippers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostShipper(Shipper shipper)
        {
            await _unitOfWork.Shippers.Insert(shipper);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetShipper", new { id = shipper.Id }, shipper);
        }

        // DELETE: api/Shippers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShipper(int id)
        {
            var shipper = await _unitOfWork.Shippers.Get(q => q.Id == id);
            if (shipper == null)
            {
                return NotFound();
            }

            await _unitOfWork.Shippers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ShipperExists(int id)
        {
            var shipper = await _unitOfWork.Shippers.Get(q => q.Id == id);
            return shipper != null;
        }
    }
}
