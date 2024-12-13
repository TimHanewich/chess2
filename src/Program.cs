using System;

namespace Chess2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BoardState bs = BoardState.Load("7k/1n6/8/8/4R3/5B2/8/K7 w - - 0 1");
            BoardState[] nexts = bs.PossibleNextStates();
            foreach (BoardState nbs in nexts)
            {
                Console.WriteLine(nbs.ToString());
            }
            
        }
    }
}