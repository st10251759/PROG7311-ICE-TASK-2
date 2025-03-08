using PROG7311_OrderProcessingSystem.Models;

namespace PROG7311_OrderProcessingSystem.Services
{
    //2nd Solid Principle
    //Implement Order Processing Service (Open/Closed Principle - OCP)
    public interface IOrderProcessingService
    {
        string ProcessOrder(Order order);
    }
}
