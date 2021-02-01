using System;

namespace Task_6
{
    public class RingIsFoundEventArgs : EventArgs
    {
        public RingIsFoundEventArgs(string s) { Message = s; }
        // Будем передавать только строку
        public String Message { get; set; }
    }
    public  abstract class Creature
    {
        public string Location;
    }
    public class Wizard : Creature
    {
        public string Name { get; private set; }
        //2) событийный делегат
        public delegate void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs a);
        //3) событие "Кольцо найдено"
        public event RingIsFoundEventHandler RaiseRingIsFoundEvent;
        public Wizard(string s) { Name = s; }
        public Wizard() { }
        // Когда волшебнику кажется, что кольцо найдено, он вызывает этот метод
        public void SomeThisIsChangedInTheAir()
        {
            Console.WriteLine("Current location - " + Location);
            Console.WriteLine($"{Name} >> Кольцо найдено у старого Бильбо! Призываю вас в Ривендейл! ");
            RaiseRingIsFoundEvent(this, new RingIsFoundEventArgs("Ривендейл"));
            Location = 
        }
    }
    public class Hobbit : Creature
    {
        public string Name { get; private set; }
        public Hobbit(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Покидаю Шир! Иду в " + e.Message);
        }
    }
    public class Human : Creature
    {
        public string Name { get; private set; }
        public Human(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Волшебник {((Wizard)sender).Name} позвал. Моя цель {e.Message}");
        }
    }
    public class Elf : Creature
    {
        public string Name { get; private set; }
        public Elf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Звёзды светят не так ярко как обычно. Цветы увядают. Листья предсказывают идти в " + e.Message);
        }
    }
    public class Dwarf : Creature
    {
        public string Name { get; private set; }
        public Dwarf(string s) { Name = s; }
        public void RingIsFoundEventHandler(object sender, RingIsFoundEventArgs e)
        {
            Console.WriteLine($"{Name} >> Точим топоры, собираем припасы! Выдвигаемся в " + e.Message);
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard = new Wizard("Гендальф");
            Hobbit[] hobbits = new Hobbit[4];
            // TODO создать объекты хоббитов из Шира
            // TODO подписать хоббитов на событие волшебника
            Human[] humans = { new Human("Боромир"), new Human("Арагорн") };
            Dwarf dwarf = new Dwarf("Гимли");
            Elf elf = new Elf("Леголас");
            // подписывает гномов, людей и эльфов на событие
            wizard.RaiseRingIsFoundEvent += dwarf.RingIsFoundEventHandler;
            wizard.RaiseRingIsFoundEvent += elf.RingIsFoundEventHandler;
            foreach (Human h in humans)
                wizard.RaiseRingIsFoundEvent += h.RingIsFoundEventHandler;
            // волшебник оповещает всех 
            wizard.SomeThisIsChangedInTheAir();
        }
    }

}
