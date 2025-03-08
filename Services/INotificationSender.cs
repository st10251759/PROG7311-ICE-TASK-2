using PROG7311_OrderProcessingSystem.Models;

namespace PROG7311_OrderProcessingSystem.Services
{
    //4th Solid Principle
    //Apply Interface Segregation Principle (ISP)
    public interface INotificationSender
    {
        string SendNotification(Order order);
    }
}
