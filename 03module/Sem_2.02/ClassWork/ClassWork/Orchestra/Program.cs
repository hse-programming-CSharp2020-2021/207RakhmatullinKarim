using System;

namespace Orchestra
{
    class PlayIsStartedEventArgs : EventArgs
    {
        public int Number { get; set; }
    }
    class Bandmaster
    {
        public event EventHandler<PlayIsStartedEventArgs> PlayIsStartedEvent;
        static Random rnd = new Random();
        public void StartPlay()
        {
            PlayIsStartedEvent?.Invoke(this, new PlayIsStartedEventArgs() { Number = rnd.Next(2, 6) });
        }
    }
    abstract class OrchestraPlayer
    {
        public string Name { }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
