using System;

namespace Votes
{
    class VetoEventArgs : EventArgs
    {
        public string Proposal { get; set; }
        public VetoVoter VetoBy { get; set; }
    }
    class VetoComission
    {
        public event EventHandler<VetoEventArgs> OnVote;
        public VetoEventArgs Vote(string Proposal)
        {
            VetoEventArgs vetoEventArgs = new VetoEventArgs();
            vetoEventArgs.Proposal = Proposal;
            OnVote?.Invoke(this, vetoEventArgs);
            return vetoEventArgs;

        }
    }
    class VetoVoter
    {
        public VetoVoter(string name)
        {
            Name = name;
        }
        public static Random rnd = new Random();
        public string Name { get; set; }
        public void VetoVoterHandler(object sender, VetoEventArgs e)
        {
            if (e.VetoBy != null)
            {
                return;
            }
            if (rnd.Next(5) == 0)
            {
                e.VetoBy = this;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int cntOfVoters = 5;
            VetoComission comission = new VetoComission();
            string[] namesOfVoters = { "Lol", "kek", "cheburek", "bulochka", "pirozhok" };
            VetoVoter[] voters = new VetoVoter[cntOfVoters];
            for (int i = 0; i < cntOfVoters; i++)
            {
                voters[i] = new VetoVoter(namesOfVoters[i]);
                comission.OnVote += voters[i].VetoVoterHandler;
            }
            VetoEventArgs voteArgs = comission.Vote("Pizza or sushi?");
            Console.WriteLine("Question:" + voteArgs.Proposal);
            if (voteArgs.VetoBy != null)
            {
                Console.WriteLine("Veto by " + voteArgs.VetoBy.Name);
            }
            else
            {
                Console.WriteLine("NO veto");
            }
        }
    }
}
