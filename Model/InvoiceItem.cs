namespace Iteeminvoice.Model
{
    public class InvoiceItem
    {
        public int InvoiceItemNo { get; set; }
        public int InvoiceNo { get; set; }
        public int ItemCode { get; set; }
        public int ItemQty { get; set; }
        public decimal ItemUnitPrice { get; set; }
        public decimal ItemDiscount { get; set; }
        public decimal ItemAmount { get; set; }
        public decimal ItemAmountPaid { get; set; }

        public Invoice? Invoice { get; set; }
        public Item? Item { get; set; }
    }
}
