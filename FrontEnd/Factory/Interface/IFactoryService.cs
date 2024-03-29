﻿using FrontEnd.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Factory.Interface
{
    public interface IFactoryService
    {

        IArticleService CreateArticleService();
        ILoginService CreateLoginService();
        ICustomerService GetCustomerService();

        IInvoiceService GetInvoiceService();
    }
}
