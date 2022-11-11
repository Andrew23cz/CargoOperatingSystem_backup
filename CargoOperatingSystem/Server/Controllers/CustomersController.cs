using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using CargoOperatingSystem.Server.IRepository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Logging;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser, CustomerUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IUnitOfWork _unitofWork;
        private readonly ILogger<CustomersController> _logger;

        public CustomersController(IUnitOfWork unitofWork, ILogger<CustomersController> logger)
        {
            _unitofWork = unitofWork;
            _logger = logger;
        }

        // GET: api/Customers
        [HttpGet]
        public async Task<object> GetCustomers()
        {
            //var includes = new List<string> { "Shipments", "Invoices", "AwbStocks" };
            var customers = await _unitofWork.Customers.GetAll();

            _logger.LogInformation($"Returned {customers} customers from server");
            return Ok(customers);
        }

        // GET: api/Customers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCustomer(int id)
        {
            //var includes = new List<string> { "Shipments", "Invoices", "AwbStocks" };
            var customer = await _unitofWork.Customers.Get(q => q.Id == id);

            if (customer == null)
            {
                return NotFound();
            }

            return Ok(customer);
        }

        // PUT: api/Customers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.Id)
            {
                return BadRequest();
            }

            _unitofWork.Customers.Update(customer);

            try
            {
                await _unitofWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CustomerExists(id))
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

        // POST: api/Customers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostCustomer(Customer customer)
        {
            await _unitofWork.Customers.Insert(customer);
            await _unitofWork.Save(HttpContext);

            return CreatedAtAction("GetCustomer", new { id = customer.Id }, customer);
        }

        // DELETE: api/Customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _unitofWork.Customers.Get(q => q.Id == id);
            if (customer == null)
            {
                return NotFound();
            }

            await _unitofWork.Customers.Delete(id);
            await _unitofWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CustomerExists(int id)
        {
            var customer = await _unitofWork.Customers.Get(q => q.Id == id);
            return customer != null;
        }
    }
}
