using System;

namespace DSHashTables
{/// <summary>
/// UC3 : Ability to remove a  words in paragraph
/// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            MyMapNode<string, string> hash = new MyMapNode<string, string>(18);
            //“Paranoids are not paranoid because they are paranoid but
            //because they keep putting themselves deliberately into paranoid avoidable situations”
            hash.Add("0", "Paranoids");
            hash.Add("1", "are");
            hash.Add("2", "not");
            hash.Add("3", "paranoid");
            hash.Add("4", "because");
            hash.Add("5", "they");
            hash.Add("6", "are");
            hash.Add("7", "paranoid");
            hash.Add("8", "but");
            hash.Add("9", "because");
            hash.Add("10", "they");
            hash.Add("11", "keep");
            hash.Add("12", "putting");
            hash.Add("13", "themselves");
            hash.Add("14", "deliberately");
            hash.Add("15", "into");
            hash.Add("16", "paranoid");
            hash.Add("17", "avoidable");
            hash.Add("18", "situations");

            hash.Remove("17");

            string hash0 = hash.Get("0");
            Console.WriteLine("0th index value:" + hash0);
            string hash1 = hash.Get("1");
            Console.WriteLine("1th index value:" + hash1);
            string hash2 = hash.Get("2");
            Console.WriteLine("2th index value:" + hash2);
            string hash3 = hash.Get("3");
            Console.WriteLine("3th index value:" + hash3);
            string hash4 = hash.Get("4");
            Console.WriteLine("4th index value:" + hash4);
            string hash5 = hash.Get("5");
            Console.WriteLine("5th index value:" + hash5);
            string hash6 = hash.Get("6");
            Console.WriteLine("6th index value:" + hash6);
            string hash7 = hash.Get("7");
            Console.WriteLine("7th index value:" + hash7);
            string hash8 = hash.Get("8");
            Console.WriteLine("8th index value:" + hash8);
            string hash9 = hash.Get("9");
            Console.WriteLine("9th index value:" + hash9);
            string hash10 = hash.Get("10");
            Console.WriteLine("10th index value:" + hash10);
            string hash11 = hash.Get("11");
            Console.WriteLine("11th index value:" + hash11);
            string hash12 = hash.Get("12");
            Console.WriteLine("12th index value:" + hash12);
            string hash13 = hash.Get("13");
            Console.WriteLine("13th index value:" + hash13);
            string hash14 = hash.Get("14");
            Console.WriteLine("14th index value:" + hash14);
            string hash15 = hash.Get("15");
            Console.WriteLine("15th index value:" + hash15);
            string hash16 = hash.Get("16");
            Console.WriteLine("16th index value:" + hash16);
            string hash17 = hash.Get("17");
            Console.WriteLine("17th index value:" + hash17);
            string hash18 = hash.Get("18");
            Console.WriteLine("18th index value:" + hash18);


           








        }
    }
}
