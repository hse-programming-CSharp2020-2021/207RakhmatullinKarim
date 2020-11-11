using System;
using System.Collections.Generic;

namespace Task_9
{
    class LinearEquation
    {
        int a;
        int b;
        int c;
        public LinearEquation(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public string GetX(ref bool hasSol)
        {
            if(a == 0)
            {
                if(c - b == 0)
                {
                    return "x = any integer number.";
                }
                else
                {
                    return "There are not any solutions!";
                }

            }
            else
            {
                hasSol = true;
                return $"x = {(c - b) / (double)a:f3}";
            }
        }
        public void ShowInfo()
        {
            bool hasSol = true;
            Console.WriteLine($"{a} * x + {b} = {c}");
            Console.WriteLine(GetX(ref hasSol));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo keyToExit = new ConsoleKeyInfo();
            do
            {
                Console.WriteLine("Input amount of equations.");
                int n = ValidateAmount();
                LinearEquation[] arrOfEquations = new LinearEquation[n];
                GenerateArrOfEquations(arrOfEquations);
                List<LinearEquation> listOfX = CreateListOfEqWithSol(arrOfEquations);
                SortEqs(listOfX);
                for (int i = 0; i < listOfX.Count; i++)
                {
                    listOfX[i].ShowInfo();
                }
                Console.WriteLine("Press 'Escape' to exit.");
                keyToExit = Console.ReadKey();
            } while (keyToExit.Key != ConsoleKey.Escape);

        }

        private static void SortEqs(List<LinearEquation> listOfX)
        {
            for (int i = 0; i < listOfX.Count - 1; i++)
            {
                for (int j = i + 1; j < listOfX.Count; j++)
                {
                    bool hasSol = false;
                    if (double.Parse(listOfX[i].GetX(ref hasSol).Substring(4)) > double.Parse(listOfX[j].GetX(ref hasSol).Substring(4)))
                    {
                        LinearEquation tmp = listOfX[i];
                        listOfX[i] = listOfX[j];
                        listOfX[j] = tmp;
                    }
                }
            }
        }

        private static List<LinearEquation> CreateListOfEqWithSol(LinearEquation[] arrOfEquations)
        {
            List<LinearEquation> listOfX = new List<LinearEquation>();
            for (int i = 0; i < arrOfEquations.Length; i++)
            {
                bool hasSol = false;
                string stringSol = arrOfEquations[i].GetX(ref hasSol);
                if (hasSol)
                {
                    double x;
                    if (double.TryParse(stringSol.Substring(4), out x))
                    {
                        listOfX.Add(arrOfEquations[i]);
                    }
                }
            }

            return listOfX;
        }

        private static void GenerateArrOfEquations(LinearEquation[] arrOfEquations)
        {
            Random rnd = new Random();
            for (int i = 0; i < arrOfEquations.Length; i++)
            {
                arrOfEquations[i] = new LinearEquation(rnd.Next(-10, 11), rnd.Next(-10, 11), rnd.Next(-10, 11));
                arrOfEquations[i].ShowInfo();
            }
        }

        private static int ValidateAmount()
        {
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || (n < 1))
            {
                Console.WriteLine("Incorrect input! Try again.");
            }

            return n;
        }
    }
}
