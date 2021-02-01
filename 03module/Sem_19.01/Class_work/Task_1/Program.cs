using System;
using System.Text;

namespace Task_1
{
    delegate string ConvertRule(string str);
    class Converter
    {
        public string Convert(string str, ConvertRule cr)
        {
            return cr(str);
        }
    }
    class Program
    {
        public static string RemoveDigits(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            for(int i = 0; i < 17; i++)
            {
                if ((sb[i] >= '0') && (sb[i] <= '9'))
                {
                    sb.Remove(sb[i], 1);
                }
            }
            return sb.ToString();
        }
        public static string RemoveSpaces(string str)
        {
            StringBuilder sb = new StringBuilder(str);
            sb.Replace(" ", "");
            return sb.ToString();
        }
        static void Main(string[] args)
        {
            string[] testArr = { "fds4 3 eee 2 3334", "dfs4fe321 f", "dsffe", "sd sfgt5 4" };
            //ConvertRule del = RemoveDigits;
            //Array.ForEach(testArr, (el) => Console.Write(del(el) + "\t"));
            //del = RemoveSpaces;
            //Array.ForEach(testArr, (el) => Console.Write(del(el) + "\t"));
            Console.WriteLine(RemoveDigits(testArr[0]));
        }
    }
}
