using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Shared;

namespace Client
{
    public partial class TicTacToe : Form
    {
        private GameServerConnector gameServerConnector;
        private Button[,] btnArray;
        private List<Button> buttons;
        private Player player;
        private Player[,] board;

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            CollectButtons();

            gameServerConnector = new GameServerConnector();
            lbl_playerName.Text = string.Empty;
            SetMessage("Start a new game!");

            player = Player.None;
        }

        private void CollectButtons()
        {
            btnArray = new Button[,]
                {
                    {btn_00, btn_01, btn_02},
                    {btn_10, btn_11, btn_12},
                    {btn_20, btn_21, btn_22}
                };

            buttons = new List<Button>
                {
                    btn_00,
                    btn_01,
                    btn_02,
                    btn_10,
                    btn_11,
                    btn_12,
                    btn_20,
                    btn_21,
                    btn_22
                };
        }

        private void StartNewGame_Click(object sender, EventArgs e)
        {
            AssignCurrentPlayer();
            GetBoard();
            InitializeButtons();
            SetMoveText();
            GameLoop.Enabled = true;
            btn_startNewGame.Enabled = false;
        }

        private void GetBoard()
        {
            board = gameServerConnector.GameState.Board;
        }

        private void AssignCurrentPlayer()
        {
            player = gameServerConnector.StartNew();
            lbl_playerName.Text = player.ToString();
        }

        private void InitializeButtons()
        {
            foreach (var button in buttons)
                button.Enabled = true;
            UpdateButtons();
            
            
        }

        public void UpdateButtons()
        {
            for (int x = 0; x < board.GetLength(0); x++)
                for (int y = 0; y < board.GetLength(1); y++)
                    UpdateButton(btnArray[x, y], board[x, y]);
        }

        private void UpdateButton(Button btn, Player move)
        {
            var text = "";
            switch (move)
            {
                case Player.Circle:
                    text = "O";
                    break;
                case Player.Cross:
                    text = "X";
                    break;
                default:
                    text = "";
                    break;
            }
            btn.Text = text;
        }

        private void serverPollTimer_Tick(object sender, EventArgs e)
        {
            if (gameServerConnector.HasChanged())
            {
                GetBoard();
                UpdateButtons();
                SetMoveText();
            }
        }

        private void SetMoveText()
        {
            var message = gameServerConnector.GameState.CurrentPlayer == player
                              ? "Your move."
                              : "Waiting for opponent.";
            SetMessage(message);
        }

        private void SetMessage(string message)
        {
            lbl_message.Text = message;
        }

        private void btn_00_Click(object sender, EventArgs e)
        {
            board[0, 0] = player;
            var gameState = new GameState(player == Player.Circle ? Player.Cross : Player.Circle, board);
            gameServerConnector.GameState = gameState;
        }
    }
}
