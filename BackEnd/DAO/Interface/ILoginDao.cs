﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Interface
{
    public interface ILoginDao
    {
        List<SellerModel> GetSeller();
    }
}
