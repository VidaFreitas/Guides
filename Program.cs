using System;

namespace Guides
{
    class Program
    {
        static void Main(string[] args)
        {
            var id = Guid.NewGuid();
            id.ToString();

            id = new Guid("5ff5b871-91db-47d4-9406-c45eb800776e");
            Console.WriteLine(id.ToString().Substring(0, 8));
        }
    }
}
