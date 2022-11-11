using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;
using System.Collections.Generic;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class WorkloadsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public WorkloadsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/Workloads
        [HttpGet]
        public async Task<IActionResult> GetWorkloads()
        {
            //var includes = new List<string> {  };
            var workloads = await _unitOfWork.Workloads.GetAll();
            return Ok(workloads);
        }

        // GET: api/Workloads/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetWorkload(int id)
        {
            var includes = new List<string> { "WorkloadRateSheet" };
            var workload = await _unitOfWork.Workloads.Get(q => q.Id == id, includes);

            if (workload == null)
            {
                return NotFound();
            }

            return Ok(workload);
        }

        // PUT: api/Workloads/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutWorkload(int id, Workload workload)
        {
            if (id != workload.Id)
            {
                return BadRequest();
            }

            _unitOfWork.Workloads.Update(workload);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await WorkloadExists(id))
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

        // POST: api/Workloads
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostWorkload(Workload workload)
        {
            await _unitOfWork.Workloads.Insert(workload);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetWorkload", new { id = workload.Id }, workload);
        }

        // DELETE: api/Workloads/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteWorkload(int id)
        {
            var workload = await _unitOfWork.Workloads.Get(q => q.Id == id);
            if (workload == null)
            {
                return NotFound();
            }

            await _unitOfWork.Workloads.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> WorkloadExists(int id)
        {
            var workload = await _unitOfWork.Workloads.Get(q => q.Id == id);
            return workload != null;
        }
    }
}
