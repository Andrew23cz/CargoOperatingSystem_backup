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
    public class CurrenciesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CurrenciesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Currencies
        [HttpGet]
        public async Task<IActionResult> GetCurrency()
        {
            var currencies = await _unitOfWork.Currencies.GetAll();
            return Ok(currencies);
        }

        // GET: api/Currencies/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCurrency(int id)
        {
            var currencies = await _unitOfWork.Currencies.Get(q => q.Id == id);

            if (currencies == null)
            {
                return NotFound();
            }

            return Ok(currencies);
        }

        // PUT: api/Currencies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCurrency(int id, Currency currency)
        {
            if (id != currency.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Currencies.Update(currency);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await CurrencyExists(id))
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

        // POST: api/Currencies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Currency>> PostCurrency(Currency currency)
        {
            await _unitOfWork.Currencies.Insert(currency);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetCurrency", new { id = currency.Id }, currency);
        }

        // DELETE: api/Currencies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCurrency(int id)
        {
            var currency = await _unitOfWork.Currencies.Get(q => q.Id == id);
            if (currency == null)
            {
                return NotFound();
            }

            await _unitOfWork.Currencies.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> CurrencyExists(int id)
        {
            var currencies = await _unitOfWork.Currencies.Get(q => q.Id == id);
            return currencies != null;
        }
    }
}
