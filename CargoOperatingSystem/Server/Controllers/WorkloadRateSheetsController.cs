using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Server.Data;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class WorkloadRateSheetsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkloadRateSheetsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/WorkloadRateSheets
        [HttpGet]
        public async Task<IActionResult> GetWorkloadRateSheets()
        {
            var includes = new List<string> { "Currency" };
            var workloadRateSheets = await _unitOfWork.WorkloadRateSheets.GetAll(includes: includes);
            return Ok(workloadRateSheets);
        }

        // GET: api/WorkloadRateSheets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<WorkloadRateSheet>> GetWorkloadRateSheet(int id)
        {
            var includes = new List<string> { "Currency" };
            var workloadRateSheet = await _unitOfWork.WorkloadRateSheets.Get(q => q.Id == id, includes);

            if (workloadRateSheet == null)
            {
                return NotFound();
            }

            return Ok(workloadRateSheet);
        }

        // PUT: api/WorkloadRateSheets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkloadRateSheet(int id, WorkloadRateSheet workloadRateSheet)
        {
            if (id != workloadRateSheet.Id)
            {
                return BadRequest();
            }

            _unitOfWork.WorkloadRateSheets.Update(workloadRateSheet);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WorkloadRateSheetExists(id))
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

        // POST: api/WorkloadRateSheets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostWorkloadRateSheet(WorkloadRateSheet workloadRateSheet)
        {
            await _unitOfWork.WorkloadRateSheets.Insert(workloadRateSheet);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetWorkloadRateSheet", new { id = workloadRateSheet.Id }, workloadRateSheet);
        }

        // DELETE: api/WorkloadRateSheets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkloadRateSheet(int id)
        {
            var workloadRateSheet = await _unitOfWork.WorkloadRateSheets.Get(q => q.Id == id);
            if (workloadRateSheet == null)
            {
                return NotFound();
            }

            await _unitOfWork.WorkloadRateSheets.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> WorkloadRateSheetExists(int id)
        {
            var workloadRateSheet = await _unitOfWork.WorkloadRateSheets.Get(q => q.Id == id);
            return workloadRateSheet != null;
        }
    }
}
