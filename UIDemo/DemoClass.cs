using System;
using System.Collections.Generic;
using System.Text;

namespace UIDemo
{
    public class DemoClass
    {
        // Define a delegate
        public delegate void CallBack(int i);

        // Communicate the data via delegate
        public void Testing(CallBack obj)
        {
            for (int i = 0; i < 1000; i++)
            {
                obj(i);
            }
        }
    }
}
