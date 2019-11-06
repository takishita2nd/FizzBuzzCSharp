using System;

namespace FizzBuzzCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 150; i++) {
                string text = String.Empty;
                if (i < 100) {
                    if (i % 3 == 0 ||
                        String.Format("{0}", i).Contains("3")) {
                        text = String.Format("{0:00!}", i);
                    } else {
                        text = String.Format("{0:000}", i);
                    }
                } else {
                    text = String.Format("{0:000}", i);
                }
                Console.WriteLine(text);
            }
        }
    }
}
