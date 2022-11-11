using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CargoOperatingSystem.Shared.Domain;
using CargoOperatingSystem.Server.IRepository;
using Microsoft.AspNetCore.Authorization;
using System.Linq.Expressions;

namespace CargoOperatingSystem.Server.Controllers
{
    [Authorize(Roles = "Administrator, CargopointUser, CustomerUser")]
    [Route("api/[controller]")]
    [ApiController]
    public class AgentSubmitMawbsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentSubmitMawbsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AgentSubmitMawbs
        [HttpGet]
        public async Task<IActionResult> GetAgentSubmitMawb()
        {
            var user = _unitOfWork.GetUser(HttpContext);

            if (user.IsInRole("Administrator") || user.IsInRole("CargopointUser"))
            {
                var agentSubmitMawbs = await _unitOfWork.AgentSubmitMawbs.GetAll();
                return Ok(agentSubmitMawbs);
            }
            else
            {

                var companyId = _unitOfWork.GetCompanyId(HttpContext).Result;
                Expression<Func<AgentSubmitMawb, bool>> hasComapnyIdentity = s => s.CompanyIdentity == companyId;
                var agentSubmitMawb = await _unitOfWork.AgentSubmitMawbs.GetAll(expression: hasComapnyIdentity);
                return Ok(agentSubmitMawb);
            }

            
        }

        // GET: api/AgentSubmitMawbs/297-11112222
        [HttpGet("{GetAgentSubmitMawbByAwb}/{awb}")]

        public async Task<IActionResult> GetAgentSubmitMawb(string awb)
        {
            System.Diagnostics.Debug.Print($"awbNumber ==============> {awb}");

            var agentSubmitMawb = await _unitOfWork.AgentSubmitMawbs.Get(q => q.AwbNumber == awb);

            if (agentSubmitMawb == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitMawb);
        }

        // GET: api/AgentSubmitMawbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgentSubmitMawb(int id)
        {
            
            var agentSubmitMawb = await _unitOfWork.AgentSubmitMawbs.Get(q => q.Id == id);

            if (agentSubmitMawb == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitMawb);
        }

        // PUT: api/AgentSubmitMawbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgentSubmitMawb(int id, AgentSubmitMawb agentSubmitMawb)
        {
            if (id != agentSubmitMawb.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AgentSubmitMawbs.Update(agentSubmitMawb);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AgentSubmitMawbExists(id))
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

        // POST: api/AgentSubmitMawbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAgentSubmitMawb(AgentSubmitMawb agentSubmitMawb)
        {
            await _unitOfWork.AgentSubmitMawbs.Insert(agentSubmitMawb);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAgentSubmitMawb", new { id = agentSubmitMawb.Id }, agentSubmitMawb);
        }

        // DELETE: api/AgentSubmitMawbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgentSubmitMawb(int id)
        {
            var agentSubmitMawb = await _unitOfWork.AgentSubmitMawbs.Get(q => q.Id == id);
            if (agentSubmitMawb == null)
            {
                return NotFound();
            }

            await _unitOfWork.AgentSubmitMawbs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AgentSubmitMawbExists(int id)
        {
            var agentSubmitMawb = await _unitOfWork.AgentSubmitMawbs.Get(q => q.Id == id);
            return agentSubmitMawb == null;
        }
    }
}
