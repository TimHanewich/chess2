using System;

namespace Chess2
{
    public struct BoardState
    {
        //Square states
        public SquareState[,] Board = new SquareState[8,8]; //X = file (letter), Y = rank (number). For example, square "B4" would be [1,3]

        #region "Board squares"

        public SquareState A1 { get { return Board[0, 0]; } set { Board[0, 0] = value; } }
        public SquareState A2 { get { return Board[0, 1]; } set { Board[0, 1] = value; } }
        public SquareState A3 { get { return Board[0, 2]; } set { Board[0, 2] = value; } }
        public SquareState A4 { get { return Board[0, 0]; } set { Board[0, 3] = value; } }
        public SquareState A5 { get { return Board[0, 4]; } set { Board[0, 4] = value; } }
        public SquareState A6 { get { return Board[0, 5]; } set { Board[0, 5] = value; } }
        public SquareState A7 { get { return Board[0, 6]; } set { Board[0, 6] = value; } }
        public SquareState A8 { get { return Board[0, 7]; } set { Board[0, 7] = value; } }

        public SquareState B1 { get { return Board[1, 0]; } set { Board[1, 0] = value; } }
        public SquareState B2 { get { return Board[1, 1]; } set { Board[1, 1] = value; } }
        public SquareState B3 { get { return Board[1, 2]; } set { Board[1, 2] = value; } }
        public SquareState B4 { get { return Board[1, 3]; } set { Board[1, 3] = value; } }
        public SquareState B5 { get { return Board[1, 4]; } set { Board[1, 4] = value; } }
        public SquareState B6 { get { return Board[1, 5]; } set { Board[1, 5] = value; } }
        public SquareState B7 { get { return Board[1, 6]; } set { Board[1, 6] = value; } }
        public SquareState B8 { get { return Board[1, 7]; } set { Board[1, 7] = value; } }

        public SquareState C1 { get { return Board[2, 0]; } set { Board[2, 0] = value; } }
        public SquareState C2 { get { return Board[2, 1]; } set { Board[2, 1] = value; } }
        public SquareState C3 { get { return Board[2, 2]; } set { Board[2, 2] = value; } }
        public SquareState C4 { get { return Board[2, 3]; } set { Board[2, 3] = value; } }
        public SquareState C5 { get { return Board[2, 4]; } set { Board[2, 4] = value; } }
        public SquareState C6 { get { return Board[2, 5]; } set { Board[2, 5] = value; } }
        public SquareState C7 { get { return Board[2, 6]; } set { Board[2, 6] = value; } }
        public SquareState C8 { get { return Board[2, 7]; } set { Board[2, 7] = value; } }

        public SquareState D1 { get { return Board[3, 0]; } set { Board[3, 0] = value; } }
        public SquareState D2 { get { return Board[3, 1]; } set { Board[3, 1] = value; } }
        public SquareState D3 { get { return Board[3, 2]; } set { Board[3, 2] = value; } }
        public SquareState D4 { get { return Board[3, 3]; } set { Board[3, 3] = value; } }
        public SquareState D5 { get { return Board[3, 4]; } set { Board[3, 4] = value; } }
        public SquareState D6 { get { return Board[3, 5]; } set { Board[3, 5] = value; } }
        public SquareState D7 { get { return Board[3, 6]; } set { Board[3, 6] = value; } }
        public SquareState D8 { get { return Board[3, 7]; } set { Board[3, 7] = value; } }

        public SquareState E1 { get { return Board[4, 0]; } set { Board[4, 0] = value; } }
        public SquareState E2 { get { return Board[4, 1]; } set { Board[4, 1] = value; } }
        public SquareState E3 { get { return Board[4, 2]; } set { Board[4, 2] = value; } }
        public SquareState E4 { get { return Board[4, 3]; } set { Board[4, 3] = value; } }
        public SquareState E5 { get { return Board[4, 4]; } set { Board[4, 4] = value; } }
        public SquareState E6 { get { return Board[4, 5]; } set { Board[4, 5] = value; } }
        public SquareState E7 { get { return Board[4, 6]; } set { Board[4, 6] = value; } }
        public SquareState E8 { get { return Board[4, 7]; } set { Board[4, 7] = value; } }

        public SquareState F1 { get { return Board[5, 0]; } set { Board[5, 0] = value; } }
        public SquareState F2 { get { return Board[5, 1]; } set { Board[5, 1] = value; } }
        public SquareState F3 { get { return Board[5, 2]; } set { Board[5, 2] = value; } }
        public SquareState F4 { get { return Board[5, 3]; } set { Board[5, 3] = value; } }
        public SquareState F5 { get { return Board[5, 4]; } set { Board[5, 4] = value; } }
        public SquareState F6 { get { return Board[5, 5]; } set { Board[5, 5] = value; } }
        public SquareState F7 { get { return Board[5, 6]; } set { Board[5, 6] = value; } }
        public SquareState F8 { get { return Board[5, 7]; } set { Board[5, 7] = value; } }

        public SquareState G1 { get { return Board[6, 0]; } set { Board[6, 0] = value; } }
        public SquareState G2 { get { return Board[6, 1]; } set { Board[6, 1] = value; } }
        public SquareState G3 { get { return Board[6, 2]; } set { Board[6, 2] = value; } }
        public SquareState G4 { get { return Board[6, 3]; } set { Board[6, 3] = value; } }
        public SquareState G5 { get { return Board[6, 4]; } set { Board[6, 4] = value; } }
        public SquareState G6 { get { return Board[6, 5]; } set { Board[6, 5] = value; } }
        public SquareState G7 { get { return Board[6, 6]; } set { Board[6, 6] = value; } }
        public SquareState G8 { get { return Board[6, 7]; } set { Board[6, 7] = value; } }

        public SquareState H1 { get { return Board[7, 0]; } set { Board[7, 0] = value; } }
        public SquareState H2 { get { return Board[7, 1]; } set { Board[7, 1] = value; } }
        public SquareState H3 { get { return Board[7, 2]; } set { Board[7, 2] = value; } }
        public SquareState H4 { get { return Board[7, 3]; } set { Board[7, 3] = value; } }
        public SquareState H5 { get { return Board[7, 4]; } set { Board[7, 4] = value; } }
        public SquareState H6 { get { return Board[7, 5]; } set { Board[7, 5] = value; } }
        public SquareState H7 { get { return Board[7, 6]; } set { Board[7, 6] = value; } }
        public SquareState H8 { get { return Board[7, 7]; } set { Board[7, 7] = value; } } 

        #endregion
    
        public BoardState()
        {
            
        }

        public override string ToString()
        {
            string ToReturn = "";
            for (int r = 7; r >= 0; r--)
            {
                //Declare space build up
                int EmptySpaceBuildUp = 0;

                //Handle each square space
                for (int f= 0; f < 8; f++)
                {
                    //Get occupying status
                    SquareState ThisSquare = Board[f,r];

                    //Handle
                    if (ThisSquare == SquareState.Empty)
                    {
                        EmptySpaceBuildUp = EmptySpaceBuildUp + 1;
                    }
                    else //There is something occupying the space, it isn't empty
                    {

                        //Was there a build up in space? If so, put it in now and reset the build up
                        if (EmptySpaceBuildUp > 0)
                        {
                            ToReturn = ToReturn + EmptySpaceBuildUp.ToString();
                            EmptySpaceBuildUp = 0;
                        }

                        //Add the piece notation
                        if (ThisSquare == SquareState.WhitePawn)
                        {
                            ToReturn = ToReturn + "P";
                        }
                        else if (ThisSquare == SquareState.WhiteKnight)
                        {
                            ToReturn = ToReturn + "N";
                        }
                        else if (ThisSquare == SquareState.WhiteBishop)
                        {
                            ToReturn = ToReturn + "B";
                        }
                        else if (ThisSquare == SquareState.WhiteRook)
                        {
                            ToReturn = ToReturn + "R";
                        }
                        else if (ThisSquare == SquareState.WhiteQueen)
                        {
                            ToReturn = ToReturn + "Q";
                        }
                        else if (ThisSquare == SquareState.WhiteKing)
                        {
                            ToReturn = ToReturn + "K";
                        }
                        else if (ThisSquare == SquareState.BlackPawn)
                        {
                            ToReturn = ToReturn + "p";
                        }
                        else if (ThisSquare == SquareState.BlackKnight)
                        {
                            ToReturn = ToReturn + "n";
                        }
                        else if (ThisSquare == SquareState.BlackBishop)
                        {
                            ToReturn = ToReturn + "b";
                        }
                        else if (ThisSquare == SquareState.BlackRook)
                        {
                            ToReturn = ToReturn + "r";
                        }
                        else if (ThisSquare == SquareState.BlackQueen)
                        {
                            ToReturn = ToReturn + "q";
                        }
                        else if (ThisSquare == SquareState.BlackKing)
                        {
                            ToReturn = ToReturn + "k";
                        }
                    }
                    
                }
            
                //If there is some empty space built up, handle it
                //This would happen if the last space or spaces of the rank are empty
                if (EmptySpaceBuildUp > 0)
                {
                    ToReturn = ToReturn + EmptySpaceBuildUp.ToString();
                }

                //put slash at end
                if (r != 0)
                {
                    ToReturn = ToReturn + "/";
                }
            }

            return ToReturn;
        }
    
        public static BoardState Load(string FEN)
        {
            BoardState ToReturn = new BoardState();

            int onFile = 0;
            int onRank = 7; //FEN starts on the 8th rank for whatever reason... weird
            foreach (char c in FEN)
            {
                if (char.IsDigit(c)) //If it is a number
                {
                    onFile = onFile + Convert.ToInt32(c.ToString()); //increase onFile position by indicated number of blank spaces
                }
                else if (c == '/') //next rank (new line, so reset)
                {
                    onRank = onRank - 1;
                    onFile = 0;
                }
                else //It is a piece notation
                {
                    if (c == 'P')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.WhitePawn;
                    }
                    else if (c == 'N')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.WhiteKnight;
                    }
                    else if (c == 'B')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.WhiteBishop;
                    }
                    else if (c == 'R')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.WhiteRook;
                    }
                    else if (c == 'Q')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.WhiteQueen;
                    }
                    else if (c == 'K')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.WhiteKing;
                    }
                    else if (c == 'p')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.BlackPawn;
                    }
                    else if (c == 'n')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.BlackKnight;
                    }
                    else if (c == 'b')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.BlackBishop;
                    }
                    else if (c == 'r')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.BlackRook;
                    }
                    else if (c == 'q')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.BlackQueen;
                    }
                    else if (c == 'k')
                    {
                        ToReturn.Board[onFile, onRank] = SquareState.BlackKing;
                    }

                    //Increase file by one
                    onFile = onFile + 1;
                } 
            }

            return ToReturn;
        }
    }
}