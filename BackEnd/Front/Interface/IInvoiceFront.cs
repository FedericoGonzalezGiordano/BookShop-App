﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.Front.Interface
{
    public interface IInvoiceFront
    {
        bool InvoiceRegistration(InvoiceModel invoice);

        List<SellerModel> GetSellerList();
        List<ArticleModel> GetArticleList();

        List<CustomerModel> GetCustomerList();
    }
}
