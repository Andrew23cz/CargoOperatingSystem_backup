using CargoOperatingSystem.Server.Data;
using CargoOperatingSystem.Server.IRepository;
using CargoOperatingSystem.Server.Models;
using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Server.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        private UserManager<ApplicationUser> _userManager;
        private IGenericRepository<Airline> _airlines;
        private IGenericRepository<Arrival> _arrivals;
        private IGenericRepository<AwbStock> _awbstocks;
        private IGenericRepository<Consignee> _consignees;
        private IGenericRepository<Customer> _customers;
        private IGenericRepository<Delivery> _deliveries;
        private IGenericRepository<Pickup> _pickups;
        private IGenericRepository<Dimmension> _dimmensions;
        private IGenericRepository<Hawb> _hawbs;
        private IGenericRepository<Invoice> _invoices;
        private IGenericRepository<Mawb> _mawbs;
        private IGenericRepository<Order> _orders;
        private IGenericRepository<Shipment> _shipments;
        private IGenericRepository<Shipper> _shippers;
        private IGenericRepository<Supplier> _suppliers;
        private IGenericRepository<Workload> _workloads;
        private IGenericRepository<WorkloadRateSheet> _workloadRateSheets;
        private IGenericRepository<AfRates> _afrates;
        private IGenericRepository<Currency> _currencies;
        private IGenericRepository<Charge> _charges;
        private IGenericRepository<ChargeTemplate> _chargeTemplates;
        private IGenericRepository<AgentSubmitModel> _agentSubmitModels;
        private IGenericRepository<AgentSubmitDim> _agentSubmitDims;
        private IGenericRepository<AgentSubmitShipper> _agentSubmitShippers;
        private IGenericRepository<AgentSubmitConsignee> _agentSubmitConsignees;
        private IGenericRepository<AgentSubmitMawb> _agentSubmitMawbs;
        private IGenericRepository<AgentSubmitHawb> _agentSubmitHawbs;

        public UnitOfWork(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
            
        }

        public IGenericRepository<Airline> Airlines => _airlines ??= new GenericRepository<Airline>(_context);
        public IGenericRepository<Arrival> Arrivals => _arrivals ??= new GenericRepository<Arrival>(_context);
        public IGenericRepository<AwbStock> AwbStocks => _awbstocks ??= new GenericRepository<AwbStock>(_context);
        public IGenericRepository<Consignee> Consignees => _consignees ??= new GenericRepository<Consignee>(_context);
        public IGenericRepository<Customer> Customers => _customers ??= new GenericRepository<Customer>(_context);
        public IGenericRepository<Delivery> Deliveries => _deliveries ??= new GenericRepository<Delivery>(_context);
        public IGenericRepository<Pickup> Pickups => _pickups ??= new GenericRepository<Pickup>(_context);
        public IGenericRepository<Dimmension> Dimmensions => _dimmensions ??= new GenericRepository<Dimmension>(_context);
        public IGenericRepository<Hawb> Hawbs => _hawbs ??= new GenericRepository<Hawb>(_context);
        public IGenericRepository<Invoice> Invoices => _invoices ??= new GenericRepository<Invoice>(_context);
        public IGenericRepository<Mawb> Mawbs => _mawbs ??= new GenericRepository<Mawb>(_context);
        public IGenericRepository<Order> Orders => _orders ??= new GenericRepository<Order>(_context);
        public IGenericRepository<Shipment> Shipments => _shipments ??= new GenericRepository<Shipment>(_context);
        public IGenericRepository<Shipper> Shippers => _shippers ??= new GenericRepository<Shipper>(_context);
        public IGenericRepository<Supplier> Suppliers => _suppliers ??= new GenericRepository<Supplier>(_context);
        public IGenericRepository<Workload> Workloads => _workloads ??= new GenericRepository<Workload>(_context);
        public IGenericRepository<WorkloadRateSheet> WorkloadRateSheets => _workloadRateSheets ??= new GenericRepository<WorkloadRateSheet>(_context);
        public IGenericRepository<AfRates> AfRates => _afrates ??= new GenericRepository<AfRates>(_context);
        public IGenericRepository<Currency> Currencies => _currencies ??= new GenericRepository<Currency>(_context);
        public IGenericRepository<Charge> Charges => _charges ??= new GenericRepository<Charge>(_context);
        public IGenericRepository<ChargeTemplate> ChargeTemplates => _chargeTemplates ??= new GenericRepository<ChargeTemplate>(_context);
        public IGenericRepository<AgentSubmitModel> AgentSubmitModels => _agentSubmitModels ??= new GenericRepository<AgentSubmitModel>(_context);
        public IGenericRepository<AgentSubmitDim> AgentSubmitDims => _agentSubmitDims ??= new GenericRepository<AgentSubmitDim>(_context);
        public IGenericRepository<AgentSubmitConsignee> AgentSubmitConsignees => _agentSubmitConsignees ??= new GenericRepository<AgentSubmitConsignee>(_context);
        public IGenericRepository<AgentSubmitShipper> AgentSubmitShippers => _agentSubmitShippers ??= new GenericRepository<AgentSubmitShipper>(_context);
        public IGenericRepository<AgentSubmitMawb> AgentSubmitMawbs => _agentSubmitMawbs ??= new GenericRepository<AgentSubmitMawb>(_context);
        public IGenericRepository<AgentSubmitHawb> AgentSubmitHawbs => _agentSubmitHawbs ??= new GenericRepository<AgentSubmitHawb>(_context);

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save(HttpContext httpContext)
        {
            //var user = httpContext.User.Identity.Name;
            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);

            var entries = _context.ChangeTracker.Entries()
                .Where(q => q.State == EntityState.Modified || q.State == EntityState.Added);

            foreach (var entry in entries)
            {
                ((BaseDomainModel)entry.Entity).DateUpdated = DateTime.Now;
                ((BaseDomainModel)entry.Entity).UpdatedBy = user.UserName;

                if (entry.State == EntityState.Added)
                {
                    ((BaseDomainModel)entry.Entity).DateCreated = DateTime.Now;
                    ((BaseDomainModel)entry.Entity).CreatedBy = user.UserName;
                    ((BaseDomainModel)entry.Entity).CompanyIdentity = user.Company;
                }
            }

            await _context.SaveChangesAsync();
        }

        public async Task<string> GetCompanyId(HttpContext httpContext)
        {
            
            var userId = httpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var user = await _userManager.FindByIdAsync(userId);
            return user.Company;
        }

        public ClaimsPrincipal GetUser(HttpContext httpContext)
        {
            var user = httpContext.User;
            return user;
        }
    }
}
