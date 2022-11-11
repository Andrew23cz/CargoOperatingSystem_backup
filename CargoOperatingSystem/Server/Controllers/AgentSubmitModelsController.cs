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
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AgentSubmitModelsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly ILogger<ShipmentsController> _logger;

        public AgentSubmitModelsController(IUnitOfWork unitOfWork, ILogger<ShipmentsController> logger)
        {
            _unitOfWork = unitOfWork;
            _logger = logger;
        }

        // GET: api/AgentSubmitModels/GetAgentSubmitModelsByCompanyIdentity
        //[HttpGet("{GetAgentSubmitModelsByCompanyIdentity}")]
        [HttpGet]
        public async Task<IActionResult> GetAgentSubmitModels()
        {
            var user = _unitOfWork.GetUser(HttpContext);
            var includes = new List<string> { "AgentSubmitDims" };

            if (user.IsInRole("Administrator") || user.IsInRole("CargopointUser"))
            {
                var agentSubmitModels = await _unitOfWork.AgentSubmitModels.GetAll(includes: includes);
                return Ok(agentSubmitModels);
            }
            else
            {
                var companyId = _unitOfWork.GetCompanyId(HttpContext);
                Expression<Func<AgentSubmitModel, bool>> hasComapnyIdentity = s => s.CompanyIdentity == companyId.Result;
                var agentSubmitModels = await _unitOfWork.AgentSubmitModels.GetAll(includes: includes, expression: hasComapnyIdentity);
                return Ok(agentSubmitModels);
            }
        }

        // GET: api/AgentSubmitModels/GetAgentSubmitModelsBySubmit/
        //[HttpGet("{GetAgentSubmitModelsBySubmit}")]
        [HttpGet("{GetAgentSubmitModelsBySubmit}/{submitted}")]
        public async Task<IActionResult> GetAgentSubmitModels(bool submitted)
        {
            var user = _unitOfWork.GetUser(HttpContext);
            var includes = new List<string> { "AgentSubmitDims" };

            if (user.IsInRole("Administrator") || user.IsInRole("CargopointUser"))
            {
                Expression<Func<AgentSubmitModel, bool>> isSubmitted = s => s.Submitted == submitted;
                var agentSubmitModels = await _unitOfWork.AgentSubmitModels.GetAll(includes: includes, expression: isSubmitted);
                return Ok(agentSubmitModels);
            }
            else
            {
                return Forbid();
            }
        }


        // GET: api/AgentSubmitModels/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgentSubmitModel(int id)
        {
            var includes = new List<string> { "AgentSubmitDims" };
            var agentSubmitModel = await _unitOfWork.AgentSubmitModels.Get(q => q.Id == id, includes);

            if (agentSubmitModel == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitModel);
        }

        // PUT: api/AgentSubmitModels/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgentSubmitModel(int id, AgentSubmitModel agentSubmitModel)
        {
            if (id != agentSubmitModel.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AgentSubmitModels.Update(agentSubmitModel);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AgentSubmitModelExists(id))
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

        // POST: api/AgentSubmitModels
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAgentSubmitModel(AgentSubmitModel agentSubmitModel)
        {
            await _unitOfWork.AgentSubmitModels.Insert(agentSubmitModel);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAgentSubmitModel", new { id = agentSubmitModel.Id }, agentSubmitModel);
        }

        // DELETE: api/AgentSubmitModels/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgentSubmitModel(int id)
        {
            var agentSubmitModel = await _unitOfWork.AgentSubmitModels.Get(q => q.Id == id);
            if (agentSubmitModel == null)
            {
                return NotFound();
            }

            await _unitOfWork.AgentSubmitModels.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AgentSubmitModelExists(int id)
        {
            var agentSubmitModel = await _unitOfWork.AgentSubmitModels.Get(q => q.Id == id);
            return agentSubmitModel == null;
        }
    }
}
