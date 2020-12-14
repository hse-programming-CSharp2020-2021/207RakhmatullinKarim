using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Validate.GetIntValue("Input count of digits: ");
            UserString str = new UserString(n, '0', '9');
            Console.WriteLine(str);
            str.MoveOff("02468");
            Console.WriteLine(str);
        }
    }
}
