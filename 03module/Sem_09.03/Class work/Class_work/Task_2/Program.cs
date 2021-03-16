using System;
using System.IO;

namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 10;
            string[] arr = new string[size];
            for(int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next().ToString();
            }
            // 1
            string firstPath = @"...\first.txt";
            for(int i = 0; i < size; i++)
            {
                File.WriteAllLines(firstPath, arr);
            }
            // Reading
            //int sum = 0;
            //for(int i = 0; i < size; i++)
            //{
            //    int x = int.Parse(File.Read)
            //}
            // 2
            string text = "";
            for(int i = 0; i < size; i++)
            {
                text += arr[i];
            }
            string secondPath = @"...\second.txt";
            using (FileStream fs = new FileStream(secondPath, FileMode.OpenOrCreate))
            {
                int j = 0;
                for(int i = 0; i < size; i++)
                {
                    byte[] array = System.Text.Encoding.Default.GetBytes(text);
                    // запись массива байтов в файл
                    fs.Write(array, 0, array.Length);
                }
            }     // using
            // 3
            string thirdPath = @"...\third.txt";
            using(StreamWriter sw = new StreamWriter(thirdPath))
            {
                for(int i = 0; i < size; i++)
                {
                    sw.WriteLine(arr[i]);
                }
            }
            // 4
            string fourthPath = @"...\fourth.txt";
            using (BinaryWriter writer = new BinaryWriter(File.Open(fourthPath, FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < size; i++)
                {
                    writer.Write(arr[i]);
                }
            }
        }
    }
}
