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

        public bool CustomerTermination(string number)
        {
            return dao.CustomerTermination(number);
        }

        public bool CustomerUpdate(CustomerModel customer)
        {
            return dao.CustomerUpdate(customer);
        }
    }
}
