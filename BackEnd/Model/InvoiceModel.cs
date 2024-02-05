using System;

public class InvoiceModel
{
    public int NroInvoice { get; set; }
    public DateTime Date { get; set; }
    public CustomerModel Customer { get; set; }
    public SellerModel Seller { get; set; }
    public string Status { get; set; }

    public List<InvoiceDetailsModel> lDetails { get; set; }
    public InvoiceModel()
	{
        lDetails = new List<InvoiceDetailsModel>();
	}
}
