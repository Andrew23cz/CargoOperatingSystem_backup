using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using CargoOperatingSystem.Server.IRepository;
using Microsoft.AspNetCore.Authorization;


namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser, CustomerUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class AwbStocksController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AwbStocksController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AwbStocks
        [HttpGet]
        public async Task<IActionResult> GetAwbStock()
        {
            var includes = new List<string> { "Airline", "Customer", "Shipment.Customer" };
            var awbStocks = await _unitOfWork.AwbStocks.GetAll(includes: includes);
            return Ok(awbStocks);
        }

        // GET: api/AwbStocks/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAwbStock(int id)
        {
            var includes = new List<string> { "Airline", "Customer", "Shipment.Customer" };
            var awbStock = await _unitOfWork.AwbStocks.Get(q => q.Id == id, includes);

            if (awbStock == null)
            {
                return NotFound();
            }

            return Ok(awbStock);
        }

        // PUT: api/AwbStocks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAwbStock(int id, AwbStock awbStock)
        {
            if (id != awbStock.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AwbStocks.Update(awbStock);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AwbStockExists(id))
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

        // POST: api/AwbStocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAwbStock(AwbStock awbStock)
        {
            await _unitOfWork.AwbStocks.Insert(awbStock);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAwbStock", new { id = awbStock.Id }, awbStock);

        }


        // DELETE: api/AwbStocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAwbStock(int id)
        {
            var awbStock = await _unitOfWork.AwbStocks.Get(q => q.Id == id);
            if (awbStock == null)
            {
                return NotFound();
            }

            await _unitOfWork.AwbStocks.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AwbStockExists(int id)
        {
            var awbStock = await _unitOfWork.AwbStocks.Get(q => q.Id == id);
            return awbStock != null;
        }
    }
}
