using System;
namespace Task_2
{
    public class MyAbbreviation
    {
        public MyAbbreviation()
        {
        }
        // проверка, что строки состоят только из символов латинского алфавита
        // и пробелом
        public static bool Validate(string str)
        {
            char[] englishBig = new char[27];
            char[] englishSmall = new char[27];
            englishSmall[0] = ' ';
            englishBig[0] = ' ';
            for (int i = 1; i < englishSmall.Length; i++)
            {
                englishSmall[i] = (char)('a' + i);
                englishBig[i] = (char)('A' + i);
            }
            if ((str.IndexOfAny(englishSmall) < 0) || (str.IndexOfAny(englishBig) < 0))
            {
                return false;
            }
            return true;
        } // end of Validate(string)
          // получение массива строк
          // каждый элемент проверен на соответствие формату
        public static string[] ValidatedSplit(string str, char ch)
        {
            string[] output = null;
            output = str.Split(ch);
            foreach (string s in output)
            {
                if (!Validate(s)) return null;
            }
            return output;
        } // end of ValidatdSplit(string, char)
        // Обрезка строки по первому гласному
        public static string Shorten(string str)
        {
            char[] alph = { 'a', 'e', 'i', 'o', 'u', 'y', 'A', 'E', 'I', 'O',
            'U', 'Y'};
            int ind = str.IndexOfAny(alph);
            return str.Substring(0, ind + 1);
        } // end of Shorten(string)
          // Метод создания аббревиатуры для ПОДстроки (в ней много слов)
        public static string Abbrevation(string str)
        {
            string output = String.Empty;
            if (str != String.Empty)
            {
                string[] tmp = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                foreach (string s in tmp)
                {
                    string shortenS = Shorten(s);
                    FirstUpcase(ref shortenS);
                    output += shortenS;
                }
            }
            return output;
        } // end of Abbrevation(string)
        public static void FirstUpcase(ref string str)
        {
            // TODO: буквы после первой могут быть не приведены к нижнему
            // регистру
            char[] chars = str.ToCharArray();
            str = str[0].ToString().ToUpper() + str.Substring(1);
        } // end of FirstUpcase(ref string)




    }
}
