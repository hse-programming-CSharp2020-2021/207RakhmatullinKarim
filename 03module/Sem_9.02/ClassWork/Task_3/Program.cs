using System;
using System.Collections.Generic;

namespace A
{
    /// <summary>
    /// Пассажир
    /// </summary>
    public class Passenger
    {
        int name;
        int lastName;
        int age;
        public Passenger(int name, int lastname, int age)
        {
            this.name = name;
            this.lastName = lastname;

            this.age = age;

            if (this.age >= 65)
                IsOld = true;
        }
        public bool IsOld { private set; get; }
        public int Name
        {
            set
            { // only latin simbols and spaces
              // not longer 30 simbols
                name = value;
            }
            get
            {
                return name;
            }
        }
        public int LastName
        {
            set
            { // only latin simbols and spaces
              // not longer 40 simbols
                lastName = value;
            }
            get
            {
                return name;
            }
        }
        public int Age
        {
            set
            { // more then 0
                age = value;
            }
            get { return age; }
        }
        public override string ToString()
        {
            return $"Name: {name} Last name: {lastName} Age: {age}";
        }
    }
    /// <summary>
    /// Пассажир с детьми
    /// </summary>
    public class PassengerWithChildren : Passenger
    {
        int numberOfChildren;
        public PassengerWithChildren(bool isNewBorn, int numberOfChildren, int name, int lastname, int age) : base(name, lastname, age)
        {
            NumberOfChildren = numberOfChildren;
            IsNewBorn = isNewBorn;
        }
        public bool IsNewBorn { private set; get; }
        public int NumberOfChildren
        {
            set
            { // strictly more then 0
                numberOfChildren = value;
            }
            get { return numberOfChildren; }
        }
        public override string ToString()
        {
            return $"Name: {Name} Last name: {LastName} Age: {Age} Children: {NumberOfChildren} " +
                $"has new born children: {IsNewBorn}";
        }
    }
    /// <summary>
    /// Очередь на посадку состоит из двух подочередей: обычной и приоритетной
    /// Пассажиры приоритетной очереди обслуживаются вне очереди
    /// </summary>
    public class PassengerQueue
    {
        // if passenger is ordinary we use ordinaryQueue
        Queue<Passenger> ordinaryQueue = new Queue<Passenger>();
        // if passenger is old or with newborns we use priorityQueue
        Queue<Passenger> priorityQueue = new Queue<Passenger>();

        public void AddToQueue(Passenger newPassenger)
        {
            if (newPassenger.Age > 65 || newPassenger is PassengerWithChildren && ((PassengerWithChildren)newPassenger).IsNewBorn)
                priorityQueue.Enqueue(newPassenger);
            else ordinaryQueue.Enqueue(newPassenger);
        }
        public void StartServingQueue()
        {
            while (priorityQueue.Count > 3)
            {
                Console.WriteLine($"\nBoarding gate:\n{priorityQueue.Peek()}");
                priorityQueue.Dequeue();

                if (ordinaryQueue.Count != 0)
                {
                    Console.WriteLine($"\nBoarding gate:\n{ordinaryQueue.Peek()}");
                    ordinaryQueue.Dequeue();
                }
            }

            while (priorityQueue.Count != 0)
            {
                Console.WriteLine($"\nBoarding gate:\n{priorityQueue.Peek()}");
                priorityQueue.Dequeue();
            }

            while (ordinaryQueue.Count != 0)
            {
                Console.WriteLine($"\nBoarding gate:\n{ordinaryQueue.Peek()}");
                ordinaryQueue.Dequeue();
            }
        }
    }

    class MainClass
    {
        public static void Main()
        {
            Random random = new Random();
            PassengerQueue queue = new PassengerQueue();

            for (int i = 0; i < random.Next(0, 200); i++)
            {
                Passenger passenger;

                if (Convert.ToBoolean(random.Next(0, 2)))
                    passenger = new PassengerWithChildren(Convert.ToBoolean(random.Next(0, 2)), random.Next(1, 41),
                        random.Next(), random.Next(), random.Next(18, 120));

                else passenger = new Passenger(random.Next(), random.Next(), random.Next(18, 120));

                queue.AddToQueue(passenger);
            }

            queue.StartServingQueue();
        }
    }
}
