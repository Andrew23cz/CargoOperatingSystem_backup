using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Authorization;
using CargoOperatingSystem.Server.IRepository;
using System.Linq.Expressions;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser, CustomerUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class AgentSubmitDimsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentSubmitDimsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AgentSubmitDims
        [HttpGet]
        public async Task<IActionResult> GetAgentSubmitDim()
        {
            var agentSubmitDims = await _unitOfWork.AgentSubmitDims.GetAll();
            return Ok(agentSubmitDims);
        }

        // GET: api/AgentSubmitDims/GetAgentSubmitDimsByShipmentId/5
        [HttpGet("{GetAgentSubmitDimsByShipmentId}/{agentSubmitModelId}")]
        public async Task<IActionResult> GetDimensionsByShipmentId(int agentSubmitModelId)
        {
            Expression<Func<AgentSubmitDim, bool>> hasAgentSubmitModelId = s => s.AgentSubmitModelId == agentSubmitModelId;
            var agentSubmitDims = await _unitOfWork.AgentSubmitDims.GetAll(expression: hasAgentSubmitModelId);
            return Ok(agentSubmitDims);
        }

        // GET: api/AgentSubmitDims/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgentSubmitDim(int id)
        {
            var agentSubmitDim = await _unitOfWork.AgentSubmitDims.Get(q => q.Id == id);

            if (agentSubmitDim == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitDim);
        }

        // PUT: api/AgentSubmitDims/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgentSubmitDim(int id, AgentSubmitDim agentSubmitDim)
        {
            if (id != agentSubmitDim.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AgentSubmitDims.Update(agentSubmitDim);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AgentSubmitDimExists(id))
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

        // POST: api/AgentSubmitDims
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAgentSubmitDim(AgentSubmitDim agentSubmitDim)
        {
            await _unitOfWork.AgentSubmitDims.Insert(agentSubmitDim);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAgentSubmitDim", new { id = agentSubmitDim.Id }, agentSubmitDim);
        }

        // DELETE: api/AgentSubmitDims/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgentSubmitDim(int id)
        {
            var agentSubmitDim = await _unitOfWork.AgentSubmitDims.Get(q => q.Id == id);
            if (agentSubmitDim == null)
            {
                return NotFound();
            }

            await _unitOfWork.AgentSubmitDims.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AgentSubmitDimExists(int id)
        {
            var agentSubmitDim = await _unitOfWork.AgentSubmitDims.Get(e => e.Id == id);
            return agentSubmitDim != null;
        }
    }
}
