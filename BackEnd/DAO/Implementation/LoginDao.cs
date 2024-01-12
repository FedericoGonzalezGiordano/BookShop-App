using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BackEnd.DAO.Implementation
{
    public class LoginDao : ILoginDao
    {

        public List<SellerModel> GetSeller()
        {
            List<SellerModel> lstSeller = new List<SellerModel>();
            try
            {
                DataTable table = HelperDao.GetInstance().GetConsult("Sp_Obtener_Vendedores", CommandType.StoredProcedure);
                foreach (DataRow row in table.Rows)
                {
                    SellerModel seller = new SellerModel
                    {
                        IdSeller = Convert.ToInt32(row["cod_vendedor"]),
                        NameSeller = row["nom_vendedor"].ToString(),
                        LastNameSeller = row["ape_vendedor"].ToString(),
                        StreetSeller = row["calle"].ToString(),
                        StreetNumberSeller = Convert.ToInt32(row["altura"]),
                        Neighborhood = new NeighborhoodModel
                        {
                            CodNeighborHood = row["cod_barrio"] != DBNull.Value ? Convert.ToInt32(row["cod_barrio"]) : 0,
                            NameNeighborhood = row["NombreBarrio"].ToString()
                        },
                        NumberTelephoneSeller = row["nro_tel"] != DBNull.Value ? Convert.ToInt32(row["nro_tel"]) : 0,
                        MailSeller = row["e-mail"].ToString(),
                        BirthdaySeller = DateTime.TryParse(row["fec_nac"].ToString(), out DateTime birthdateSeller) ? birthdateSeller : DateTime.MinValue,
                        PasswordSeller = row["contrasenia"].ToString()
                    };

                    lstSeller.Add(seller);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSeller: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");
            }

            return lstSeller;
        }


    }
}
