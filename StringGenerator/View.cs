using System;

namespace StringGenerator
{
    public class View
    {
        public void ShowResult(string result)
        {
            Console.WriteLine(result);
        }

        public void ShowError()
        {
            Console.WriteLine("Nope");
        }
    }
}