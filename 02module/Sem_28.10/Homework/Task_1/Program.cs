using System;

namespace Task_1
{
    class Program
    {
        class Birthday
        {
            string name;
            int year, month, day;
            public Birthday(string name, int y = 2000, int m = 1, int d = 1)
            {
                this.name = name;
                year = y;
                month = m;
                day = d;
            }

            public Birthday()
            {
                year = 1970;
                month = 1;
                day = 1;
            }
            DateTime Date
            {
                get
                {
                    return new DateTime(year, month, day);
                }
            }
            public string GetInfo
            {
                get { return $"{name}, date of birth {day}.{month}.{year}."; }
            }
            public string DDMonthYYYY
            {
                get
                {
                    return $"{new DateTime(year, month, day):dd MMMM yyyy}";
                }
            }
            public string GetInfoAnotherFormat
            {
                get
                {
                    return $"{new DateTime(year, month, day):dd-MM-yy}";
                }
            }

            public int HowManyDays
            {
                get
                {
                    int nowDays = DateTime.Now.DayOfYear;
                    int birhdayDays = Date.DayOfYear;
                    if (birhdayDays > nowDays)
                    {
                        return birhdayDays - nowDays;
                    }
                    else
                    {
                        return 365 - nowDays + birhdayDays;
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Input your name");
            string name = Console.ReadLine();
            int year, month, day;
            Console.WriteLine("Input year of your birthday.");
            while((!int.TryParse(Console.ReadLine(), out year)) || (year > DateTime.Now.Year) || (year < 0))
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine("Input month of your birthday");
            while ((!int.TryParse(Console.ReadLine(), out month)) || (month > 12) || (month < 1))
            {
                Console.WriteLine("Incorrect input");
            }
            Console.WriteLine("Input day of your birthday");
            while ((!int.TryParse(Console.ReadLine(), out day)) || (day > 31) || (day < 1))
            {
                Console.WriteLine("Incorrect input");
            }
            Birthday person = new Birthday(name, year, month, day);
            Console.WriteLine(person.DDMonthYYYY);
            Console.WriteLine(person.GetInfoAnotherFormat);
        }

    }
}
