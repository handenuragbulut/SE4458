namespace HandenurAgbulutMidterm.Models
{
    public class Subscriber
    {
        public int BillId { get; set; }
        public int SubscriberId { get; set; }
        public DateTime Month { get; set; }
        public decimal TotalAmount { get; set; }
        public string Details { get; set; }
        public bool PaidStatus { get; set; }
    }
}
