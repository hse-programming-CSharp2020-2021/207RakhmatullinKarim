using System;
using System.Runtime.Serialization.Formatters.Binary;
using library;
using System.IO;
using System.Collections.Generic;

namespace Program_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Street[] streets = null;
            try
            {
                streets = Deserealization();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Что-то пошло не так при десериализации! " +  ex.Message);
            }
            if (streets == null)
                Console.WriteLine("В файле out.txt некорректные данные!");
            else
            {
                List<Street> magicStreets = new List<Street>();
                for(int i = 0; i < streets.Length; i++)
                {
                    if ((~streets[i] % 2 != 0) && (!streets[i]))
                        magicStreets.Add(streets[i]);
                }
                for (int i = 0; i < magicStreets.Count; i++)
                    Console.WriteLine(magicStreets[i]);
            }
        }
        private static Street[] Deserealization()
        {
            var binFormatter = new BinaryFormatter();
            Street[] streets = null;
            if (File.Exists(@"../../../../out.txt"))
            {
                using(FileStream fs = new FileStream(@"../../../../out.txt", FileMode.OpenOrCreate))
                {
                    streets = binFormatter.Deserialize(fs) as Street[];
                }
            }
            return streets;
        }
    }
}
