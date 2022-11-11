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
    public class SuppliersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public SuppliersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Suppliers
        [HttpGet]
        public async Task<IActionResult> GetSuppliers()
        {
            var suppliers = await _unitOfWork.Suppliers.GetAll();
            return Ok(suppliers);
        }

        // GET: api/Suppliers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetSupplier(int id)
        {
            var supplier = await _unitOfWork.Suppliers.Get(q => q.Id == id);

            if (supplier == null)
            {
                return NotFound();
            }

            return Ok(supplier);
        }

        // PUT: api/Suppliers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSupplier(int id, Supplier supplier)
        {
            if (id != supplier.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Suppliers.Update(supplier);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await SupplierExists(id))
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

        // POST: api/Suppliers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostSupplier(Supplier supplier)
        {
            await _unitOfWork.Suppliers.Insert(supplier);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetSupplier", new { id = supplier.Id }, supplier);
        }

        // DELETE: api/Suppliers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSupplier(int id)
        {
            var supplier = await _unitOfWork.Suppliers.Get(q => q.Id == id);
            if (supplier == null)
            {
                return NotFound();
            }

            await _unitOfWork.Suppliers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> SupplierExists(int id)
        {
            var supplier = await _unitOfWork.Suppliers.Get(q => q.Id == id);
            return supplier != null;
        }
    }
}
