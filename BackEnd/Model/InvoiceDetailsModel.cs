using System;

public class InvoiceDetailsModel
{
    public int IdDetailsModel { get; set; }
    public ArticleModel Article { get; set; }
    public double UnitPriceInvoice { get; set; }
    public int Amount { get; set; }
    public InvoiceDetailsModel()
	{

	}
}
