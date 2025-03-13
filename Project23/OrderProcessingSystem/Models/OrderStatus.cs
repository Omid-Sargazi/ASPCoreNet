namespace OrderProcessingSystem.Models
{
    public enum OrderStatus
    {
        Created,
        PaymentProcessing,
        Paid,
        Shipped,
        Delivered,
        Cancelled,
        Refunded
    }
}