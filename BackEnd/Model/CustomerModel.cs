using System;

public class CustomerModel
{
    public int CodCustomer { get; set; }
    public string  NameCustomer { get; set; }
    public string LastNameCustomer { get; set; }
    public string StreetCustomer { get; set; }
    public int StreetNumberCustomer { get; set; }
    public NeighborhoodModel CodNeighborhoodCustomer { get; set; }
    public int TelCustomer { get; set; }
    public string MailCustomer { get;set; }

    public CustomerModel()
    { 
        CodCustomer = 0;
        NameCustomer = string.Empty;
        LastNameCustomer = string.Empty;
        StreetCustomer = string.Empty;
        StreetNumberCustomer= 0;
        CodNeighborhoodCustomer = new NeighborhoodModel();
        TelCustomer = 0;
        MailCustomer = string.Empty;
    }

    public override string ToString()
    {
        return NameCustomer + ", " + LastNameCustomer;
    }




}
