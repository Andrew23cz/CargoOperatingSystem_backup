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
    public class AgentSubmitHawbsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public AgentSubmitHawbsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET: api/AgentSubmitHawbs
        [HttpGet]
        public async Task<IActionResult> GetAgentSubmitHawb()
        {
            var user = _unitOfWork.GetUser(HttpContext);

            if (user.IsInRole("Administrator") || user.IsInRole("CargopointUser"))
            {
                var agentSubmitHawbs = await _unitOfWork.AgentSubmitHawbs.GetAll();
                return Ok(agentSubmitHawbs);
            }
            else
            {

                var companyId = _unitOfWork.GetCompanyId(HttpContext);
                Expression<Func<AgentSubmitHawb, bool>> hasComapnyIdentity = s => s.CompanyIdentity == companyId.Result;
                var agentSubmitHawbs = await _unitOfWork.AgentSubmitHawbs.GetAll(expression: hasComapnyIdentity);
                return Ok(agentSubmitHawbs);
            }
        }

        // GET: api/AgentSubmitHawbs/297-11112222
        [HttpGet("{GetHawbByAwbNumber}/{awb}")]

        public async Task<IActionResult> GetAgentSubmitHawb(string awb)
        {
            System.Diagnostics.Debug.Print($"awbNumber ==============> {awb}");

            var agentSubmitHawb = await _unitOfWork.AgentSubmitHawbs.GetAll(q => q.AwbNumber == awb);

            if (agentSubmitHawb == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitHawb);
        }

        // GET: api/AgentSubmitHawbs/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAgentSubmitHawb(int id)
        {
            var agentSubmitHawb = await _unitOfWork.AgentSubmitHawbs.Get(q => q.Id == id);

            if (agentSubmitHawb == null)
            {
                return NotFound();
            }

            return Ok(agentSubmitHawb);
        }

        // PUT: api/AgentSubmitHawbs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgentSubmitHawb(int id, AgentSubmitHawb agentSubmitHawb)
        {
            if (id != agentSubmitHawb.Id)
            {
                return BadRequest();
            }

            _unitOfWork.AgentSubmitHawbs.Update(agentSubmitHawb);

            try
            {
                await _unitOfWork.Save(HttpContext);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await AgentSubmitHawbExists(id))
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

        // POST: api/AgentSubmitHawbs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<IActionResult> PostAgentSubmitHawb(AgentSubmitHawb agentSubmitHawb)
        {
            await _unitOfWork.AgentSubmitHawbs.Insert(agentSubmitHawb);
            await _unitOfWork.Save(HttpContext);

            return CreatedAtAction("GetAgentSubmitHawb", new { id = agentSubmitHawb.Id }, agentSubmitHawb);
        }

        // DELETE: api/AgentSubmitHawbs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgentSubmitHawb(int id)
        {
            var agentSubmitHawb = await _unitOfWork.AgentSubmitHawbs.Get(q => q.Id == id);
            if (agentSubmitHawb == null)
            {
                return NotFound();
            }

            await _unitOfWork.AgentSubmitHawbs.Delete(id);
            await _unitOfWork.Save(HttpContext);

            return NoContent();
        }

        private async Task<bool> AgentSubmitHawbExists(int id)
        {
            var agentSubmitHawb = await _unitOfWork.AgentSubmitHawbs.Get(e => e.Id == id);
            return agentSubmitHawb == null;
        }
    }
}
