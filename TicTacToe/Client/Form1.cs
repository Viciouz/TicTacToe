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
        private GameServer gameServer;
        private Button[,] btnArray;
        private List<Button> buttons;
        private Player player;

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            CollectButtons();

            gameServer = new GameServer();
            lbl_playerName.Text = string.Empty;

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
            InitializeButtons();
            GameLoop.Enabled = true;
        }

        private void AssignCurrentPlayer()
        {
            player = gameServer.StartNew();
            lbl_playerName.Text = player.ToString();
        }

        private void InitializeButtons()
        {
            foreach (var button in buttons)
                button.Enabled = true;
            UpdateButtons(gameServer.GameState.Board);
        }

        public void UpdateButtons(Player[,] gameBoard)
        {
            for (int x = 0; x < gameBoard.GetLength(0); x++)
            {
                for (int y = 0; y < gameBoard.GetLength(1); y++)
                {
                    btnArray[x, y].Text = gameBoard[x, y].ToString();
                }
            }
        }

        private void serverPollTimer_Tick(object sender, EventArgs e)
        {
            if (gameServer.HasChanged())
            {
                UpdateButtons(gameServer.GameState.Board);
            }
        }
    }
}
