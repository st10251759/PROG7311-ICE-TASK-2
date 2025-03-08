using PROG7311_OrderProcessingSystem.Models;

namespace PROG7311_OrderProcessingSystem.Services
{
    //4th Solid Principle
    //Apply Interface Segregation Principle (ISP)
    public interface IOrderProcessor
    {
        string ProcessOrder(Order order);
    }
}
