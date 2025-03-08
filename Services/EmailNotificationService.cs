using PROG7311_OrderProcessingSystem.Models;

namespace PROG7311_OrderProcessingSystem.Services
{
    public class EmailNotificationService : INotificationSender
    {
        public string SendNotification(Order order)
        {
            return $"Email: Order {order.OrderId} for {order.CustomerName} has been processed.";
        }
    }
}