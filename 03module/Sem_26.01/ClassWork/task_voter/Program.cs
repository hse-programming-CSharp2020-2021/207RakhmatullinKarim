using System;

namespace task_voter
{
    class VoteEventArgs : EventArgs
    {
        string Question { get; set; }
        int VoteFor { get; set; }
        int VoteAgainst { get; set; }
        int VoteAbstained { get; set; }
    }
    class Voter
    {
        static Random rnd = new Random();
        public void VoterHandler(object sender, VoteEventArgs e)
        {
            int num = rnd.Next(0, 3);
            if(num == 0)
                e.
        }
    }
    class ElectoralComission
    {
        public event EventHandler<VoteEventArgs> onVote;
        public VoteEventArgs Vote(string question)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ElectoralComission electoralComission = new ElectoralComission();
            int n = 10;
            Voter[] voters = new Voter[n];
            for(int i = 0; i < n; i++)
            {
                voters[i] = new Voter();
            }
        }
    }
}
