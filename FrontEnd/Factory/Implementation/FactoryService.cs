using FrontEnd.Factory.Interface;
using FrontEnd.Service.Implementation;
using FrontEnd.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Factory.Implementation
{
    public class FactoryService : IFactoryService
    {


        public ILoginService CreateLoginService()
        {
            return new LoginService();
        }

        public ICustomerService GetCustomerService()
        {
            return new CustomerService();
        }


    }
}
