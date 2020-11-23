using System;

namespace Task_3
{
    class TestOverride
    {
        public class Employee
        {
            public string name;

            // Basepay is defined as protected, so that it may be
            // accessed only by this class and derived classes.
            protected decimal basepay;

            // Constructor to set the name and basepay values.
            public Employee(string name, decimal basepay)
            {
                this.name = name;
                this.basepay = basepay;
            }

            // Declared virtual so it can be overridden.
            public virtual decimal CalculatePay()
            {
                return basepay;
            }
        }

        // Derive a new class from Employee.
        public class SalesEmployee : Employee
        {
            // New field that will affect the base pay.
            private decimal salesbonus;

            // The constructor calls the base-class version, and
            // initializes the salesbonus field.
            public SalesEmployee(string name, decimal basepay,
                      decimal salesbonus) : base(name, basepay)
            {
                this.salesbonus = salesbonus;
            }

            // Override the CalculatePay method
            // to take bonus into account.
            public override decimal CalculatePay()
            {
                return basepay + salesbonus;
            }
            public override string ToString()
            {
                return $"Sales Employee {name} earned {CalculatePay():f3}";
            }
        }
        public class PartTimeEmployee : Employee
        {
            int workingDays;
            public PartTimeEmployee(string name, decimal basepay,
                int workingDays):base(name, basepay)
            {
                this.workingDays = workingDays;
            }
            public override decimal CalculatePay()
            {
                return basepay * workingDays / 25;
            }
            public override string ToString()
            {
                return $"Part-time Employee {name} earned {CalculatePay():f3}";
            }
        }
        static string[] arrOfNames = { "Alice", "Bob", "Nick", "John", "Jane", "Fil", "Hailey" };
        static void Main()
        {
            Employee[] arrOfEmployees = CreateArrOfEmployees();
            Array.Sort(arrOfEmployees, (employee1, employee2) => employee1.CalculatePay().CompareTo(employee2.CalculatePay()));
            PrintGroups(arrOfEmployees);

        }

        private static void PrintGroups(Employee[] arrOfEmployees)
        {
            for (int i = 0; i < arrOfEmployees.Length; i++)
            {
                if (arrOfEmployees[i] is SalesEmployee)
                {
                    Console.WriteLine(arrOfEmployees[i]);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < arrOfEmployees.Length; i++)
            {
                if (arrOfEmployees[i] is PartTimeEmployee)
                {
                    Console.WriteLine(arrOfEmployees[i]);
                }
            }
        }

        private static Employee[] CreateArrOfEmployees()
        {
            Random rnd = new Random();
            Employee[] arrOfEmployees = new Employee[10];
            for (int i = 0; i < arrOfEmployees.Length; i++)
            {
                if (rnd.Next(1, 3) == 1)
                {
                    arrOfEmployees[i] = new PartTimeEmployee(arrOfNames[rnd.Next(arrOfNames.Length)],
                        (decimal)rnd.NextDouble() * 1000, rnd.Next(30));
                }
                else
                {
                    arrOfEmployees[i] = new SalesEmployee(arrOfNames[rnd.Next(arrOfNames.Length)],
                        (decimal)rnd.NextDouble() * 1000, (decimal)rnd.NextDouble() * 1000 / 2);
                }
            }

            return arrOfEmployees;
        }
    }
}
