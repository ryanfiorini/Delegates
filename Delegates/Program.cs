using System;

namespace Delegates
{
    public delegate void MyDelegate();
    public delegate void ShowTextDelegate(string text);

    class Program
    {
        public static void Method1()
        {
            Console.WriteLine("Inside Method1...");
        }
        public static void Method2()
        {
            Console.WriteLine("Inside Method2...");
        }
        public static void ShowText(string text)
        {
            Console.WriteLine(text);
        }

        static void Main()
        {
            MyDelegate d = null;
            d += Method1;
            d += Method2;
            d.Invoke();

            ShowTextDelegate d2 = new ShowTextDelegate(ShowText);
            d2("Hello World...");
        }
    }
}
