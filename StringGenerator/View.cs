using System;

namespace StringGenerator
{
    public class View
    {
        private void ShowResult(string result)
        {
            Console.WriteLine(result);
        }

        private void ShowError()
        {
            Console.WriteLine("Nope");
        }
    }
}