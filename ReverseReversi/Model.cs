using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;

namespace ReverseReversi
{
    public enum AlgorithmEnum
    {
        MinMax,
        MinMaxAlphaBeta
    }

    public enum GameTypeEnum
    {
        NoGame,
        PlayerVsPlayer,
        PlayerVsPC,
        PCvsPC
    }

    /// <summary>
    /// Board (i,j) container (SPOT)
    /// Also used to determine the GameTurn, (P1 is player 1) , (P2 is player 2 OR PC).
    /// </summary>
    public enum SpotEnum
    {
        Empty,  // empty spot
        P1,     // Player 1 soldier
        P2      // Player 2 soldier OR PC (when PlayerVsPC)
    }


    /// <summary>
    /// Represent a PC move with Row\Col & Score (Kills)
    /// </summary>
    public struct PCMove
    {
        public Point p;
        public double score;

        public PCMove(int x, int y) 
        {
            this.p = new Point();
            this.p.X = x;
            this.p.Y = y;
            this.score = 0;
        }

        public PCMove(int x, int y, int s)
        {
            this.p = new Point();
            this.p.X = x;
            this.p.Y = y;
            this.score = s;
        }
    }


    public class GameModel
    {
        public static AlgorithmEnum PCAlgorithm { get; set; }

        public static SpotEnum[,] CloneBoard(SpotEnum[,] Board)
        {
            return (SpotEnum[,])Board.Clone();
        }

        public static SpotEnum SwitchPlayer(SpotEnum Player)
        {
            if (Player == SpotEnum.P1)
            {
                return SpotEnum.P2;
            }
            else
            {
                return SpotEnum.P1;
            }
        }

        public static Boolean IsInBoundries(int i, int j)
        {
            if (i >= 1 && i <= 8 && j >= 1 && j <= 8)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #region Depth
        private static int _Depth = 3;

        public static int Depth
        {
            get { return GameModel._Depth; }
            set { GameModel._Depth = value; }
        }
        #endregion

        #region Weights
        private static double _ColorRatioWeight = 1;
        private static double _MobilitysWeight = 1;
        private static double _WeightedBoardWeight = 1;
        private static double _AvailMoveCountWeight = 1;
        private static double _StabilityWeight = 1;
        private static double _GetCornersRatioWeight = 1;

        public static double GetCornersRatioWeight
        {
            get { return GameModel._GetCornersRatioWeight; }
            set { GameModel._GetCornersRatioWeight = value; }
        }

        public static double StabilityWeight
        {
            get { return GameModel._StabilityWeight; }
            set { GameModel._StabilityWeight = value; }
        }

        public static double AvailMoveCountWeight
        {
            get { return GameModel._AvailMoveCountWeight; }
            set { GameModel._AvailMoveCountWeight = value; }
        }

        public static double WeightedBoardWeight
        {
            get { return GameModel._WeightedBoardWeight; }
            set { GameModel._WeightedBoardWeight = value; }
        }

        public static double MobilitysWeight
        {
            get { return GameModel._MobilitysWeight; }
            set { GameModel._MobilitysWeight = value; }
        }

        public static double ColorRatioWeight
        {
            get { return GameModel._ColorRatioWeight; }
            set { GameModel._ColorRatioWeight = value; }
        }

        #endregion


        #region  Heuristic Functions
        private static int[,] WeightedBoard = new int[9, 9] {{  0,  0,  0,  0,  0,  0,  0,  0,  0},
                                                             {  0,-99,  8, -8,  6,  6, -8,  8,-99},
                                                             {  0,  8, 48,-16,  3,  3,-16, 48,  8},
                                                             {  0, -8,-16,  4,  4,  4,  4,-16, -8},
                                                             {  0,  6,  3,  4,  0,  0,  4,  3,  6},
                                                             {  0,  6,  3,  4,  0,  0,  4,  3,  6},
                                                             {  0, -8,-16,  4,  4,  4,  4,-16, -8},
                                                             {  0,  8, 48,-16,  3,  3,-16, 48,  8},
                                                             {  0,-99,  8, -8,  6,  6, -8,  8,-99}};

        public static float HeFunc_Mobility(SpotEnum[,] Board, SpotEnum Player)
        {
            int count_empty = 0;
            int PlayerFrontiers = 0;
            int OpponentFrontiers = 0;

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (Board[i, j] != SpotEnum.Empty)
                    {
                        // count the empty spots around the player
                        count_empty = 0;

                        for (int x = i - 1; x <= i + 1; x++)
                        {
                            for (int y = j - 1; y <= j + 1; y++)
                            {
                                if (x < 1 || x > 8 || y < 1 || y > 8)
                                {
                                    continue;
                                }
                                else
                                {
                                    if (Board[x, y] == SpotEnum.Empty)
                                    {
                                        count_empty++;
                                    }
                                }
                            }
                        }

                        if (count_empty > 4)    //if here is enough space around this player
                        {
                            if (Board[i, j] == Player)
                            {
                                // Our Player Spot
                                PlayerFrontiers++;
                            }
                            else
                            {
                                // Opponent Spot
                                OpponentFrontiers++;
                            }
                        }
                    }
                }
            }


            //Console.WriteLine("Mobility=" + ((PlayerFrontiers - OpponentFrontiers) / 64F).ToString());
            return ( (PlayerFrontiers - OpponentFrontiers) / 64F);        // divide by the maximum value
        }

        public static float HeFunc_Stability(SpotEnum[,] Board, SpotEnum Player)
        {
            float PlayerUnStable = 0;
            float OpponentUnStable = 0;

            List<Point> PlayerMoves = GetAvailibleMovesSpots(Board, Player);
            List<Point> OpponentMoves = GetAvailibleMovesSpots(Board, SwitchPlayer(Player));

            List<Point> tmpUnStable = new List<Point>();
            List<Point> retUnStable = new List<Point>();

            //List<Point> GetKillList(SpotEnum[,] Board, SpotEnum Player, int i, int j)
            for (int i = 0; i < PlayerMoves.Count; i++)
            {
                tmpUnStable = GetKillList(Board, Player, PlayerMoves[i].X, PlayerMoves[i].Y);
                for (int j = 0; j < tmpUnStable.Count; j++)
                {
                    if(!retUnStable.Contains(tmpUnStable[j]))
                    {
                        retUnStable.Add(tmpUnStable[j]);
                    }
                }
            }
            PlayerUnStable = retUnStable.Count;

            retUnStable.Clear();
            for (int i = 0; i < OpponentMoves.Count; i++)
            {
                tmpUnStable = GetKillList(Board, SwitchPlayer(Player), OpponentMoves[i].X, OpponentMoves[i].Y);
                for (int j = 0; j < tmpUnStable.Count; j++)
                {
                    if(!retUnStable.Contains(tmpUnStable[j]))
                    {
                        retUnStable.Add(tmpUnStable[j]);
                    }
                }
            }
            OpponentUnStable = retUnStable.Count;

            return (OpponentUnStable - PlayerUnStable) / 20F;
        }

        public static float HeFunc_WeightedBoardValue(SpotEnum[,] Board, SpotEnum Player) 
        {
            float PlayerScores = 0;
            float OpponentScores = 0;

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    if (Board[i, j] == Player)
                    {
                        PlayerScores += WeightedBoard[i, j] / 99F;
                    }
                    else if (Board[i, j] != SpotEnum.Empty)
                    {
                        OpponentScores += WeightedBoard[i, j] / 99F;
                    }
                }
            }

            //Console.WriteLine("WeightedBoardValue=" + ((PlayerScores - OpponentScores) / 64).ToString());
            return (PlayerScores - OpponentScores) ;
        }

        public static float HeFunc_GetCornersRatio(SpotEnum[,] Board, SpotEnum Player)
        {
            float PlayerCorner = 0;
            float OpponentCorner = 0;

            if (Board[1, 1] == Player)
                PlayerCorner++;
            else if (Board[1, 1] != SpotEnum.Empty)
                OpponentCorner++;

            if (Board[1, 8] == Player)
                PlayerCorner++;
            else if (Board[1, 8] != SpotEnum.Empty)
                OpponentCorner++;

            if (Board[8, 8] == Player)
                PlayerCorner++;
            else if (Board[8, 8] != SpotEnum.Empty)
                OpponentCorner++;

            if (Board[8, 1] == Player)
                PlayerCorner++;
            else if (Board[8, 1] != SpotEnum.Empty)
                OpponentCorner++;

            return (OpponentCorner - PlayerCorner) / 4F;
        }

        public static float HeFunc_GetColorRatio(SpotEnum[,] Board, SpotEnum Player)
        {
            float PlayerCount = 0;
            float OpponentCount = 0;

            for (int j = 1; j <= 8; j++)
            {
                for (int i = 1; i <= 8; i++)
                {
                    if (Board[i, j] == Player)
                    {
                        PlayerCount++;
                    }
                    else if (Board[i, j] != SpotEnum.Empty)
                    {
                        OpponentCount++;
                    }
                }
            }

            //Console.WriteLine("GetColorRatio=" + (score / 64).ToString());
            return (OpponentCount - PlayerCount) / 64F;
        }

        public static float HeFunc_AvailMoveCount(SpotEnum[,] Board, SpotEnum Player)
        {
            float PlayerMoves = GetAvailibleMovesSpots(Board, Player).Count;
            float OpponentMoves = GetAvailibleMovesSpots(Board, SwitchPlayer(Player)).Count;

            //Console.WriteLine("AvailMoveCount=" + ((PlayerMoves - OpponentMoves) / 32).ToString());
            return (PlayerMoves - OpponentMoves) / 32;
        }

        #endregion

        /// <summary>
        /// Get Scores , the diff between black and white players
        /// + is good , - is bad
        /// </summary>
        public static double Utility(SpotEnum[,] Board, SpotEnum Player)
        {
            double color = 0;
            if ( ColorRatioWeight > 0 )
                color = HeFunc_GetColorRatio(Board, Player);

            double mobility = 0;
            if( MobilitysWeight > 0 )
                mobility = HeFunc_Mobility(Board, Player);

            double weighted_board = 0;
            if ( WeightedBoardWeight > 0 )
                weighted_board = HeFunc_WeightedBoardValue(Board, Player);

            double avail = 0;
            if ( AvailMoveCountWeight > 0 )
                avail = HeFunc_AvailMoveCount(Board, Player);

            double corners = 0;
            if ( GetCornersRatioWeight > 0 )
                corners = HeFunc_GetCornersRatio(Board, Player);

            double stability = 0;
            if ( StabilityWeight > 0 )
                stability = HeFunc_Stability(Board, Player);


            return
                ColorRatioWeight * color +
                MobilitysWeight * mobility +
                WeightedBoardWeight * weighted_board +
                AvailMoveCountWeight * avail +
                StabilityWeight * stability +
                GetCornersRatioWeight * corners;

        }


        /// <summary>
        /// Get the count of soldier player can kill in one moce (i,j)
        /// </summary>
        /// <param name="Board">The Board Matrix</param>
        /// <param name="Player">Player Enum</param>
        /// <param name="i">move i</param>
        /// <param name="j">move j</param>
        /// <param name="direction_i">Direction UP/DOWN    (-1/0/1) </param>
        /// <param name="direction_j">Direction LEFT/RIGHT (-1/0/1) </param>
        /// <returns>Point List of killed enemy soldier, Empty list -> Not valid move </returns>
        private static List<Point> GetKillCountInMove(SpotEnum[,] Board, SpotEnum Player, int i, int j, int direction_i, int direction_j)
        {
            List<Point> tmp_lst_pts = new List<Point>();

            int y = i + direction_i;
            int x = j + direction_j;

            // move in the given direction as long as we NOT out of bord, or stopped eating enemy soldiers
            while (
                IsInBoundries(y,x) &&
                Board[y, x] != SpotEnum.Empty && Board[y, x] != Player
                )
            {
                tmp_lst_pts.Add(new Point(y, x));   // add this enemy point! (we can kill him)

                y += direction_i;
                x += direction_j;
            }

            if (IsInBoundries(y,x) && Board[y, x] == Player)  //if in the end of this line there is Player Soldier (and not enemy)
            {
                return tmp_lst_pts;
            }
            else
            {
                return new List<Point>();
            }
        }


        /// <summary>
        /// Check if move is valid
        /// </summary>
        /// <param name="Board"></param>
        /// <param name="Player"></param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns>0 - not a valid move</returns>
        public static Boolean CheckValidMove(SpotEnum[,] Board, SpotEnum Player, int i, int j)
        {
            // check if this empty spt is a valid move
            //    -1
            // -1  x  +1
            //    +1
            for (int direction_i = -1; direction_i < 2; direction_i++)      // UP / none / DOWN     (-1,0,1)
            {
                for (int direction_j = -1; direction_j < 2; direction_j++)  // LEFT/ none / RIGHT   (-1,0,1)
                {
                    if (! (direction_i == 0 && direction_j == 0) )         // NOT the same spot! (i,j)
                    {
                        // get potential killed enemy soldiers list
                        List<Point> tmp_lst_pts =
                            GetKillCountInMove(Board, Player, i, j, direction_i, direction_j);

                        if (tmp_lst_pts.Count() > 0)    //Check if there is enemy soldiers to kill (valid move!)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }




        public static List<Point> GetAvailibleMovesSpots(SpotEnum[,] Board, SpotEnum Player)
        {
            List<Point> move_pts = new List<Point>();

            for (int j = 1; j <= 8; j++)
            {
                for (int i = 1; i <= 8; i++)
                {
                    // check if spot is empty for the next move
                    if (Board[i, j] == SpotEnum.Empty)
                    {
                        if (CheckValidMove(Board, Player, i, j))
                        {
                            move_pts.Add(new Point(i, j));
                        }
                    }
                }

            }

            return move_pts;
        }



        public static List<Point> GetKillList(SpotEnum[,] Board, SpotEnum Player, int i, int j)
        {
            Dictionary<Point, Boolean> KillDic = new Dictionary<Point, Boolean>(); // count all spots that we can kill enemy in this i,j move

            for (int direction_i = -1; direction_i < 2; direction_i++)      // UP / none / DOWN     (-1,0,1)
            {
                for (int direction_j = -1; direction_j < 2; direction_j++)  // LEFT/ none / RIGHT   (-1,0,1)
                {
                    if (!(direction_i == 0 && direction_j == 0))         // NOT the same spot! (i,j)
                    {
                        // get potential killed enemy soldiers list
                        List<Point> tmp_lst_pts =
                            GetKillCountInMove(Board, Player, i, j, direction_i, direction_j);

                        // insert those points in the Points Dictionary
                        foreach (var item in tmp_lst_pts)
                        {
                            if (!KillDic.ContainsKey(item))
                            {
                                KillDic.Add(item, true);
                            }
                        }

                    }
                }
            }
            return KillDic.Keys.ToList();   //retun the points list (from the dictionary)
        }

        /// <summary>
        /// Make a move on REF BOARD !
        /// The Board[][] is Changes at the end of this function
        /// Assuming that this move is LEGAL
        /// </summary>
        /// <param name="Board">The Board Before, and it changes at the end of this function</param>
        /// <param name="Player">Turn</param>
        /// <param name="i"></param>
        /// <param name="j"></param>
        public static void MakeMove(SpotEnum[,] Board, SpotEnum Player, int i, int j)
        {
            List<Point> KillList = GameModel.GetKillList(Board, Player, i, j);
            Board[i, j] = Player;
            foreach (var item in KillList)
            {
                Board[item.X, item.Y] = Player;
            }
        }


        /// <summary>
        /// The Game AI - Get The PC Move(i,j)
        /// </summary>
        /// <param name="Board">Current Board</param>
        /// <param name="Player">Current Player Turn</param>
        /// <returns></returns>
        public static PCMove GetMinMaxPCMove(SpotEnum[,] Board, SpotEnum Player)
        {
            if (PCAlgorithm == AlgorithmEnum.MinMax)
            {
                return GetMaxValue(Board, Player, Depth);
            }
            else
            {
                return GetMaxValueAB(Board, Player, Depth, int.MinValue, int.MaxValue);
            }
        }

        public static PCMove GetMaxValue(SpotEnum[,] Board, SpotEnum Player, int depth)
        {
            PCMove BestMove = new PCMove();

            if (depth < 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            List<Point> AvailibleMoves = GetAvailibleMovesSpots(Board, Player);

            if (AvailibleMoves.Count() == 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            BestMove.score = int.MinValue;

            // for all moves
            foreach (var item in AvailibleMoves)
            {
                PCMove p_move = new PCMove(item.X, item.Y);

                SpotEnum[,] tmpBoard = CloneBoard(Board);   // Creaye New Board

                MakeMove(tmpBoard, Player, p_move.p.X, p_move.p.Y); //make the move

                p_move.score = GetMinValue(tmpBoard, SwitchPlayer(Player), --depth).score;

                // check if the score is better for now
                if ( p_move.score > BestMove.score )
                {
                    // Save the best move so far
                    BestMove.p.X = p_move.p.X;
                    BestMove.p.Y = p_move.p.Y;
                    BestMove.score = p_move.score;
                }
            }

            return BestMove;
        }

        public static PCMove GetMinValue(SpotEnum[,] Board, SpotEnum Player, int depth)//, int alpha, int beta)
        {
            PCMove BestMove = new PCMove();

            if (depth < 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            List<Point> AvailibleMoves = GetAvailibleMovesSpots(Board, Player);

            if (AvailibleMoves.Count() == 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            BestMove.score = int.MaxValue;

            // for all moves
            foreach (var item in AvailibleMoves)
            {
                PCMove p_move = new PCMove(item.X, item.Y);

                SpotEnum[,] tmpBoard = CloneBoard(Board);   // Creaye New Board

                MakeMove(tmpBoard, Player, p_move.p.X, p_move.p.Y); //make the move

                p_move.score = GetMaxValue(tmpBoard, SwitchPlayer(Player), --depth).score;

                // check if the score is better for now
                if ( p_move.score < BestMove.score )
                {
                    // Save the best move so far
                    BestMove.p.X = p_move.p.X;
                    BestMove.p.Y = p_move.p.Y;
                    BestMove.score = p_move.score;
                }
            }

            return BestMove;
        }


        public static PCMove GetMaxValueAB(SpotEnum[,] Board, SpotEnum Player, int depth, double alpha, double beta)
        {
            PCMove BestMove = new PCMove();

            if (depth < 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            List<Point> AvailibleMoves = GetAvailibleMovesSpots(Board, Player);

            if (AvailibleMoves.Count() == 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            BestMove.score = int.MinValue;

            // for all moves
            foreach (var item in AvailibleMoves)
            {
                PCMove p_move = new PCMove(item.X, item.Y);

                SpotEnum[,] tmpBoard = CloneBoard(Board);   // Creaye New Board

                MakeMove(tmpBoard, Player, p_move.p.X, p_move.p.Y); //make the move

                p_move.score = GetMinValueAB(tmpBoard, SwitchPlayer(Player), --depth, alpha , beta).score;

                if (p_move.score > alpha)
                {
                    alpha = p_move.score;
                    // Save the best move so far
                    BestMove.p.X = p_move.p.X;
                    BestMove.p.Y = p_move.p.Y;
                    BestMove.score = p_move.score;
                }

                if (beta <= alpha)
                {
                    break;
                }

            }

            return BestMove;
        }

        public static PCMove GetMinValueAB(SpotEnum[,] Board, SpotEnum Player, int depth, double alpha, double beta)
        {
            PCMove BestMove = new PCMove();

            if (depth < 0)
            {
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            List<Point> AvailibleMoves = GetAvailibleMovesSpots(Board, Player);

            if (AvailibleMoves.Count() == 0)
            {
                // TODO
                BestMove.score = Utility(Board, Player);
                return BestMove;
            }

            BestMove.score = int.MaxValue;

            // for all moves
            foreach (var item in AvailibleMoves)
            {
                PCMove p_move = new PCMove(item.X, item.Y);

                SpotEnum[,] tmpBoard = CloneBoard(Board);   // Creaye New Board

                MakeMove(tmpBoard, Player, p_move.p.X, p_move.p.Y); //make the move

                p_move.score = GetMaxValueAB(tmpBoard, SwitchPlayer(Player), --depth, alpha, beta).score;

                if (p_move.score < beta)
                {
                    beta = p_move.score;
                    // Save the best move so far
                    BestMove.p.X = p_move.p.X;
                    BestMove.p.Y = p_move.p.Y;
                    BestMove.score = p_move.score;
                }

                if (beta <= alpha)
                {
                    break;
                }

            }

            return BestMove;
        }


    }







    }
