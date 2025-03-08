using PROG7311_OrderProcessingSystem.Models;

namespace PROG7311_OrderProcessingSystem.Services
{
    //2nd Solid Principle
    //Implement Order Processing Service (Open/Closed Principle - OCP)
    public class OrderProcessingService : IOrderProcessor
    {
        public string ProcessOrder(Order order)
        {
            decimal totalAmount = order.Quantity * order.Price; //calculation for total amount 
            return $"Order for {order.ProductName} placed successfully. Total: ${totalAmount}"; //display of total amount
        }
    }
}
