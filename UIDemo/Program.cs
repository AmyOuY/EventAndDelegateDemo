using System;
using System.Net.Http.Headers;
using System.Threading;

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


            Thread.Sleep(5000);

            DemoClass demo = new DemoClass();
            demo.Testing(CallBack);


            Console.ReadLine();
        }


        static void CallBack(int i)
        {
            Console.WriteLine(i);
        }
    }
}
