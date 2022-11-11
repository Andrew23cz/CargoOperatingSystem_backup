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
    public class AgentSubmitConsigneesController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentSubmitConsigneesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AgentSubmitConsignees
        [HttpGet]
        public async Task<IActionResult> GetAgentSubmitConsignee()
        {
            var user = _unitOfWork.GetUser(HttpContext);

            if (user.IsInRole("Administrator") || user.IsInRole("CargopointUser"))
            {
                var agentSubmitConsignees = await _unitOfWork.AgentSubmitConsignees.GetAll();
                return Ok(agentSubmitConsignees);
            }
            else
            {
                
                var companyId = _unitOfWork.GetCompanyId(HttpContext).Result;
                Expression<Func<AgentSubmitConsignee, bool>> hasComapnyIdentity = s => s.CompanyIdentity == companyId;
                var agentSubmitConsignees = await _unitOfWork.AgentSubmitConsignees.GetAll(expression: hasComapnyIdentity);
                return Ok(agentSubmitConsignees);
            }
        }

        // GET: api/AgentSubmitConsignees/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgentSubmitConsignee(int id)
        {
                var agentSubmitConsignee = await _unitOfWork.AgentSubmitConsignees.Get(q => q.Id == id);
                
                if (agentSubmitConsignee == null)
                {
                    return NotFound();
                }

                return Ok(agentSubmitConsignee);
            
        }

        // PUT: api/AgentSubmitConsignees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgentSubmitConsignee(int id, AgentSubmitConsignee agentSubmitConsignee)
        {
            if (id != agentSubmitConsignee.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AgentSubmitConsignees.Update(agentSubmitConsignee);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AgentSubmitConsigneeExists(id))
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

        // POST: api/AgentSubmitConsignees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAgentSubmitConsignee(AgentSubmitConsignee agentSubmitConsignee)
        {
            await _unitOfWork.AgentSubmitConsignees.Insert(agentSubmitConsignee);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAgentSubmitConsignee", new { id = agentSubmitConsignee.Id }, agentSubmitConsignee);
        }

        // DELETE: api/AgentSubmitConsignees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgentSubmitConsignee(int id)
        {
            var agentSubmitConsignee = await _unitOfWork.AgentSubmitConsignees.Get(q => q.Id == id);
            if (agentSubmitConsignee == null)
            {
                return NotFound();
            }

            await _unitOfWork.AgentSubmitConsignees.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AgentSubmitConsigneeExists(int id)
        {
            var agentSubmitConsignee = await _unitOfWork.AgentSubmitConsignees.Get(e => e.Id == id);

            return agentSubmitConsignee != null;
        }
    }
}
