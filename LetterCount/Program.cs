using System;

namespace LetterCount
{
    class Program
    {
        static void Main(string[] args)
        {
            var counter = new StringCharacterCounter();
            var text = "something";
            while (!string.IsNullOrWhiteSpace(text))
            {
                text = Console.ReadLine();
                counter.Count(text);
                counter.Show();
            }
        }
    }
}
