using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UIDemo
{
    public class ProductPurchaser
    {
        //// Define a delegate
        //public delegate void ProductPurchasedHandler(object source, ProductEventArgs e);

        //// Define an evnet based on the delegate
        //public event ProductPurchasedHandler ProductPurchased;

        // Combine above two steps into one
        public event EventHandler<ProductEventArgs> ProductPurchased;

        // Raise the event
        public void Purchase(Product product)
        {
            Console.WriteLine("Purchasing the product...");
            Thread.Sleep(5000);

            // Publish the event
            OnProductPurchased(product);
        }


        protected virtual void OnProductPurchased(Product product)
        {
            ProductPurchased?.Invoke(this, new ProductEventArgs() { Product = product });
        }
    }
}
