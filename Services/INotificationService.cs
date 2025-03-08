using PROG7311_OrderProcessingSystem.Models;

namespace PROG7311_OrderProcessingSystem.Services
{
    //3rd Solid Principle
    //Implement Notification Service (Liskov Substitution Principle - LSP)
    public interface INotificationService
    {
        string SendOrderNotification(Order order);
    }
}
