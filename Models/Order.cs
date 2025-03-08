namespace PROG7311_OrderProcessingSystem.Models
{
    //1st Solid Principle
    //Define Models (Single Responsibility Principle - SRP)
    public class Order
    {
        public int OrderId { get; set; } //unique order id
        public string CustomerName { get; set; } //customer name
        public string ProductName { get; set; } //product name
        public int Quantity { get; set; } //quanity of product
        public decimal Price { get; set; } //product price
        public DateTime OrderDate { get; set; } = DateTime.Now;
    }
}
