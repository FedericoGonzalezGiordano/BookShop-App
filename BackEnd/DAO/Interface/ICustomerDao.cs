using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Interface
{
    public interface ICustomerDao
    {
        bool CustomerRegistration(CustomerModel customer);
        bool CustomerUpdate(CustomerModel customer);
        bool CustomerTermination(int id);
        List<NeighborhoodModel> GetNeighborhood();
        List<CustomerModel> GetCustomer(string nameCustomer,string lastNameCustomer);
        CustomerModel GetCustomerById(int idCliente);
    }
}
