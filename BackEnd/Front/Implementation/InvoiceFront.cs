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
        public bool InvoiceRegistration(InvoiceModel invoice)
        {
            return dao.InvoiceRegistration(invoice);
        }
    }
}
