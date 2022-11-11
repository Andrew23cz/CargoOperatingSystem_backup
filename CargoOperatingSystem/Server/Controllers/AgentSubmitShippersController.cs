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
    public class AgentSubmitShippersController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentSubmitShippersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AgentSubmitShippers
        [HttpGet]
        public async Task<IActionResult> GetAgentSubmitShipper()
        {
            var user = _unitOfWork.GetUser(HttpContext);

            if (user.IsInRole("Administrator") || user.IsInRole("CargopointUser"))
            {
                var agentSubmitShippers = await _unitOfWork.AgentSubmitShippers.GetAll();
                return Ok(agentSubmitShippers);
            }
            else
            {

                var companyId = _unitOfWork.GetCompanyId(HttpContext).Result;
                Expression<Func<AgentSubmitShipper, bool>> hasComapnyIdentity = s => s.CompanyIdentity == companyId;
                var agentSubmitShippers = await _unitOfWork.AgentSubmitShippers.GetAll(expression: hasComapnyIdentity);
                return Ok(agentSubmitShippers);
            }
        }

        // GET: api/AgentSubmitShippers/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgentSubmitShipper(int id)
        {
            var agentSubmitShipper = await _unitOfWork.AgentSubmitShippers.Get(q => q.Id == id);

            if (agentSubmitShipper == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitShipper);
        }

        // PUT: api/AgentSubmitShippers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgentSubmitShipper(int id, AgentSubmitShipper agentSubmitShipper)
        {
            if (id != agentSubmitShipper.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AgentSubmitShippers.Update(agentSubmitShipper);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AgentSubmitShipperExists(id))
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

        // POST: api/AgentSubmitShippers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAgentSubmitShipper(AgentSubmitShipper agentSubmitShipper)
        {
            await _unitOfWork.AgentSubmitShippers.Insert(agentSubmitShipper);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAgentSubmitShipper", new { id = agentSubmitShipper.Id }, agentSubmitShipper);
        }

        // DELETE: api/AgentSubmitShippers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgentSubmitShipper(int id)
        {
            var agentSubmitShipper = await _unitOfWork.AgentSubmitShippers.Get(q => q.Id == id);
            if (agentSubmitShipper == null)
            {
                return NotFound();
            }

            await _unitOfWork.AgentSubmitShippers.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AgentSubmitShipperExists(int id)
        {
            var agentSubmitShipper = await _unitOfWork.AgentSubmitShippers.Get(q => q.Id == id);
            return agentSubmitShipper == null;
        }
    }
}
