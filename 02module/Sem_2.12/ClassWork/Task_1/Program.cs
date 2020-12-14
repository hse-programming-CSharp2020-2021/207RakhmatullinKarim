using System;
using System.IO;
using System.Collections.Generic;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    Console.WriteLine(Path.GetExtension(""));
            //}
            //catch(ArgumentException arg)
            //{
            //    Console.WriteLine("Argument");
            //}
            // InvalidOperationException.
            //try
            //{
            //    List<int> list = new List<int>{ 1, 2, 3 };
            //    foreach(int n in list)
            //    {
            //        list.Add(n);
            //    }
            //}
            //catch(InvalidOperationException)
            //{
            //    Console.WriteLine("InvalidOperationException");
            //}
            // NullReferenceException.
            try
            {
                String[] strings = { "hi", "lol", null, "HO" };
                int res = 0;
                for(int i = 0; i < strings.Length; i++)
                {
                    res += strings[i].Length;
                }
            }
            catch(NullReferenceException){
                Console.WriteLine("NullReferenceException");
            }
            // ArgumentNullException

        }
    }
}
