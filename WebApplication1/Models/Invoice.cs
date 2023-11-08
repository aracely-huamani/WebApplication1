namespace WebApplication1.Models
{
    public class Invoice
    {
        public int invoiceId {  get; set; }

        public DateTime date { get; set; }

        public string invoiceNumber { get; set; }

        public float total { get; set; }

        public int customerId { get; set; }

        public virtual Customer Costumer

        { get; set; }
    }
}
