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
    public class InvoicesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public InvoicesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Invoices
        [HttpGet]
        public async Task<IActionResult> GetInvoices()
        {
            //var includes = new List<string> { "Customer", "Shipments" };
            var invoices = await _unitOfWork.Invoices.GetAll();
            return Ok(invoices);
        }

        // GET: api/Invoices/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetInvoice(int id)
        {
            //var includes = new List<string> { "Customer", "Shipments" };
            var invoice = await _unitOfWork.Invoices.Get(q => q.Id == id);

            if (invoice == null)
            {
                return NotFound();
            }

            return Ok(invoice);
        }

        // PUT: api/Invoices/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvoice(int id, Invoice invoice)
        {
            if (id != invoice.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Invoices.Update(invoice);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await InvoiceExists(id))
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

        // POST: api/Invoices
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostInvoice(Invoice invoice)
        {
            await _unitOfWork.Invoices.Insert(invoice);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetInvoice", new { id = invoice.Id }, invoice);
        }

        // DELETE: api/Invoices/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvoice(int id)
        {
            var invoice = await _unitOfWork.Invoices.Get(q => q.Id == id);
            if (invoice == null)
            {
                return NotFound();
            }

            await _unitOfWork.Invoices.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> InvoiceExists(int id)
        {
            var invoice = await _unitOfWork.Invoices.Get(q => q.Id == id);
            return invoice != null;
        }
    }
}
