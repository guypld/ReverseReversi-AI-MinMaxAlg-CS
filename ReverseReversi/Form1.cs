using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ReverseReversi
{

    public partial class Form1 : Form
    {

        public static AlgorithmEnum PC1Alg;
        public static AlgorithmEnum PC2Alg;

        GameTypeEnum GameType = GameTypeEnum.NoGame;

        // Board [8,8] of type SpotEnum
        SpotEnum[,] Board = new SpotEnum[9, 9];

        // BoardPic [8,8] of type PictureBox (GUI)
        PictureBox[,] BoardPic = new PictureBox[9,9];

        int WhiteCount = 0;
        int BlackCount = 0;

        SpotEnum GameTurn;

        // tells the user where the next avail moves point
        List<Point> AvailibleSpotsToMove = new List<Point>();

        // tell if last move the player make some move, if not then the game should end
        Boolean WasMove = true;

        private static readonly Object display_lock = new Object();

        /// <summary>
        /// Draw Board according to the 'Board' Matrix
        /// </summary>
        private void DrawBoard()
        {
            //lock (display_lock)
            {
                WhiteCount = 0;
                BlackCount = 0;
                for (int i = 1; i <= 8; i++)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        switch (Board[i, j])
                        {
                            case SpotEnum.Empty:
                                if (BoardPic[i, j].Image != imageList.Images[0])
                                {
                                    BoardPic[i, j].Image = imageList.Images[0];
                                }
                                break;
                            case SpotEnum.P1:
                                if (BoardPic[i, j].Image != imageList.Images[1])
                                {
                                    BoardPic[i, j].Image = imageList.Images[1];
                                }
                                WhiteCount++;
                                break;
                            case SpotEnum.P2:
                                if (BoardPic[i, j].Image != imageList.Images[2])
                                {
                                    BoardPic[i, j].Image = imageList.Images[2];
                                }
                                BlackCount++;
                                break;
                            default:
                                break;
                        }
                    }
                }


                String status = String.Empty;

                switch (GameType)
                {
                    case GameTypeEnum.NoGame:
                        status = "No Game";
                        break;
                    case GameTypeEnum.PlayerVsPlayer:
                        status = GameTurn.ToString();
                        break;
                    case GameTypeEnum.PlayerVsPC:
                        if (GameTurn == SpotEnum.P1)
                        {
                            status = "Player Turn..";
                        }
                        else
                        {
                            status = "Thinking..";
                        }
                        break;
                    case GameTypeEnum.PCvsPC:
                        if (GameTurn == SpotEnum.P1)
                        {
                            status = "White Turn..";
                        }
                        else
                        {
                            status = "Black Turn..";
                        }
                        break;
                    default:
                        break;
                }


                this.Invoke((MethodInvoker)delegate
                {
                    // runs on UI thread
                    lblWhiteCount.Text = WhiteCount.ToString();
                    lblBlackCount.Text = BlackCount.ToString();
                    lblStatus.Text = status;
                });

            }
        }

        /// <summary>
        /// Init New Game
        /// </summary>
        private void InitGame()
        {
            //GameType = GameTypeEnum.NoGame;
            lock (display_lock)
            {
                //draw labels
                if (BoardPic[1, 1] == null) //check if this is the first time we draw this objects
                {
                    for (int i = 1; i <= 8; i++)
                    {
                        Label lbl = new Label();
                        lbl.Text = ((char)( ('A' + (i-1)))).ToString();
                        lbl.Visible = true;
                        lbl.Location = new Point((i - 1) * 50 + 1, 0);
                        lbl.Size = new Size(50, 50);
                        lbl.TextAlign = ContentAlignment.TopCenter;
                        lbl.BackColor = System.Drawing.Color.Silver;
                        picLetters.Controls.Add(lbl);

                        Label lbl2 = new Label();
                        lbl2.Text = i.ToString();
                        lbl2.Visible = true;
                        lbl2.Location = new Point(0, (i - 1) * 50 + 1);
                        lbl2.Size = new Size(50, 50);
                        lbl2.TextAlign = ContentAlignment.MiddleLeft;
                        lbl2.BackColor = System.Drawing.Color.Silver;
                        picDigits.Controls.Add(lbl2);

                    }
                }

                for (int i = 1; i <= 8; i++)
                {
                    for (int j = 1; j <= 8; j++)
                    {
                        // INIT BOARD
                        Board[i, j] = SpotEnum.Empty;

                        // Create New SPOT Picture Object
                        if (BoardPic[i, j] == null)
                        {
                            BoardPic[i, j] = new PictureBox();
                            BoardPic[i, j].Visible = true;
                            BoardPic[i, j].Location = new Point((j - 1) * 50, (i - 1) * 50);
                            BoardPic[i, j].Size = new Size(50, 50);
                            BoardPic[i, j].BorderStyle = BorderStyle.FixedSingle;
                            BoardPic[i, j].SizeMode = PictureBoxSizeMode.StretchImage;

                            ToolTip tt = new ToolTip();
                            tt.SetToolTip(BoardPic[i, j], i + "," + j);

                            BoardPic[i, j].Tag = new Point(i, j); // Save i,j for each image

                            BoardPic[i, j].Click += BoardPic_Click; // add click event

                            BoardContainer.Controls.Add(BoardPic[i, j]);    //Add this picture object to the Board Container
                        }
                    }
                }

                Board[4, 4] = SpotEnum.P1;
                Board[4, 5] = SpotEnum.P2;
                Board[5, 4] = SpotEnum.P2;
                Board[5, 5] = SpotEnum.P1;

            }

            DrawBoard();
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGame();
            PC1AlgoCombo.DataSource = Enum.GetValues(typeof(AlgorithmEnum));
            PC2AlgoCombo.DataSource = Enum.GetValues(typeof(AlgorithmEnum)); 
        }


        /// <summary>
        /// Spot Clicked
        /// </summary>
        void BoardPic_Click(object sender, EventArgs e)
        {
            //Get (i,j)
            int i = ((Point)((PictureBox)sender).Tag).X;
            int j = ((Point)((PictureBox)sender).Tag).Y;

            switch (GameType)
            {
                case GameTypeEnum.PlayerVsPlayer:
                    List<Point> lst = AvailibleSpotsToMove.Where(s => s.X == i && s.Y == j).ToList();
                    // This is a valid move!
                    if (lst.Count() > 0)
                    {
                        GameModel.MakeMove(Board, GameTurn, i, j);

                        Application.DoEvents();

                        EndMove();
                    }
                    else
                    {
                        MessageBox.Show("Invalid Move");
                    }
                    break;

                case GameTypeEnum.PlayerVsPC:
                    //Check if player turn
                    if (GameTurn == SpotEnum.P1)
                    {
                        List<Point> lst2 = AvailibleSpotsToMove.Where(s => s.X == i && s.Y == j).ToList();
                        // This is a valid move!
                        if (lst2.Count() > 0)
                        {
                            GameModel.MakeMove(Board, GameTurn, i, j);
                            EndMove();
                        }
                        else
                        {
                            MessageBox.Show("Invalid Move");
                        }   
                    }
                    //else
                    //PC Turn- ignore click
                    break;

                case GameTypeEnum.NoGame:
                case GameTypeEnum.PCvsPC:
                default:
                    break;
            }
        }

        /// <summary>
        /// MENU Click Events
        /// </summary>
        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = sender.ToString();

            switch (name)
            {
                case "Player Starts":   // PCvsPlayer
                    
                    GameType = GameTypeEnum.PlayerVsPC;
                    GameTurn = SpotEnum.P1;
                    InitGame();
                    break;

                case "PC Starts":   // PCvsPlayer

                    GameType = GameTypeEnum.PlayerVsPC;
                    GameTurn = SpotEnum.P2;
                    InitGame();
                    break;


                case "Player vs Player":
                    GameType = GameTypeEnum.PlayerVsPlayer;
                    GameTurn = SpotEnum.P1;
                    InitGame();
                    break;

                case "PC vs PC":
                    GameType = GameTypeEnum.PCvsPC;
                    GameTurn = SpotEnum.P1;
                    InitGame();
                    
                    break;

                case "Exit":
                    Application.Exit();
                    return;

                case "About":
                    MessageBox.Show("Reverse Reversi 2013 (c) A.I , Haifa University" + Environment.NewLine +
                        "Ron Yanovitch" + Environment.NewLine +
                        "Marian Normatov" + Environment.NewLine +
                        "Guy Peled",
                        "About");
                    return;

                default:
                    break;
            }

            PrepareNextMove();
        }

        private void PreparePlayerNextMove()
        {
            AvailibleSpotsToMove = GameModel.GetAvailibleMovesSpots(Board, GameTurn);
            lock (display_lock)
            {
                foreach (var item in AvailibleSpotsToMove)
                {
                    BoardPic[item.X, item.Y].Image = imageList.Images[3];
                }
            }
        }

        private void PreparePCNextMove()
        {
            AvailibleSpotsToMove = GameModel.GetAvailibleMovesSpots(Board, GameTurn);
            lock (display_lock)
            {
                foreach (var item in AvailibleSpotsToMove)
                {
                    BoardPic[item.X, item.Y].Image = imageList.Images[4];
                }
            }
            PCMove pcm = GameModel.GetMinMaxPCMove(Board, GameTurn);
            GameModel.MakeMove(Board, GameTurn, pcm.p.X, pcm.p.Y);
            EndMove();
        }

        /// <summary>
        /// Execute next move according to GameTurn
        /// </summary>
        private void PrepareNextMove()
        {
            switch (GameType)
            {
                case GameTypeEnum.PlayerVsPlayer:
                    PreparePlayerNextMove();
                    break;
                case GameTypeEnum.PlayerVsPC:
                    if (GameTurn == SpotEnum.P1)
                    {
                        PreparePlayerNextMove();    // Player Turn
                    }
                    else
                    {
                        // Set AI Game Values (PC1)
                        GameModel.PCAlgorithm = PC1Alg;
                        GameModel.Depth = Convert.ToInt32(PC1DepthText.Value);
                        GameModel.ColorRatioWeight = Convert.ToDouble(PC1W1Text.Value) ;
                        GameModel.MobilitysWeight = Convert.ToDouble(PC1W2Text.Value) ;
                        GameModel.WeightedBoardWeight = Convert.ToDouble(PC1W3Text.Value) ;
                        GameModel.AvailMoveCountWeight = Convert.ToDouble(PC1W4Text.Value);
                        GameModel.StabilityWeight = Convert.ToDouble(PC1W5Text.Value);
                        GameModel.GetCornersRatioWeight = Convert.ToDouble(PC1W6Text.Value);

                        Thread thread = new Thread(PreparePCNextMove);
                        thread.Start();
                    }
                    break;
                case GameTypeEnum.PCvsPC:
                    if (GameTurn == SpotEnum.P1)
                    {
                        // Set AI Game Values (PC1)
                        GameModel.PCAlgorithm = PC1Alg;
                        GameModel.Depth = Convert.ToInt32(PC1DepthText.Value);
                        GameModel.ColorRatioWeight = Convert.ToDouble(PC1W1Text.Value) ;
                        GameModel.MobilitysWeight = Convert.ToDouble(PC1W2Text.Value) ;
                        GameModel.WeightedBoardWeight = Convert.ToDouble(PC1W3Text.Value) ;
                        GameModel.AvailMoveCountWeight = Convert.ToDouble(PC1W4Text.Value);
                        GameModel.StabilityWeight = Convert.ToDouble(PC1W5Text.Value);
                        GameModel.GetCornersRatioWeight = Convert.ToDouble(PC1W6Text.Value);

                        Thread thread = new Thread(PreparePCNextMove);
                        thread.Start();                        
                    }
                    else
                    {
                        // Set AI Game Values (PC2)
                        GameModel.PCAlgorithm = PC2Alg;
                        GameModel.Depth = Convert.ToInt32(PC2DepthText.Value);
                        GameModel.ColorRatioWeight = Convert.ToDouble(PC2W1Text.Value) ;
                        GameModel.MobilitysWeight = Convert.ToDouble(PC2W2Text.Value) ;
                        GameModel.WeightedBoardWeight = Convert.ToDouble(PC2W3Text.Value) ;
                        GameModel.AvailMoveCountWeight = Convert.ToDouble(PC2W4Text.Value);
                        GameModel.StabilityWeight = Convert.ToDouble(PC2W5Text.Value);
                        GameModel.GetCornersRatioWeight = Convert.ToDouble(PC2W6Text.Value);

                        Thread thread = new Thread(PreparePCNextMove);
                        thread.Start();
                    }
                    break;
                default:
                    break;
            }

        }

        /// <summary>
        /// End Move AND Create next move according to GameTurn and GameType
        /// </summary>
        private void EndMove()
        {
            // SwitchPlayer
            GameTurn = GameModel.SwitchPlayer(GameTurn);

            DrawBoard();

            //IF STILL GAME
            if (GameModel.GetAvailibleMovesSpots(Board, GameTurn).Count > 0)
            {
                PrepareNextMove();
                WasMove = true;
            }
            else
            {
                if (!WasMove)
                {
                    // last turn the other player also didn't move , so finish game
                    EndGame();
                }
                else
                {
                    // it is the first turn that the player can't move, switch turn
                    WasMove = false;
                    EndMove();
                }
            }

        }

        private void EndGame()
        {
            switch (GameType)
            {
                case GameTypeEnum.PlayerVsPlayer:
                    if (WhiteCount < BlackCount)
                    {
                        MessageBox.Show("White Won!");
                    }
                    else if (WhiteCount > BlackCount)
                    {
                        MessageBox.Show("Black Won!");
                    }
                    else
                    {
                        MessageBox.Show("Tie");
                    }
                    break;
                case GameTypeEnum.PlayerVsPC:
                    if (WhiteCount < BlackCount)
                    {
                        MessageBox.Show("You Won!");
                    }
                    else if (WhiteCount > BlackCount)
                    {
                        MessageBox.Show("You Lost!");
                    }
                    else
                    {
                        MessageBox.Show("Tie");
                    }
                    break;
                case GameTypeEnum.PCvsPC:
                    if (WhiteCount < BlackCount)
                    {
                        MessageBox.Show("P1 Won!");
                    }
                    else if (WhiteCount > BlackCount)
                    {
                        MessageBox.Show("P2 Won!");
                    }
                    else
                    {
                        MessageBox.Show("Tie");
                    }
                    break;
                default:
                    break;
            }
        }

        private void PC1AlgoCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            PC1Alg = (AlgorithmEnum)Enum.Parse(typeof(AlgorithmEnum), PC1AlgoCombo.Text);
        }

        private void PC2AlgoCombo_SelectedValueChanged(object sender, EventArgs e)
        {
            PC2Alg = (AlgorithmEnum)Enum.Parse(typeof(AlgorithmEnum), PC2AlgoCombo.Text);
        }


    }
}
