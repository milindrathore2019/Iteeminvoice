namespace Iteeminvoice.Model
{
    public class Invoice
    {

        public int InvoiceNo { get; set; }
        public DateTime InvoiceDateTime { get; set; }
        public string? InvoiceCustomerName { get; set; }
        public string? InvoiceCustomerRemNo { get; set; }
        public string? InvoicePaymentMode { get; set; }
    }
}
