using Microsoft.AspNetCore.Mvc;
using PROG7311_OrderProcessingSystem.Models;
using PROG7311_OrderProcessingSystem.Services;

namespace PROG7311_OrderProcessingSystem.Controllers
{
    public class OrderController : Controller
    {
        private readonly IOrderProcessor _orderProcessor;
        private readonly INotificationSender _notificationSender;

        // Constructor Dependency Injection
        public OrderController(IOrderProcessor orderProcessor, INotificationSender notificationSender)
        {
            _orderProcessor = orderProcessor;
            _notificationSender = notificationSender;
        }

        // Display Order Form
        public IActionResult Create()
        {
            return View();
        }

        // Handle Order Submission
        [HttpPost]
        public IActionResult Create(Order order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }

            // Process the order
            string orderResult = _orderProcessor.ProcessOrder(order);

            // Send notification
            string notificationResult = _notificationSender.SendNotification(order);

            // Pass the result message to the view
            ViewBag.Message = orderResult + " " + notificationResult;

            return View("OrderConfirmation", order);
        }
    }
}
