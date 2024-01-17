using System;

public class InvoiceModel
{
    public int NroInvoice { get; set; }
    public DateTime Date { get; set; }
    public CustomerModel CustomerCode { get; set; }
    public SellerModel SellerCode { get; set; }

    public List<InvoiceDetailsModel> lDetails { get; set; }
    public InvoiceModel()
	{
	}
}
