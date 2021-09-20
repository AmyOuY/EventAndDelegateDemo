using System;
using System.Net.Http.Headers;

namespace UIDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = new Product() { Name = "Apple and orange" };

            // Publisher
            var productPurchaser = new ProductPurchaser();

            // Subscriber
            var emailService = new EmailService();
            var textService = new TextService();

            // Register events
            productPurchaser.ProductPurchased += emailService.OnProductPurchased;
            productPurchaser.ProductPurchased += textService.OnProductPurchased;

            productPurchaser.Purchase(product);

            Console.ReadLine();
        }
    }
}
