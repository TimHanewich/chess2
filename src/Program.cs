using System;

namespace Chess2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string fen = "1k2r3/1p4p1/pPp3p1/4r3/1R2n2P/7B/1PP5/3R2K1";
            BoardState bs2 = BoardState.Load(fen);
            string fen2 = bs2.ToString();
            if (fen == fen2)
            {
                Console.WriteLine("Same!");
            }
            else
            {
                Console.WriteLine("Not same!");
            }
        }
    }
}