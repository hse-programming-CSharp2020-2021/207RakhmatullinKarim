using System;
using System.Collections.Generic;
using System.IO;

class ColorPoint
{
    public static string[] colors = { "Red", "Green", "DarkRed", "Magenta", "DarkSeaGreen", "Lime", "Purple", "DarkGreen", "DarkOrange", "Black", "BlueViolet", "Crimson", "Gray", "Brown", "CadetBlue" };
    public double x, y;
    public string color;
    public override string ToString()
    {
        string format = "{0:F3}    {1:F3}    {2}";
        return string.Format(format, x, y, color);
    }
}

class Test
{
    static Random gen = new Random();
    public static void Main()
    {
        string path = @"...\MyTest.txt";
        int N = 10;
        List<ColorPoint> list = new List<ColorPoint>();
        ColorPoint one;
        for (int i = 0; i < N; i++)
        {
            one = new ColorPoint();
            one.x = gen.NextDouble();
            one.y = gen.NextDouble();
            int j = gen.Next(0, ColorPoint.colors.Length);
            one.color = ColorPoint.colors[j];
            list.Add(one);
        }
        string[] arrData = Array.ConvertAll(list.ToArray(),
                     (ColorPoint cp) => cp.ToString());
        // создаем объект BinaryWriter
        using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate)))
        {
            foreach (var item in list)
            {
                writer.Write(item.color);
                writer.Write(item.x);
                writer.Write(item.y);
            }
        }
        using (BinaryReader reader = new BinaryReader(File.Open(path, FileMode.OpenOrCreate)))
        {
            while (reader.BaseStream.Position < reader.BaseStream.Length)
            {
                one = new ColorPoint();
                one.color = reader.ReadString();
                one.x = reader.ReadDouble();
                one.y = reader.ReadDouble();
                Console.WriteLine(one);
            }
        }
    }
} // class Test

