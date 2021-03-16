using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using library;

namespace Extra_task
{
    class Program
    {

        static void Main(string[] args)
        {
            Street[] streetsArray = null;
            Console.WriteLine("Введите количество улиц");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))
                Console.WriteLine("Некорректные данные!");
            try
            {
                using (StreamReader reader = new StreamReader(@"../../../../data.txt"))
                {
                    streetsArray = Validate(n, reader);
                }
            }
            catch(Exception ex)
            {
               Console.WriteLine("Что-то пошло не так! " + ex.Message);
            }
            if (streetsArray != null)
            {
                for (int i = 0; i < streetsArray.Length; i++)
                    Console.WriteLine(streetsArray[i]);

                try
                {
                    Serialization(streetsArray);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Что-то пошло не так! " + ex.Message);
                }
            }

        }
        private static void Serialization(Street[] streets)
        {
            var binFormatter = new BinaryFormatter();
            using(FileStream fs = new FileStream(@"../../../../out.txt", FileMode.OpenOrCreate))
            {
                binFormatter.Serialize(fs, streets);
            }
        }
        private static Street[] Validate(int n, StreamReader reader)
        {
            Street[] streetsArray = new Street[n];
            bool isCorrect = true;
            if (reader.EndOfStream)
                isCorrect = false;
            else
            {
                isCorrect = ReadsFromFile(n, reader, streetsArray, isCorrect);
            }
            if (!isCorrect)
            {
                streetsArray = CreateNewArray(n);
            }
            return streetsArray;
        }

        private static Street[] CreateNewArray(int n)
        {
            Street[] streetsArray;
            Console.WriteLine("Данные в файле \"data.txt\" некорректны!");
            streetsArray = new Street[n];
            Random rnd = new Random();
            for (int i = 0; i < n; i++)
            {
                int cnt = rnd.Next(2, 10);
                int[] houses = new int[cnt];
                for (int j = 0; j < cnt; j++)
                {
                    houses[i] = rnd.Next(1, 101);
                }
                string name = "";
                name += (char)('A' + rnd.Next(26));
                for (int j = 0; j < rnd.Next(1, 8); j++)
                    name += (char)('a' + rnd.Next(26));
                streetsArray[i] = new Street(name, houses);
            }

            return streetsArray;
        }

        private static bool ReadsFromFile(int n, StreamReader reader, Street[] streetsArray, bool isCorrect)
        {
            int streetsCnt = 0;
            for (int i = 0; i < n; i++)
            {
                string[] stringsArr = reader.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (stringsArr.Length == 0)
                    continue;
                int len = stringsArr.Length;
                if (len < 2)
                {
                    isCorrect = false;
                    break;
                }
                int[] houses = new int[len - 1];
                for (int j = 1; j < len; j++)
                {
                    if ((!int.TryParse(stringsArr[j], out int num)) || (num < 1) || (num > 100))
                    {
                        isCorrect = false;
                        break;
                    }
                    houses[j - 1] = num;
                }
                if (!isCorrect)
                    break;
                streetsArray[streetsCnt] = new Street(stringsArr[0], houses);
                streetsCnt++;
            }
            Street[] resultStreetsArray = new Street[streetsCnt];

            for (int i = 0; i < streetsCnt; i++)
                resultStreetsArray[i] = streetsArray[i];
            return isCorrect;
        }
    }
}
