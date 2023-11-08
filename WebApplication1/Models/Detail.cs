namespace WebApplication1.Models
{
    public class Detail
    {
        public int detailId {  get; set; }

        public int amount { get; set; }

        public float price { get; set; }

        public float subtotal { get; set; }

        public int productId { get; set; }

        public virtual Product Product { get; set; }

        public int invoiceId { get; set; }
        public virtual Invoice Invoice { get; set; }


    }
}
