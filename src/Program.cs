using System;

namespace Chess2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BoardState bs = BoardState.Load("r7/2k5/7b/8/3Nn3/7r/2K5/3RBR2 b");
            BoardState[] nexts = bs.PossibleNextStates();
            foreach (BoardState nbs in nexts)
            {
                Console.WriteLine(nbs.ToString());
            }
            
        }
    }
}