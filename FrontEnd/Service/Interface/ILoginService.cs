using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontEnd.Service.Interface
{
    public interface ILoginService
    {
        Task<List<SellerModel>> GetSellerAsync();
    }
}
