using BackEnd.DAO.Implementation;
using BackEnd.DAO.Interface;
using BackEnd.Front.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Front.Implementation
{
    public class CustomerFront:ICustomerFront
    {
        private ICustomerDao dao;
        public CustomerFront() 
        {
            dao=new CustomerDao();
        }

        public bool CustomerRegistration(CustomerModel customer)
        {
            return dao.CustomerRegistration(customer);
        }

        public List<CustomerModel> GetCustomer(string nameCustomer, string lastNameCustomer)
        {
            return dao.GetCustomer(nameCustomer, lastNameCustomer);
        }

        public List<NeighborhoodModel> GetNeighborhood()
        {
            return dao.GetNeighborhood();
        }
        


    }
}
