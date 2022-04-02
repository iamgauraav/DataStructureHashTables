using System;

namespace DSHashTables
{/// <summary>
/// UC1 : Ability to find frequency of words
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "to");
            hash.Add("5", "be");

            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:" + hash5);


            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value:" + hash2);
        }
    }
}
