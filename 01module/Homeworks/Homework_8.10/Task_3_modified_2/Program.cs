﻿/* ЗАДАЧА:
 * У многих людей развился необычный страх - пунктумофобия - боязнь точек в конце предложения. 
 * Ваша задача не показывать точки в конце предложений при выводе на экран.
 * Написать программу, которая:
 * 1) Генерирует случайным образом 6 предложений длиной от 20 до 50 символов (алфавит – все строчные символы кириллицы), заканчивающихся точкой.
 * 2) Записывает предложения построчно (каждое предложение на отдельной строке файла) в текстовый файл "dialog.txt" в кодировке UTF-8, расположенный в папке с исполняемым файлом.
 * 3) Выводит на экран то, что было записано в файл изначально.
 * 4) Открывает полученный файл и выводит на экран построчно все предложения из него, удаляя точки в конце предложения.

Дополнительное (домашнее) задание: 
1) Создайте копию проекта и внесите следующие изменения в программу: генерируемое в п.1 предложение может не заканчиваться точкой, поэтому в п.3 необходимо проверять стоит ли удалять последний символ из предложения
2) Создайте копию проекта и решите задачу с использованием методов WriteAllText и ReadAllText
3) Создайте копию проекта и решите задачу с использованием методов WriteAllLines и ReadAllLines.
4) Декомпозируйте задачу, выделив методы.
* 
*/

using System;
using System.IO; // Пространство имён System.IO -> File.
using System.Text; // Кодировка.

class Program
{
    static Random rand = new Random();
    static void Main()
    {
        // основные настрйки
        const string fileName = "dialog.txt";
        Encoding enc = Encoding.Unicode;
        const int linesCount = 6;   // кол-во предложений
        string message = string.Empty; // весь текст
        // Создаем файл на диске 
        File.WriteAllText(fileName, string.Empty, enc); // Создаём пустой файл.
        Console.WriteLine("Переписка до форматирования:");
        for (int i = 0; i < linesCount; i++)
        {
            int length = rand.Next(20, 51); // Длина сообщения от 20 до 50 символов (51 - 50 включён в диапазон)
            for (int j = 0; j < length; j++)
            {
                message += (char)rand.Next('А', 'Я'); // Посимвольное добавление букв в сообщение. "Ё" нет в диапазоне от А до Я!
            }
            message += "." + Environment.NewLine; // Добавляем в сообщение точку и перенос на следующую строку. 
        }
        Console.WriteLine(message);
        File.WriteAllText(fileName, message, enc);
        // читаем сформированный файл и обрабатываем предложения
        string readMessage = File.ReadAllText(fileName, enc); // Массив сообщений из переписки.
        Console.WriteLine(Environment.NewLine + "Переписка после форматирования:");
        // Проверяем является ли последний элемент точкой, если да, то удаляем его.
        for (int i = 0; i < message.Length - 1; i++)
        {
            int j = i;
            while(message[i] != '.')
            {
                i++;
            }
            message = message.Remove(i, 1);
        }
        Console.WriteLine(message); // Выводим сообщения из переписки без точек на экран.
        File.WriteAllText(fileName, message);
    }
}