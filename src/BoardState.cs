using System;
using System.Collections.Generic;

namespace Chess2
{
    public struct BoardState
    {
        //Square states
        public SquareState[,] Board = new SquareState[8,8]; //X = file (letter), Y = rank (number). For example, square "B4" would be [1,3]
        public bool NextToMove {get; set;} //true = white, false = black

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
            
            //Prepare square representation
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

            //Next to move
            if (NextToMove)
            {
                ToReturn = ToReturn + " w";
            }
            else
            {
                ToReturn = ToReturn + " b";
            }

            return ToReturn;
        }
    
        public static BoardState Load(string FEN)
        {
            BoardState ToReturn = new BoardState();

            //Strip out board squares portion
            string[] parts = FEN.Split(" ");

            //Figure out board squares
            int onFile = 0;
            int onRank = 7; //FEN starts on the 8th rank for whatever reason... weird
            foreach (char c in parts[0])
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

            //Figure out what move is next
            if (parts.Length >= 2)
            {
                if (parts[1] == "w")
                {
                    ToReturn.NextToMove = true;
                }
                else if (parts[1] == "b")
                {
                    ToReturn.NextToMove = false;
                }
                else
                {
                    throw new Exception("Letter '" + parts[1] + "' not reognized as a valid next-to-move indicator (not w or b)");
                }
            }

            return ToReturn;
        }
    
        public BoardState Copy()
        {
            return BoardState.Load(ToString());
        }

        public bool SquareOccupied(int file, int rank)
        {
            return Board[file, rank] != SquareState.Empty;
        }

        //Determines what color is occupying a particular square.
        //If there is no piece occuping, returns null (neutral)
        public bool? SquareOccupyingColor(int file, int rank)
        {
            SquareState ss = Board[file, rank];
            if (ss == SquareState.Empty)
            {
                return null;
            }
            else if (ss == SquareState.WhitePawn || ss == SquareState.WhiteKnight || ss == SquareState.WhiteBishop || ss == SquareState.WhiteRook || ss == SquareState.WhiteQueen || ss == SquareState.WhiteKing)
            {
                return true;
            }
            else if (ss == SquareState.BlackPawn || ss == SquareState.BlackKnight || ss == SquareState.BlackBishop || ss == SquareState.BlackRook || ss == SquareState.BlackQueen || ss == SquareState.BlackKing)
            {
                return false;
            }
            else
            {
                throw new Exception("Unable to determine color of status '" + ss.ToString() + "'");
            }
        }

        //Lists out the possible next states
        public BoardState[] PossibleNextStates()
        {
            List<BoardState> ToReturn = new List<BoardState>();

            for (int f = 0; f < 8; f++) //For each file
            {
                for (int r = 0; r < 8; r++) //For each rank
                {
                    //Get square status
                    SquareState ThisSquare = Board[f,r];

                    //if it is the same color as the color that is moving now, evaluate it
                    if (SquareOccupyingColor(f, r) == NextToMove) //if the color of the piece on this square (if there is a piece) is the next to move color
                    {
                        List<(int, int)> PossiblePieceDestinations = new List<(int, int)>();

                        //Assemble a list of potential desination 
                        if (ThisSquare == SquareState.WhitePawn || ThisSquare == SquareState.BlackPawn) //pawns are tricky (first move, promotion, en passant)
                        {

                        }
                        else if (ThisSquare == SquareState.WhiteKnight || ThisSquare == SquareState.BlackKnight)
                        { 
                            
                        }
                        else if (ThisSquare == SquareState.WhiteBishop || ThisSquare == SquareState.BlackBishop)
                        {
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 1)); //up right
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 3)); //down right
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 5)); //down left
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 7)); //up left
                        }
                        else if (ThisSquare == SquareState.WhiteRook || ThisSquare == SquareState.BlackRook)
                        {
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 0)); //up
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 2)); //right
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 4)); //down
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 6)); //left
                        }
                        else if (ThisSquare == SquareState.WhiteQueen || ThisSquare == SquareState.BlackQueen)
                        {
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 0)); //up
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 1)); //up right
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 2)); //right
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 3)); //down right
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 4)); //down
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 5)); //down left
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 6)); //left
                            PossiblePieceDestinations.AddRange(PotentialMoveLine(NextToMove, f, r, 7)); //up left
                        }
                        else if (ThisSquare == SquareState.WhiteKing || ThisSquare == SquareState.BlackKing)
                        {

                        }

                        //Now for each potential destination for this piece, simulate what the board state would look like if it moved there.
                        foreach ((int,int) PossiblePieceDestination in PossiblePieceDestinations)
                        {
                            BoardState bs = Copy(); //essentially "duplicate" the current state
                            bs.Board[PossiblePieceDestination.Item1, PossiblePieceDestination.Item2] = Board[f, r]; //Set the destination to the piece
                            bs.Board[f, r] = SquareState.Empty; //"Remove" the piece from the space it came from, effectively completing the move
                            bs.NextToMove = !bs.NextToMove; //Flip the next to move
                            ToReturn.Add(bs);
                        }
                        
                    }
                }
            }

            return ToReturn.ToArray();
        }


        //Figures out a list of potential desination squares based on a linear direction, taking into account factors like can't "jump over" your own piece and can capture opponents.
        public (int,int)[] PotentialMoveLine(bool moving_color, int start_file, int start_rank, int direction)
        {
            //Directions
            //0 = up
            //1 = up + right
            //2 = right
            //3 = down + right
            //4 = down
            //5 = down + left
            //6 = left
            //7 = up + left

            List<(int, int)> ToReturn = new List<(int, int)>();

            int onFile = start_file;
            int onRank = start_rank;

            while (true)
            {
                //increment
                if (direction == 0)
                {
                    onRank = onRank + 1;
                }
                else if (direction == 1)
                {
                    onFile = onFile + 1;
                    onRank = onRank + 1;
                }
                else if (direction == 2)
                {
                    onFile = onFile + 1;
                }
                else if (direction == 3)
                {
                    onFile = onFile + 1;
                    onRank = onRank - 1;
                }
                else if (direction == 4)
                {
                    onRank = onRank - 1;
                }
                else if (direction == 5)
                {
                    onFile = onFile - 1;
                    onRank = onRank - 1;
                }
                else if (direction == 6)
                {
                    onFile = onFile - 1;
                }
                else if (direction == 7)
                {
                    onFile = onFile - 1;
                    onRank = onRank + 1;
                }
            
                //If the posiiton we are currently "on" is OFF THE BOARD, stop
                if (onRank > 7 || onRank < 0 || onFile > 7 || onFile < 0)
                {
                    return ToReturn.ToArray();
                }

                //Check occupying color of this potential destination
                bool? OccupyingColor = SquareOccupyingColor(onFile, onRank);
                if (OccupyingColor == null) //There is no color occupying this. it is empty.
                {
                    ToReturn.Add((onFile, onRank));
                }
                else if (OccupyingColor == !moving_color) //It is the opposite color (opponent)... so we can CAPTURE the piece, so yes, this is an option! But is is the last option, so stop now
                {
                    ToReturn.Add((onFile, onRank)); //Add it as an option
                    return ToReturn.ToArray(); //And then return (cannot go any further than this!)
                }
                else //It is our own color. Can't do it. Dead end.
                {
                    return ToReturn.ToArray();
                }
            }

        }
    }
}