using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Interface
{
    public interface IInvoiceDao
    {
        bool InvoiceRegistration(InvoiceModel invoice);
        List<SellerModel> GetSellerList();
        List<CustomerModel> GetCustomerList();
        List<ArticleModel> GetArticlesList();

    }
}
