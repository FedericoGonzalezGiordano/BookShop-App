using System;

public class SellerModel
{

	public int IdSeller { get; set; }
    public string NameSeller { get; set; }
    public string LastNameSeller { get; set; }
	public string StreetSeller { get; set; }
    public int StreetNumberSeller { get; set; }
    public NeighborhoodModel Neighborhood { get; set; }
    public int NumberTelephoneSeller { get; set; }
    public string MailSeller { get; set; }
    public DateTime BirthdaySeller { get; set; }




    public SellerModel()
	{
        IdSeller = 0;
        NameSeller = string.Empty;
        LastNameSeller = string.Empty;
        StreetSeller = string.Empty;
        StreetNumberSeller= 0;
        Neighborhood = new NeighborhoodModel();
        NumberTelephoneSeller = 0;
        MailSeller=string.Empty;
        BirthdaySeller=default(DateTime);
	}
}
