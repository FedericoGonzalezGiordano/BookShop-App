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
    public class LoginFront : ILoginFront
    {
        private ILoginDao _dao;
        public LoginFront()
        {
                _dao = new LoginDao();
        }
        public List<SellerModel> GetSeller()
        {
            return _dao.GetSeller();
        }
    }
}
