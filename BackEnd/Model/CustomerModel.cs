using System;

public class CustomerModel
{
    public int CodCustomer { get; set; }
    public string  NameCustomer { get; set; }
    public string LastNameCustomer { get; set; }
    public string StreetCustomer { get; set; }
    public int StreetNumberCustomer { get; set; }
    public NeighborhoodModel Neighborhood { get; set; }
    public long TelCustomer { get; set; }
    public string MailCustomer { get;set; }
    public string CompleteName
    {
        get
        {
            return NameCustomer + " " + LastNameCustomer;
        }
    }
    public CustomerModel()
    { 
     
    }

   




}
