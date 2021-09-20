using System;
using System.Collections.Generic;
using System.Text;

namespace UIDemo
{
    public class EmailService
    {
        public void OnProductPurchased(object source, ProductEventArgs e)
        {
            Console.WriteLine("Email service is sending an email about purchase of the product " + e.Product.Name);
        }
    }
}
