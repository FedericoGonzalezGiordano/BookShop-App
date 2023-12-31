using BackEnd.DAO.Helper;
using BackEnd.DAO.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
                    int idSeller = int.Parse(row["cod_vendedor"].ToString());
                    string nameSeller = row["nom_vendedor"].ToString();
                    string lastnameSeller = row["ape_vendedor"].ToString();
                    string streetSeller = row["calle"].ToString();
                    int streetNumberSeller = int.Parse(row["altura"].ToString());
                    int idHood = Convert.ToInt32(row["cod_barrio"].ToString());
                    int numberTelephoneSeller = int.TryParse(row["nro_tel"].ToString(), out int resultNumber) ? resultNumber : 0;
                    string mailSeller = row["e-mail"].ToString();
                    DateTime.TryParse(row["fec_nac"].ToString(), out DateTime birthdateSeller);
                    NeighborhoodModel neighborhood = new NeighborhoodModel(idHood, "");


                    SellerModel seller = new SellerModel
                    {
                        IdSeller = idSeller,
                        NameSeller = nameSeller,
                        LastNameSeller = lastnameSeller,
                        StreetSeller = streetSeller,
                        StreetNumberSeller = streetNumberSeller,
                        Neighborhood = neighborhood,
                        NumberTelephoneSeller = numberTelephoneSeller,
                        MailSeller = mailSeller,
                        BirthdaySeller = birthdateSeller
                    };
                    lstSeller.Add(seller);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error in GetSeller: {ex.Message}");
                Console.WriteLine($"StackTrace: {ex.StackTrace}");

            }

            return lstSeller; ;
        }

    }
}
