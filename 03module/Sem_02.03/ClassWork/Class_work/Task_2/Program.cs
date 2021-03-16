using System;
using System.Collections.Generic;

namespace Task_2
{
    class ElectronicQueue<T>
    {
        Queue<T> queue;
        public ElectronicQueue(Queue<T> queue)
        {
            this.queue = queue;
        }
        public Queue<T> Queue
        {
            get => queue;
            set => queue = value;
        }
    }
    struct Person
    {
        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public override string ToString()
        {
            return $"Name: {Name} Surname: {Surname} Age: {Age}";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ElectronicQueue<Person> persons = new ElectronicQueue<Person>(new Queue<Person>());
            string[] names = { "Steve", "Bill", "David", "Mike" };
            string[] surnames = { "Jobs", "Gates", "Beckham", "Jordan" };
            int[] ages = { 60, 75, 56, 63 };
            for(int i = 0; i < names.Length; i++)
            {
                persons.Queue.Enqueue(new Person(names[i], surnames[i], ages[i]));
            }
            foreach (Person pers in persons.Queue)
            {
                Console.WriteLine(pers);
            }
            Console.WriteLine();
            Console.WriteLine("Peek " + persons.Queue.Peek());
            Console.WriteLine();
            Person p = persons.Queue.Dequeue();
            Console.WriteLine("Peek " + persons.Queue.Peek());
            persons.Queue.Enqueue(p);
            foreach(Person pers in persons.Queue)
            {
                Console.WriteLine(pers);
            }
        }
    }
}
