using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;
using System.Linq.Expressions;
using Microsoft.Extensions.Logging;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class ShipmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ShipmentsController> _logger;

        public ShipmentsController(IUnitOfWork unitOfWork, ILogger<ShipmentsController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        // GET: api/Shipments
        [HttpGet]
        public async Task<IActionResult> GetShipmentsPaged(int skip = 0, int take = 50)
        {
            //var includes = new List<string> { "Customer", "Workload", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline" };
            var includes = new List<string> { "Workload", "Mawb", "Arrival", "Mawb.Hawbs" };
            var shipments = await _unitOfWork.Shipments.GetAllPaged(skip, take, includes: includes);
            return Ok(shipments);
        }

        public async Task<IActionResult> GetShipments ()
        {
            //var includes = new List<string> { "Customer", "Workload", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline" };
            var includes = new List<string> { "Workload", "Mawb", "Arrival", "Mawb.Hawbs" };
            var shipments = await _unitOfWork.Shipments.GetAll(includes: includes);
            return Ok(shipments);
        }

        // GET: api/Shipments/GetShipmentsByIdentity/Cargopoint
        [HttpGet("{GetShipmentsByIdentity}/{companyIdentity}")]
        public async Task<IActionResult> GetShipments(string companyIdentity)
        {
            Expression<Func<Shipment, bool>> hasComapnyIdentity = s => s.CompanyIdentity == companyIdentity;
            //var includes = new List<string> { "Customer", "Workload", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline" };
            var includes = new List<string> { "Workload", "Mawb", "Arrival", "Mawb.Hawbs" };
            var shipments = await _unitOfWork.Shipments.GetAll(includes: includes, expression: hasComapnyIdentity);
            return Ok(shipments);
        }

        // GET: api/Shipments/GetShipmentsByDateRange/1/2/2022/12/4/2022
        [HttpGet("{GetShipmentsByDateRange}/{startday}/{startmonth}/{startyear}/{endday}/{endmonth}/{endyear}")]
        public async Task<IActionResult> GetShipmentsByDateRange(string startmonth, string startday, string startyear, string endmonth, string endday, string endyear)
        {
            string start = $"{startday}/{startmonth}/{startyear}";
            string end = $"{endday}/{endmonth}/{endyear}";
            var parsedStart = DateTime.Parse(start);
            var parsedEnd = DateTime.Parse(end).AddSeconds(-1);
            
            _logger.LogInformation($"================>>>> REQUESTED DATA FORMAT =======> START DATE => {parsedStart} END DATE => {parsedEnd}");
            
            Expression<Func<Shipment, bool>> hasDateRange = s => s.FirstFlightDate >= parsedStart && s.FirstFlightDate <= parsedEnd;
            //var includes = new List<string> { "Customer", "Workload", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline" };
            var includes = new List<string> { "Workload", "Mawb", "Arrival", "Mawb.Hawbs" };
            var shipments = await _unitOfWork.Shipments.GetAll(includes: includes, expression: hasDateRange);
            return Ok(shipments);
        }

        // GET: api/Shipments/5
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetShipment(int id)
        {
            var queryString = Request.Query;

            System.Diagnostics.Debug.Print($"id ==============> {id}");

            var includes = new List<string> { "Customer", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline", "Dimmensions", "Workload.WorkloadRateSheet" };
            var testIncludes = new List<string> { "Customer", "AwbStock.Airline", "Dimmensions", "Delivery", "Arrival", "Pickup" };
            var shipment = await _unitOfWork.Shipments.Get(q => q.Id == id, includes);

            if (shipment == null)
            {
                return NotFound();
            }

            return Ok(shipment);
        }

        // GET: api/Shipments/GetShipmentByAwbStockId/5
        [HttpGet("{GetShipmentByAwbStockId}/{awbstockid:int}")]
        public async Task<IActionResult> GetShipmentByAwbStockId(int awbstockid)
        {
            var queryString = Request.Query;

            System.Diagnostics.Debug.Print($"awbstockid ==============> {awbstockid}");

            var includes = new List<string> { "Customer", "Workload", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline", "Dimmensions", "Workload.WorkloadRateSheet" };
            var shipment = await _unitOfWork.Shipments.Get(q => q.AwbStockId == awbstockid, includes);

            if (shipment == null)
            {
                return NotFound();
            }

            return Ok(shipment);
        }

        // GET: api/Shipment/297-11112222
        [HttpGet("{awb}")]

        public async Task<IActionResult> GetShipment(string awb)
        {
            System.Diagnostics.Debug.Print($"awbNumber ==============> {awb}");

            var includes = new List<string> { "Customer", "Workload", "Mawb.Hawbs", "Delivery", "Arrival", "AwbStock.Airline", "Dimmensions", "Workload.WorkloadRateSheet" };
            var shipment = await _unitOfWork.Shipments.Get(q => q.AwbNumber == awb, includes);

            if (shipment == null)
            {
                return NotFound();
            }

            return Ok(shipment);
        }

        // PUT: api/Shipments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutShipment(int id, Shipment shipment)
        {
            if (id != shipment.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Shipments.Update(shipment);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await ShipmentExists(id))
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

        // POST: api/Shipments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostShipment(Shipment shipment)
        {
            await _unitOfWork.Shipments.Insert(shipment);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetShipment", new { id = shipment.Id }, shipment);
        }

        // DELETE: api/Shipments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteShipment(int id)
        {
            var shipment = await _unitOfWork.Shipments.Get(q => q.Id == id);
            if (shipment == null)
            {
                return NotFound();
            }

            await _unitOfWork.Shipments.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> ShipmentExists(int id)
        {
            var shipment = await _unitOfWork.Shipments.Get(q => q.Id == id);
            return shipment != null;
        }
    }

}


