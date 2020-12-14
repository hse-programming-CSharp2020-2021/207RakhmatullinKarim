using System;
namespace Task_1
{
    public class UserString
    {
        string str;
        public UserString(int k, char minChar, char maxChar)
        {
            if (k < 0)
                throw new Exception("Аргумент метода должен быть положительным!");
            // minChar, minChar - границы диапазона символов
            if (maxChar < minChar)
            {
                char c = minChar;
                minChar = maxChar;
                maxChar = c;
            }
            // пустая строка, останется пустой, если символов 0
            str = String.Empty;
            for (int i = 0; i < k; i++)
                str += (char)gen.Next(minChar, maxChar + 1);
        }
        static Random gen = new Random();
        // Удалить из строки s1 все символы другой строки s2:
        public void MoveOff(string s)
        {
            int index;
            for (int i = 0; i < s.Length; i++)
                while ((index = str.IndexOf(s[i])) >= 0)
                    str = str.Remove(index, 1);
        } // end of MoveOff()
        public override string ToString()
        {
            return str;
        }


    }
}
