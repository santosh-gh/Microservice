using System.Collections.Generic;
using System.Threading.Tasks;
using NetCoreWeb.Models;

namespace NetCoreWeb.Services
{
    public interface ICustomerService
    {
        Task<IList<CustomerModel>> List();
        Task<CustomerModel> GetCustomer(int id);
        Task SaveCustomer(CustomerModel customer);
    }
}