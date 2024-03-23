using System;

namespace TriviaApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            TriviaAPIListener listener = new TriviaAPIListener();
            try
            {
                listener.GetData(new TriviaRequest(10, 9, "hard")).Wait();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}