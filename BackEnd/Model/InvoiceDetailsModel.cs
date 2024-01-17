using System;

public class InvoiceDetailsModel
{
    public InvoiceModel invoice { get; set; }
    public ArticleModel ArticleCode { get; set; }
    public double UnitPriceInvoice { get; set; }
    public int Amount { get; set; }
    public InvoiceDetailsModel()
	{

	}
}
