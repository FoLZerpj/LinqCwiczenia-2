using System;

namespace LinqTutorials
{
    class Program
    {
        static void Main(string[] args)
        {
            var t = LinqTasks.Task16();
            foreach (var v in t)
            {
                Console.WriteLine(v);
            }
        }
    }
}
