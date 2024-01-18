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
    public class InvoiceFront : IInvoiceFront
    {
        private readonly IInvoiceDao dao;
        public InvoiceFront()
        {
             dao=new InvoiceDao();
        }

        public List<ArticleModel> GetArticleList()
        {
            return dao.GetArticlesList();
        }

        public List<CustomerModel> GetCustomerList()
        {
            return dao.GetCustomerList();
        }

        public List<SellerModel> GetSellerList()
        {
            return dao.GetSellerList();
        }

        public bool InvoiceRegistration(InvoiceModel invoice)
        {
            return dao.InvoiceRegistration(invoice);
        }
    }
}
