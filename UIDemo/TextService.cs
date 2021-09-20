using System;
using System.Collections.Generic;
using System.Text;

namespace UIDemo
{
    public class TextService
    {
        public void OnProductPurchased(object source, ProductEventArgs e)
        {
            Console.WriteLine("Text service is sending a text about the purchase of product " + e.Product.Name);
        }
    }
}
