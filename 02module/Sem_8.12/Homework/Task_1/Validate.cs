﻿using System;
namespace Task_1
{
    public class Validate
    {
        public Validate()
        {
        }
        // comment - строка-сообщение для получения данных
        public static int GetIntValue(string comment)
        {
            int intVal;
            do Console.Write(comment);
            while (!int.TryParse(Console.ReadLine(), out intVal));
            return intVal;
        }
    }
}
