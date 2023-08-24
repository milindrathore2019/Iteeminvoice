namespace Iteeminvoice.Model
{
    public class Item
    {
        public int ItemCode { get; set; }
        public string? ItemName { get; set; }
        public string? ItemDiscountInPer { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }

        public Category? Category { get; set; }
    }
}
