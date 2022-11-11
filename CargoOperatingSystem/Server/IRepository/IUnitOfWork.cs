using CargoOperatingSystem.Shared.Domain;
using Microsoft.AspNetCore.Http;
using System;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CargoOperatingSystem.Server.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        Task Save(HttpContext httpContext);
        Task<string> GetCompanyId(HttpContext httpContext);
        ClaimsPrincipal GetUser(HttpContext httpContext);

        IGenericRepository<Airline> Airlines { get; }
        IGenericRepository<AwbStock> AwbStocks { get; }
        IGenericRepository<Arrival> Arrivals { get; }
        IGenericRepository<Consignee> Consignees { get; }
        IGenericRepository<Customer> Customers { get; }
        IGenericRepository<Delivery> Deliveries { get; }
        IGenericRepository<Pickup> Pickups { get; }
        IGenericRepository<Dimmension> Dimmensions { get; }
        IGenericRepository<Hawb> Hawbs { get; }
        IGenericRepository<Invoice> Invoices { get; }
        IGenericRepository<Mawb> Mawbs { get; }
        IGenericRepository<Order> Orders { get; }
        IGenericRepository<Shipment> Shipments { get; }
        IGenericRepository<Shipper> Shippers { get; }
        IGenericRepository<Supplier> Suppliers { get; }
        IGenericRepository<Workload> Workloads { get; }
        IGenericRepository<WorkloadRateSheet> WorkloadRateSheets { get; }
        IGenericRepository<AfRates> AfRates { get; }
        IGenericRepository<Currency> Currencies { get; }
        IGenericRepository<Charge> Charges { get; }
        IGenericRepository<ChargeTemplate> ChargeTemplates { get; }
        IGenericRepository<AgentSubmitModel> AgentSubmitModels { get; }
        IGenericRepository<AgentSubmitDim> AgentSubmitDims { get; }
        IGenericRepository<AgentSubmitConsignee> AgentSubmitConsignees { get; }
        IGenericRepository<AgentSubmitShipper> AgentSubmitShippers { get; }
        IGenericRepository<AgentSubmitMawb> AgentSubmitMawbs { get; }
        IGenericRepository<AgentSubmitHawb> AgentSubmitHawbs { get; }



    }
}
